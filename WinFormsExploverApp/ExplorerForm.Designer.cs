namespace WinFormsExploverApp
{
    partial class ExplorerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            splitContainer = new SplitContainer();
            treeViewDirs = new TreeView();
            btnTableView = new Button();
            btnTileView = new Button();
            btnListView = new Button();
            btnSmallView = new Button();
            btnLargeView = new Button();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            imageListIconsLarge = new ImageList(components);
            imageListIcons = new ImageList(components);
            imageListFlags = new ImageList(components);
            btnPathUp = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(treeViewDirs);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(btnPathUp);
            splitContainer.Panel2.Controls.Add(btnTableView);
            splitContainer.Panel2.Controls.Add(btnTileView);
            splitContainer.Panel2.Controls.Add(btnListView);
            splitContainer.Panel2.Controls.Add(btnSmallView);
            splitContainer.Panel2.Controls.Add(btnLargeView);
            splitContainer.Panel2.Controls.Add(listView);
            splitContainer.Size = new Size(1103, 569);
            splitContainer.SplitterDistance = 274;
            splitContainer.TabIndex = 0;
            // 
            // treeViewDirs
            // 
            treeViewDirs.Dock = DockStyle.Fill;
            treeViewDirs.Font = new Font("Segoe UI", 14F);
            treeViewDirs.Location = new Point(0, 0);
            treeViewDirs.Name = "treeViewDirs";
            treeViewDirs.Size = new Size(274, 569);
            treeViewDirs.TabIndex = 0;
            treeViewDirs.BeforeExpand += treeViewDirs_BeforeExpand;
            treeViewDirs.BeforeSelect += treeViewDirs_BeforeExpand;
            // 
            // btnTableView
            // 
            btnTableView.Font = new Font("Segoe UI", 14F);
            btnTableView.Location = new Point(687, 0);
            btnTableView.Name = "btnTableView";
            btnTableView.Size = new Size(135, 53);
            btnTableView.TabIndex = 1;
            btnTableView.Text = "Table View";
            btnTableView.UseVisualStyleBackColor = true;
            btnTableView.Click += btnTableView_Click;
            // 
            // btnTileView
            // 
            btnTileView.Font = new Font("Segoe UI", 14F);
            btnTileView.Location = new Point(546, 0);
            btnTileView.Name = "btnTileView";
            btnTileView.Size = new Size(135, 53);
            btnTileView.TabIndex = 1;
            btnTileView.Text = "Tile View";
            btnTileView.UseVisualStyleBackColor = true;
            btnTileView.Click += btnTileView_Click;
            // 
            // btnListView
            // 
            btnListView.Font = new Font("Segoe UI", 14F);
            btnListView.Location = new Point(405, 0);
            btnListView.Name = "btnListView";
            btnListView.Size = new Size(135, 53);
            btnListView.TabIndex = 1;
            btnListView.Text = "List View";
            btnListView.UseVisualStyleBackColor = true;
            btnListView.Click += btnListView_Click;
            // 
            // btnSmallView
            // 
            btnSmallView.Font = new Font("Segoe UI", 14F);
            btnSmallView.Location = new Point(264, 0);
            btnSmallView.Name = "btnSmallView";
            btnSmallView.Size = new Size(135, 53);
            btnSmallView.TabIndex = 1;
            btnSmallView.Text = "Small View";
            btnSmallView.UseVisualStyleBackColor = true;
            btnSmallView.Click += btnSmallView_Click;
            // 
            // btnLargeView
            // 
            btnLargeView.Font = new Font("Segoe UI", 14F);
            btnLargeView.Location = new Point(137, 0);
            btnLargeView.Name = "btnLargeView";
            btnLargeView.Size = new Size(121, 53);
            btnLargeView.TabIndex = 1;
            btnLargeView.Text = "Large View";
            btnLargeView.UseVisualStyleBackColor = true;
            btnLargeView.Click += btnLargeView_Click;
            // 
            // listView
            // 
            listView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView.Font = new Font("Segoe UI", 14F);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.LargeImageList = imageListIconsLarge;
            listView.Location = new Point(2, 59);
            listView.Name = "listView";
            listView.Size = new Size(823, 510);
            listView.SmallImageList = imageListIcons;
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Size";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Date Create";
            columnHeader3.Width = 150;
            // 
            // imageListIconsLarge
            // 
            imageListIconsLarge.ColorDepth = ColorDepth.Depth32Bit;
            imageListIconsLarge.ImageStream = (ImageListStreamer)resources.GetObject("imageListIconsLarge.ImageStream");
            imageListIconsLarge.TransparentColor = Color.Transparent;
            imageListIconsLarge.Images.SetKeyName(0, "folder.png");
            imageListIconsLarge.Images.SetKeyName(1, "file.png");
            imageListIconsLarge.Images.SetKeyName(2, "docx.png");
            imageListIconsLarge.Images.SetKeyName(3, "pdf.png");
            imageListIconsLarge.Images.SetKeyName(4, "txt.png");
            imageListIconsLarge.Images.SetKeyName(5, "jpg.png");
            imageListIconsLarge.Images.SetKeyName(6, "png.png");
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
            imageListIcons.TransparentColor = Color.Transparent;
            imageListIcons.Images.SetKeyName(0, "folder.png");
            imageListIcons.Images.SetKeyName(1, "file.png");
            imageListIcons.Images.SetKeyName(2, "docx.png");
            imageListIcons.Images.SetKeyName(3, "pdf.png");
            imageListIcons.Images.SetKeyName(4, "txt.png");
            imageListIcons.Images.SetKeyName(5, "jpg.png");
            imageListIcons.Images.SetKeyName(6, "png.png");
            // 
            // imageListFlags
            // 
            imageListFlags.ColorDepth = ColorDepth.Depth32Bit;
            imageListFlags.ImageStream = (ImageListStreamer)resources.GetObject("imageListFlags.ImageStream");
            imageListFlags.TransparentColor = Color.Transparent;
            imageListFlags.Images.SetKeyName(0, "flag_rf_enl.jpg");
            imageListFlags.Images.SetKeyName(1, "flag_avstriya_enl.jpg");
            imageListFlags.Images.SetKeyName(2, "flag_argentina_enl.jpg");
            imageListFlags.Images.SetKeyName(3, "flag_england1.jpg");
            // 
            // btnPathUp
            // 
            btnPathUp.Font = new Font("Segoe UI", 14F);
            btnPathUp.Location = new Point(3, 0);
            btnPathUp.Name = "btnPathUp";
            btnPathUp.Size = new Size(109, 53);
            btnPathUp.TabIndex = 2;
            btnPathUp.Text = "Dir Up";
            btnPathUp.UseVisualStyleBackColor = true;
            // 
            // ExplorerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 569);
            Controls.Add(splitContainer);
            Name = "ExplorerForm";
            Text = "Form1";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private ImageList imageListFlags;
        private ListView listView;
        private Button btnTableView;
        private Button btnTileView;
        private Button btnListView;
        private Button btnSmallView;
        private Button btnLargeView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TreeView treeViewDirs;
        private ImageList imageListIcons;
        private ImageList imageListIconsLarge;
        private ColumnHeader columnHeader3;
        private Button btnPathUp;
    }
}
