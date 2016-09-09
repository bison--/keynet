/*
* SOURCE: http://stackoverflow.com/questions/604410/global-keyboard-capture-in-c-sharp-application
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Threading;

class InterceptKeys
{
    public static int sendUdpPackets = 10;
    public static keynet.frmMain main = null;
    public static UInt64 sendId = 0;
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private static LowLevelKeyboardProc _proc = HookCallback;
    private static IntPtr _hookID = IntPtr.Zero;
    private static keynet.clsSendKeyNet lastWorkerObject = null;
   /* public static void Main()
    {
        _hookID = SetHook(_proc);
        Application.Run();
        UnhookWindowsHookEx(_hookID);
    }*/

    public static void start()
    {
        _hookID = SetHook(_proc);
    }

    public static void stop()
    {
        UnhookWindowsHookEx(_hookID);
    }

    private static IntPtr SetHook(LowLevelKeyboardProc proc)
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
        {
            int vkCode = Marshal.ReadInt32(lParam);
            Keys pressedKey = (Keys)vkCode;
            

            if (main != null && main.isServer)
            {
                if (pressedKey == Keys.Escape || pressedKey == Keys.Space)
                {
                    Console.WriteLine(pressedKey);
                    sendId++;

                    if (lastWorkerObject != null)
                    {
                        lastWorkerObject.RequestStop();
                    }

                    keynet.clsSendKeyNet workerObject = new keynet.clsSendKeyNet();

                    workerObject.sendId = sendId;
                    workerObject.pressedKey = pressedKey;
                    workerObject.sendUdpPackets = sendUdpPackets;

                    try
                    {
                        Thread workerThread = new Thread(workerObject.DoWork);

                        // Start the worker thread.
                        workerThread.Start();

                        // remember the object
                        lastWorkerObject = workerObject;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        lastWorkerObject = null;
                    }
                }
            }
        }

        return CallNextHookEx(_hookID, nCode, wParam, lParam);
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);
}