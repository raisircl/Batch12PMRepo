namespace MyWinApp
{
    partial class Frm13June2023
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txturl = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(32, 91);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1156, 531);
            this.webBrowser1.TabIndex = 0;
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.txturl.Location = new System.Drawing.Point(32, 44);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(1073, 41);
            this.txturl.TabIndex = 1;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(1112, 46);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(75, 38);
            this.btngo.TabIndex = 2;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // Frm13June2023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 689);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Frm13June2023";
            this.Text = "Frm13June2023";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button btngo;
    }
}