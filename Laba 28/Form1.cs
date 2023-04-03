using System.Xml.Linq;

namespace Laba_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Form2 newMDIChild = new Form2();
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Show();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            activeChild.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void horizontalyTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalyTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form name = this.ActiveMdiChild;
            RichTextBox theBox = (RichTextBox)name.ActiveControl;
            Clipboard.SetDataObject(theBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
            IDataObject data = Clipboard.GetDataObject();
            theBox.SelectedText = data.GetData(DataFormats.Text).ToString();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form name = this.ActiveMdiChild;
            RichTextBox theBox = (RichTextBox)name.ActiveControl;
            Clipboard.SetDataObject(theBox.SelectedText);
            theBox.SelectedText = "";
        }
    }
}