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
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.lv1 = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv1
            // 
            this.tv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv1.ImageIndex = 0;
            this.tv1.ImageList = this.imageListLarge;
            this.tv1.Location = new System.Drawing.Point(0, 0);
            this.tv1.Name = "tv1";
            this.tv1.SelectedImageIndex = 0;
            this.tv1.Size = new System.Drawing.Size(460, 620);
            this.tv1.TabIndex = 0;
            this.tv1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv1_AfterSelect);
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
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv1.ContextMenuStrip = this.contextMenuStrip1;
            this.lv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv1.HideSelection = false;
            this.lv1.LargeImageList = this.imageListLarge;
            this.lv1.Location = new System.Drawing.Point(0, 0);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(1241, 620);
            this.lv1.SmallImageList = this.imageListSmall;
            this.lv1.TabIndex = 1;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.DoubleClick += new System.EventHandler(this.lv1_DoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv1);
            this.splitContainer1.Size = new System.Drawing.Size(1705, 620);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLargeIcon,
            this.tsmiSmallIcon,
            this.tsmiList,
            this.tsmiDetail});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 100);
            // 
            // tsmiLargeIcon
            // 
            this.tsmiLargeIcon.Name = "tsmiLargeIcon";
            this.tsmiLargeIcon.Size = new System.Drawing.Size(210, 24);
            this.tsmiLargeIcon.Text = "Large Icon";
            this.tsmiLargeIcon.Click += new System.EventHandler(this.tsmiLargeIcon_Click);
            // 
            // tsmiSmallIcon
            // 
            this.tsmiSmallIcon.Name = "tsmiSmallIcon";
            this.tsmiSmallIcon.Size = new System.Drawing.Size(210, 24);
            this.tsmiSmallIcon.Text = "Small Icon";
            this.tsmiSmallIcon.Click += new System.EventHandler(this.tsmiSmallIcon_Click);
            // 
            // tsmiList
            // 
            this.tsmiList.Name = "tsmiList";
            this.tsmiList.Size = new System.Drawing.Size(210, 24);
            this.tsmiList.Text = "List";
            this.tsmiList.Click += new System.EventHandler(this.tsmiList_Click);
            // 
            // tsmiDetail
            // 
            this.tsmiDetail.Name = "tsmiDetail";
            this.tsmiDetail.Size = new System.Drawing.Size(210, 24);
            this.tsmiDetail.Text = "Detail";
            this.tsmiDetail.Click += new System.EventHandler(this.tsmiDetail_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Of Modified";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            // 
            // WinFormDay6Jun2023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 620);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WinFormDay6Jun2023";
            this.Text = "WinFormDay6Jun2023";
            this.Load += new System.EventHandler(this.WinFormDay6Jun2023_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv1;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem tsmiLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiList;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetail;
    }
}