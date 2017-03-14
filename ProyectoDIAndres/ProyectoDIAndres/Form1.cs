using System.Windows.Forms;

namespace ProyectoDIAndres {

    public partial class Form1 : Form
    {

        private byte viewSelect;

        public Form1()
        {
            InitializeComponent();
        }

        private void miNew_Click(object sender, System.EventArgs e)
        {
            showDataForm();
        }

        private void tsBtnNew_Click(object sender, System.EventArgs e)
        {
            showDataForm();
        }

        private void showDataForm()
        {
            DataForm frm = new DataForm(this);
            frm.Show();
        }

        private void miIcon_Click(object sender, System.EventArgs e)
        {
            miIcon.Checked = true;
            tsMiIcon.Checked = true;
            miList.Checked = false;
            tsMiList.Checked = false;
            miIconList.Checked = false;
            tsMiIconList.Checked = false;
            viewSelect = 1;
        }

        private void miList_Click(object sender, System.EventArgs e)
        {
            miIcon.Checked = false;
            tsMiIcon.Checked = false;
            miList.Checked = true;
            tsMiList.Checked = true;
            miIconList.Checked = false;
            tsMiIconList.Checked = false;
            viewSelect = 2;
        }

        private void miIconList_Click(object sender, System.EventArgs e)
        {
            miIcon.Checked = false;
            tsMiIcon.Checked = false;
            miList.Checked = false;
            tsMiList.Checked = false;
            miIconList.Checked = true;
            tsMiIconList.Checked = true;
            viewSelect = 3;
        }
    }
}