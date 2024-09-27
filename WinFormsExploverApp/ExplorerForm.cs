namespace WinFormsExploverApp
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();

            imageListFlags.Images.Add(Image.FromFile(@"D:\RPO\MaxEfimov\~ PV 312\net winforms\images\flag_angola_enl.jpg"));
            //checkBoxAng.ImageList = imageListFlags;
            //checkBoxAng.ImageIndex = 4;

            listView.Items[4].ImageIndex = 4;
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
    }
}
