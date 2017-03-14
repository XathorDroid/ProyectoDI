using System;
using ControlDatos;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDIAndres {

    public partial class DataForm : Form {

        private String imgFile;
        private Form1 frm1;

        public DataForm(Form1 frm1Send) {
            InitializeComponent();
            frm1 = frm1Send;
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                imgFile = ofd.FileName;
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImage.Image = Bitmap.FromFile(imgFile);
                lblDimens.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            DatosNormal dn = new DatosNormal();
            dn.loadDatas(imgFile, txtTitle.Text);

            int row = Properties.Settings.Default.row;
            int column = Properties.Settings.Default.column;

            //frm1.panelFondo.Controls.Add(dn, column, row);
            frm1.lvItems.Items.Add(txtTitle.Text, imgFile);

            column = column++;
            if (column == 3) {
                row = row++;
                column = 0;
            }

            Properties.Settings.Default.column = column;
            Properties.Settings.Default.row = row;
            Properties.Settings.Default.Save();
            
            this.Dispose();
        }

    }
}