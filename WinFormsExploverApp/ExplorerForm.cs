using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsExploverApp
{
    public partial class ExplorerForm : Form
    {
        Dictionary<string, FileType> fileExtensions;
        public ExplorerForm()
        {
            InitializeComponent();

            //imageListFlags.Images.Add(Image.FromFile(@"D:\RPO\MaxEfimov\~ PV 312\net winforms\images\flag_angola_enl.jpg"));
            //checkBoxAng.ImageList = imageListFlags;
            //checkBoxAng.ImageIndex = 4;

            //listView.Items[4].ImageIndex = 4;

            //treeViewDirs.ImageList = imageListIcons;
            //TreeNode nodeNew = new TreeNode("node new");
            ////nodeNew.ImageIndex = 0;
            //treeViewDirs.Nodes.Add(nodeNew);

            //nodeNew.Nodes.Add(new TreeNode("level 2-1"));
            //nodeNew.Nodes.Add(new TreeNode("level 2-2"));

            fileExtensions = new()
            {
                { "docx", FileType.Word },
                { "pdf", FileType.Pdf },
                { "txt", FileType.Txt },
                { "jpg", FileType.Jpeg },
                { "png", FileType.Png },
            };

            FillDrives();
        }

        private void btnLargeView_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
        }

        private void btnSmallView_Click(object sender, EventArgs e)
        {
            listView.View = View.SmallIcon;
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            listView.View = View.List;
        }

        private void btnTileView_Click(object sender, EventArgs e)
        {
            listView.View = View.Tile;
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;
        }

        private void FillDrives()
        {
            treeViewDirs.Nodes.Clear();

            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady && drive.Name.ToLower() != @"z:\")
                    {
                        TreeNode node = new TreeNode() { Text = drive.Name };
                        treeViewDirs.Nodes.Add(node);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void FillDirsNode(TreeNode parent, string path)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode node = new TreeNode();
                    node.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    parent.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void FillDirsList(string path)
        {
            listView.Items.Clear();

            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    ListViewItem item = new();
                    item.Text = dir.Remove(0, dir.LastIndexOf(@"\") + 1);
                    item.ImageIndex = 0;
                    item.SubItems.Add("<Directory>");
                    DirectoryInfo directoryInfo = new DirectoryInfo(dir);
                    item.SubItems.Add(directoryInfo.CreationTime.ToShortDateString());
                    listView.Items.Add(item);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    if(File.Exists(file))
                    {
                        ListViewItem item = new();
                        item.Text = file.Remove(0, file.LastIndexOf(@"\") + 1);

                        string ext = file.Remove(0, file.LastIndexOf(@".") + 1);
                        if (fileExtensions.ContainsKey(ext))
                            item.ImageIndex = (int)fileExtensions[ext];
                        else
                            item.ImageIndex = 1;

                        FileInfo fileInfo = new FileInfo(file);
                        item.SubItems.Add(fileInfo.Length.ToString());
                        item.SubItems.Add(fileInfo.CreationTime.ToShortDateString());
                        listView.Items.Add(item);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void treeViewDirs_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();

            try
            {
                if (Directory.Exists(e.Node?.FullPath))
                {
                    foreach(string dir in Directory.GetDirectories(e.Node?.FullPath))
                    {
                        TreeNode node = new TreeNode();
                        node.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                        FillDirsNode(node, dir);
                        e.Node.Nodes.Add(node);
                    }
                    FillDirsList(e.Node.FullPath);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
