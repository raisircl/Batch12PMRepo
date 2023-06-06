namespace MyWinApp
{
    partial class WinFormDay6Jun2023
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormDay6Jun2023));
            this.tv1 = new System.Windows.Forms.TreeView();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tv1
            // 
            this.tv1.ImageIndex = 0;
            this.tv1.ImageList = this.imageListLarge;
            this.tv1.Location = new System.Drawing.Point(31, 36);
            this.tv1.Name = "tv1";
            this.tv1.SelectedImageIndex = 0;
            this.tv1.Size = new System.Drawing.Size(357, 545);
            this.tv1.TabIndex = 0;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "hard-drive.png");
            this.imageListSmall.Images.SetKeyName(1, "folder.png");
            this.imageListSmall.Images.SetKeyName(2, "open-folder.png");
            this.imageListSmall.Images.SetKeyName(3, "document.png");
            this.imageListSmall.Images.SetKeyName(4, "gaming.png");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "hard-drive.png");
            this.imageListLarge.Images.SetKeyName(1, "folder.png");
            this.imageListLarge.Images.SetKeyName(2, "open-folder.png");
            this.imageListLarge.Images.SetKeyName(3, "document.png");
            this.imageListLarge.Images.SetKeyName(4, "gaming.png");
            // 
            // WinFormDay6Jun2023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 620);
            this.Controls.Add(this.tv1);
            this.Name = "WinFormDay6Jun2023";
            this.Text = "WinFormDay6Jun2023";
            this.Load += new System.EventHandler(this.WinFormDay6Jun2023_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv1;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
    }
}