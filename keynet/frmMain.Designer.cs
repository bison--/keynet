namespace keynet
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.rdbServer = new System.Windows.Forms.RadioButton();
            this.bgwReciever = new System.ComponentModel.BackgroundWorker();
            this.lblRecieved = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nutUdpPackets = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutUdpPackets)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Location = new System.Drawing.Point(9, 90);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(110, 17);
            this.rdbClient.TabIndex = 1;
            this.rdbClient.Text = "CLIENT (reciever)";
            this.rdbClient.UseVisualStyleBackColor = true;
            this.rdbClient.CheckedChanged += new System.EventHandler(this.rdbClient_CheckedChanged);
            // 
            // rdbServer
            // 
            this.rdbServer.AutoSize = true;
            this.rdbServer.Location = new System.Drawing.Point(9, 57);
            this.rdbServer.Name = "rdbServer";
            this.rdbServer.Size = new System.Drawing.Size(110, 17);
            this.rdbServer.TabIndex = 0;
            this.rdbServer.Text = "SERVER (sender)";
            this.rdbServer.UseVisualStyleBackColor = true;
            this.rdbServer.CheckedChanged += new System.EventHandler(this.rdbServer_CheckedChanged);
            // 
            // bgwReciever
            // 
            this.bgwReciever.WorkerReportsProgress = true;
            this.bgwReciever.WorkerSupportsCancellation = true;
            this.bgwReciever.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwReciever_DoWork);
            this.bgwReciever.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwReciever_ProgressChanged);
            this.bgwReciever.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwReciever_RunWorkerCompleted);
            // 
            // lblRecieved
            // 
            this.lblRecieved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecieved.AutoSize = true;
            this.lblRecieved.Location = new System.Drawing.Point(91, 223);
            this.lblRecieved.Name = "lblRecieved";
            this.lblRecieved.Size = new System.Drawing.Size(10, 13);
            this.lblRecieved.TabIndex = 1;
            this.lblRecieved.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "last received:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 208);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rdbServer);
            this.tabPage1.Controls.Add(this.rdbClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MODE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the mode this instance should operate.\r\nWARNING: Set all the settings BEFO" +
    "RE choosing a mode!\r\nChanging the settings later MIGHT not work for all of them." +
    "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.nutUdpPackets);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sender Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "UDP packets for each key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "send";
            // 
            // nutUdpPackets
            // 
            this.nutUdpPackets.Location = new System.Drawing.Point(45, 6);
            this.nutUdpPackets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nutUdpPackets.Name = "nutUdpPackets";
            this.nutUdpPackets.Size = new System.Drawing.Size(53, 20);
            this.nutUdpPackets.TabIndex = 0;
            this.nutUdpPackets.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nutUdpPackets.ValueChanged += new System.EventHandler(this.nutUdpPackets_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 245);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecieved);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "key.net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutUdpPackets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbClient;
        private System.Windows.Forms.RadioButton rdbServer;
        private System.ComponentModel.BackgroundWorker bgwReciever;
        private System.Windows.Forms.Label lblRecieved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nutUdpPackets;
    }
}

