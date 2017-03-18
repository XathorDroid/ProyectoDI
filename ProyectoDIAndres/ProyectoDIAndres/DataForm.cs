using ControlDatos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDIAndres
{

    public partial class DataForm : Form
    {

        String imgFile = null;
        byte viewSelect;
        private Form1 frm1;

        public DataForm(Form1 frm1Send, byte viewSelectSend)
        {
            InitializeComponent();
            frm1 = frm1Send;
            viewSelect = viewSelectSend;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgFile = ofd.FileName;
                pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
                pbImage.Image = Bitmap.FromFile(imgFile);
                lblDimens.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (viewSelect == 1)
            {
                DatosNormal dn = new DatosNormal();
                dn.setDatas(imgFile, txtTitle.Text);

                dn.getPanelPb().Click += frm1.getControlUser;
                dn.getPb().Click += frm1.getControlUser;
                dn.getLbl().Click += frm1.getControlUser;

                dn.getPanelPb().MouseUp += frm1.getControlUser;
                dn.getPb().MouseUp += frm1.getControlUser;
                dn.getLbl().MouseUp += frm1.getControlUser;

                frm1.panelFondo.Controls.Add(dn);
            }
            else if (viewSelect == 2)
            {
                DatosListaImagen dli = new DatosListaImagen();
                dli.setDatas(imgFile, txtTitle.Text);
                
                frm1.panelFondo.Controls.Add(dli);
            }

            panelFondoControles();
            this.Dispose();
        }

        private void panelFondoControles()
        {
            foreach (Control c in frm1.panelFondo.Controls)
            {
                c.ContextMenuStrip = frm1.msControls;
            }
        }

    }
}