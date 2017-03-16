using System;
using ControlDatos;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDIAndres {

    public partial class DataForm : Form {

        String imgFile;
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
            //int row = Properties.Settings.Default.row;
            int count = Properties.Settings.Default.count;

            DatosNormal dn = new DatosNormal();
            dn.loadDatas(imgFile, txtTitle.Text);
            
            String title = txtTitle.Text;

            //frm1.panelFondo.Controls.Add(dn, column, row);

            Graphics theGraphics = Graphics.FromHwnd(this.Handle);
            frm1.imgCollection.Draw(theGraphics, new Point(120, 120), count);

            frm1.lvItems.LargeImageList = frm1.imgCollection;
            frm1.lvItems.Items.Add(title, count);

            //column = column++;
            //if (column == 3) {
            //    row = row++;
            //    column = 0;
            //}

            Properties.Settings.Default.count = count++;
            //Properties.Settings.Default.row = row;
            Properties.Settings.Default.Save();

            this.Dispose();
        }

    }
}