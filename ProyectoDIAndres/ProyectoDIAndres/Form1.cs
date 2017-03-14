using System.Windows.Forms;

namespace ProyectoDIAndres { 

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void miNew_Click(object sender, System.EventArgs e) {
            DataForm frm = new DataForm(this);
            frm.Show();
        }

        private void tsBtnNew_Click(object sender, System.EventArgs e) {
            DataForm frm = new DataForm(this);
            frm.Show();
        }
    }
}