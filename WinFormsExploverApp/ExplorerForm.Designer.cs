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
            ListViewItem listViewItem1 = new ListViewItem("Russia", 0);
            ListViewItem listViewItem2 = new ListViewItem("England", 3);
            ListViewItem listViewItem3 = new ListViewItem("Argentina", 2);
            ListViewItem listViewItem4 = new ListViewItem("Austria", 1);
            ListViewItem listViewItem5 = new ListViewItem("Angola");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            TreeNode treeNode1 = new TreeNode("Узел0");
            TreeNode treeNode2 = new TreeNode("Узел2");
            TreeNode treeNode3 = new TreeNode("Узел5");
            TreeNode treeNode4 = new TreeNode("Узел7");
            TreeNode treeNode5 = new TreeNode("Узел8");
            TreeNode treeNode6 = new TreeNode("Узел6", new TreeNode[] { treeNode4, treeNode5 });
            TreeNode treeNode7 = new TreeNode("Узел3", new TreeNode[] { treeNode3, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Узел4");
            TreeNode treeNode9 = new TreeNode("Узел1", new TreeNode[] { treeNode2, treeNode7, treeNode8 });
            splitContainer = new SplitContainer();
            btnTableView = new Button();
            btnTileView = new Button();
            btnListView = new Button();
            btnSmallView = new Button();
            btnLargeView = new Button();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            imageListFlags = new ImageList(components);
            treeView1 = new TreeView();
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
            splitContainer.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer.Panel2
            // 
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
            // btnTableView
            // 
            btnTableView.Font = new Font("Segoe UI", 14F);
            btnTableView.Location = new Point(636, 486);
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
            btnTileView.Location = new Point(495, 486);
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
            btnListView.Location = new Point(354, 486);
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
            btnSmallView.Location = new Point(213, 486);
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
            btnLargeView.Location = new Point(72, 486);
            btnLargeView.Name = "btnLargeView";
            btnLargeView.Size = new Size(135, 53);
            btnLargeView.TabIndex = 1;
            btnLargeView.Text = "Large View";
            btnLargeView.UseVisualStyleBackColor = true;
            btnLargeView.Click += btnLargeView_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView.Font = new Font("Segoe UI", 14F);
            listView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            listView.LargeImageList = imageListFlags;
            listView.Location = new Point(72, 56);
            listView.Name = "listView";
            listView.Size = new Size(699, 412);
            listView.SmallImageList = imageListFlags;
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Country";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Capital";
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
            // treeView1
            // 
            treeView1.Location = new Point(27, 68);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Узел0";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Узел2";
            treeNode3.Name = "Узел5";
            treeNode3.Text = "Узел5";
            treeNode4.Name = "Узел7";
            treeNode4.Text = "Узел7";
            treeNode5.Name = "Узел8";
            treeNode5.Text = "Узел8";
            treeNode6.Name = "Узел6";
            treeNode6.Text = "Узел6";
            treeNode7.Name = "Узел3";
            treeNode7.Text = "Узел3";
            treeNode8.Name = "Узел4";
            treeNode8.Text = "Узел4";
            treeNode9.Name = "Узел1";
            treeNode9.Text = "Узел1";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode9 });
            treeView1.Size = new Size(221, 418);
            treeView1.TabIndex = 0;
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
        private TreeView treeView1;
    }
}
