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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbServer = new System.Windows.Forms.RadioButton();
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.bgwReciever = new System.ComponentModel.BackgroundWorker();
            this.lblRecieved = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbClient);
            this.groupBox1.Controls.Add(this.rdbServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODE";
            // 
            // rdbServer
            // 
            this.rdbServer.AutoSize = true;
            this.rdbServer.Location = new System.Drawing.Point(6, 19);
            this.rdbServer.Name = "rdbServer";
            this.rdbServer.Size = new System.Drawing.Size(110, 17);
            this.rdbServer.TabIndex = 0;
            this.rdbServer.Text = "SERVER (sender)";
            this.rdbServer.UseVisualStyleBackColor = true;
            this.rdbServer.CheckedChanged += new System.EventHandler(this.rdbServer_CheckedChanged);
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Location = new System.Drawing.Point(6, 42);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(110, 17);
            this.rdbClient.TabIndex = 1;
            this.rdbClient.Text = "CLIENT (reciever)";
            this.rdbClient.UseVisualStyleBackColor = true;
            this.rdbClient.CheckedChanged += new System.EventHandler(this.rdbClient_CheckedChanged);
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
            this.lblRecieved.AutoSize = true;
            this.lblRecieved.Location = new System.Drawing.Point(15, 108);
            this.lblRecieved.Name = "lblRecieved";
            this.lblRecieved.Size = new System.Drawing.Size(10, 13);
            this.lblRecieved.TabIndex = 1;
            this.lblRecieved.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 251);
            this.Controls.Add(this.lblRecieved);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbClient;
        private System.Windows.Forms.RadioButton rdbServer;
        private System.ComponentModel.BackgroundWorker bgwReciever;
        private System.Windows.Forms.Label lblRecieved;
    }
}

