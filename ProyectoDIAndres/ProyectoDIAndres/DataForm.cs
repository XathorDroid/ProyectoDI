using ControlDatos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDIAndres
{

    public partial class DataForm : Form
    {

        String imgFile = null, title = "";
        byte viewSelect;
        private Form1 frm1;
        int idexReceived, new_editReceived;
        DatosNormal dnReceived;
        DatosListaImagen dliReceived;

        public DataForm(Form1 frm1Send, int new_editSend, byte viewSelectSend)
        {
            InitializeComponent();
            frm1 = frm1Send;
            viewSelect = viewSelectSend;
            new_editReceived = new_editSend;
        }

        public DataForm(Form1 frm1Send, int new_editSend, int indexSend, DatosNormal dnSend)
        {
            InitializeComponent();
            frm1 = frm1Send;
            new_editReceived = new_editSend;
            idexReceived = indexSend;
            dnReceived = dnSend;

            title = dliReceived.getTitle();
            imgFile = dliReceived.getImageFile();

            txtTitle.Text = title;
            pbImage.Image = Bitmap.FromFile(imgFile);
            lblDimens.Visible = false;
        }

        public DataForm(Form1 frm1Send, int new_editSend, int indexSend, DatosListaImagen dliSend)
        {
            InitializeComponent();
            frm1 = frm1Send;
            new_editReceived = new_editSend;
            idexReceived = indexSend;
            dliReceived = dliSend;

            title = dliReceived.getTitle();
            imgFile = dliReceived.getImageFile();

            txtTitle.Text = title;
            pbImage.Image = Bitmap.FromFile(imgFile);
            lblDimens.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgFile = ofd.FileName;
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
            title = txtTitle.Text;
            if (new_editReceived == 1)
            {
                if (viewSelect == 1)
                {
                    DatosNormal dn = new DatosNormal();
                    dn.setDatas(imgFile, title);

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
                    dli.setDatas(imgFile, title);

                    dli.getPanelPb().Click += frm1.getControlUser;
                    dli.getPb().Click += frm1.getControlUser;
                    dli.getLbl().Click += frm1.getControlUser;

                    dli.getPanelPb().MouseUp += frm1.getControlUser;
                    dli.getPb().MouseUp += frm1.getControlUser;
                    dli.getLbl().MouseUp += frm1.getControlUser;

                    frm1.panelFondo.Controls.Add(dli);
                }

            } else
            {
                if (viewSelect == 1)
                {
                    DatosNormal dn = new DatosNormal();
                    dn.setDatas(imgFile, title);

                    dn.getPanelPb().Click += frm1.getControlUser;
                    dn.getPb().Click += frm1.getControlUser;
                    dn.getLbl().Click += frm1.getControlUser;

                    dn.getPanelPb().MouseUp += frm1.getControlUser;
                    dn.getPb().MouseUp += frm1.getControlUser;
                    dn.getLbl().MouseUp += frm1.getControlUser;

                    frm1.panelFondo.Controls.SetChildIndex(dn, in);
                }
                else if (viewSelect == 2)
                {
                    DatosListaImagen dli = new DatosListaImagen();
                    dli.setDatas(imgFile, title);

                    dli.getPanelPb().Click += frm1.getControlUser;
                    dli.getPb().Click += frm1.getControlUser;
                    dli.getLbl().Click += frm1.getControlUser;

                    dli.getPanelPb().MouseUp += frm1.getControlUser;
                    dli.getPb().MouseUp += frm1.getControlUser;
                    dli.getLbl().MouseUp += frm1.getControlUser;

                    frm1.panelFondo.Controls.Add(dli);
                }
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