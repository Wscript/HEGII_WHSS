using System;
using System.Windows.Forms;

namespace HEGII_WHSS
{
    public partial class formMDIMain : Form
    {
        private int childFormNumber = 0;

        public formMDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAboutBox formAboutBox = new formAboutBox();
            formAboutBox.Show();
        }

        private void menuItemOrderQuery_Click(object sender, EventArgs e)
        {
            formOrderQuery formOrderQuery = new formOrderQuery();
            formOrderQuery.MdiParent = this;
            formOrderQuery.Show();
        }

        private void MenuItemWarehouseMgt_Click(object sender, EventArgs e)
        {
            formWarehouseMgt formWarehouseMgt = new formWarehouseMgt();
            formWarehouseMgt.MdiParent = this;
            formWarehouseMgt.Show();
        }

        private void MenuItemLocationMgt_Click(object sender, EventArgs e)
        {
            formLocationMgt formLocationMgt = new formLocationMgt();
            formLocationMgt.MdiParent = this;
            formLocationMgt.Show();
        }

        private void MenuItemOrderInput_Click(object sender, EventArgs e)
        {
            formOrderInput formOrderInput = new formOrderInput();
            formOrderInput.MdiParent = this;
            formOrderInput.Show();
        }

        private void MenuItemServiceDateConfirm_Click(object sender, EventArgs e)
        {
            formServiceDateConfirm formServiceDateConfirm = new formServiceDateConfirm();
            formServiceDateConfirm.MdiParent = this;
            formServiceDateConfirm.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formMDIMain_Load(object sender, EventArgs e)
        {
            StatusLabelUserName.Text = Global.stringUserName;
        }
    }
}
