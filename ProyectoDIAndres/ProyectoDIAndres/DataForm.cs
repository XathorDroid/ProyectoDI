using System;
using ControlDatos;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDIAndres {

    public partial class DataForm : Form {

        private Image image;
        private Form1 frm1;

        public DataForm(Form1 frm1Send) {
            InitializeComponent();
            frm1 = frm1Send;
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                String imgFile = ofd.FileName;
                image = Bitmap.FromFile(imgFile);
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImage.Image = image;
                lblDimens.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            //int row = Properties.Settings.Default.row;
            int count = Properties.Settings.Default.count;
            
            String title = txtTitle.Text;

            //frm1.panelFondo.Controls.Add(dn, column, row);
            frm1.imgCollection.Images.Add(title, image);

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