namespace MyWinApp
{
    partial class Frm29May2023
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm29May2023));
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkPlaying = new System.Windows.Forms.CheckBox();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSameAddress = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerHno = new System.Windows.Forms.TextBox();
            this.txtPerCityVPO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosCityVPO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosHNO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(95, 74);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(81, 20);
            this.chkReading.TabIndex = 0;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkPlaying
            // 
            this.chkPlaying.AutoSize = true;
            this.chkPlaying.Location = new System.Drawing.Point(95, 114);
            this.chkPlaying.Name = "chkPlaying";
            this.chkPlaying.Size = new System.Drawing.Size(74, 20);
            this.chkPlaying.TabIndex = 1;
            this.chkPlaying.Text = "Playing";
            this.chkPlaying.UseVisualStyleBackColor = true;
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(97, 154);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(132, 34);
            this.btnSumbit.TabIndex = 2;
            this.btnSumbit.Text = "Submit";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPerAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPerCityVPO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPerHno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(370, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permanent Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPosAddress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPosCityVPO);
            this.groupBox2.Controls.Add(this.txtPosHNO);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(370, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 197);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postal Address";
            // 
            // chkSameAddress
            // 
            this.chkSameAddress.AutoSize = true;
            this.chkSameAddress.Location = new System.Drawing.Point(370, 226);
            this.chkSameAddress.Name = "chkSameAddress";
            this.chkSameAddress.Size = new System.Drawing.Size(269, 20);
            this.chkSameAddress.TabIndex = 5;
            this.chkSameAddress.Text = "Is your postal address same ad parment";
            this.chkSameAddress.UseVisualStyleBackColor = true;
            this.chkSameAddress.CheckedChanged += new System.EventHandler(this.chkSameAddress_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HNO";
            // 
            // txtPerHno
            // 
            this.txtPerHno.Location = new System.Drawing.Point(100, 30);
            this.txtPerHno.Name = "txtPerHno";
            this.txtPerHno.Size = new System.Drawing.Size(207, 22);
            this.txtPerHno.TabIndex = 1;
            // 
            // txtPerCityVPO
            // 
            this.txtPerCityVPO.Location = new System.Drawing.Point(100, 60);
            this.txtPerCityVPO.Name = "txtPerCityVPO";
            this.txtPerCityVPO.Size = new System.Drawing.Size(207, 22);
            this.txtPerCityVPO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "City or VPO";
            // 
            // txtPerAddress
            // 
            this.txtPerAddress.Location = new System.Drawing.Point(100, 100);
            this.txtPerAddress.Name = "txtPerAddress";
            this.txtPerAddress.Size = new System.Drawing.Size(207, 22);
            this.txtPerAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtPosAddress
            // 
            this.txtPosAddress.Location = new System.Drawing.Point(100, 111);
            this.txtPosAddress.Name = "txtPosAddress";
            this.txtPosAddress.Size = new System.Drawing.Size(207, 22);
            this.txtPosAddress.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // txtPosCityVPO
            // 
            this.txtPosCityVPO.Location = new System.Drawing.Point(100, 71);
            this.txtPosCityVPO.Name = "txtPosCityVPO";
            this.txtPosCityVPO.Size = new System.Drawing.Size(207, 22);
            this.txtPosCityVPO.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "City or VPO";
            // 
            // txtPosHNO
            // 
            this.txtPosHNO.Location = new System.Drawing.Point(100, 41);
            this.txtPosHNO.Name = "txtPosHNO";
            this.txtPosHNO.Size = new System.Drawing.Size(207, 22);
            this.txtPosHNO.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "HNO";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(56, 309);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(173, 22);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "This is demo of Notify Icon";
            this.notifyIcon1.BalloonTipTitle = "Batch12PM";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Batch12PM";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Snow;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 152);
            this.contextMenuStrip1.Text = "About...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "About...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // Frm29May2023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 627);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.chkSameAddress);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.chkPlaying);
            this.Controls.Add(this.chkReading);
            this.Name = "Frm29May2023";
            this.Text = "Frm29May2023";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkPlaying;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSameAddress;
        private System.Windows.Forms.TextBox txtPerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerCityVPO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerHno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPosCityVPO;
        private System.Windows.Forms.TextBox txtPosHNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}