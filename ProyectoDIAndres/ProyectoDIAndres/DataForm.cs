using ControlDatos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDIAndres
{

    public partial class DataForm : Form
    {

        String imgFile = null, title = "";
        Image imagen = null;
        byte viewSelect;
        private Form1 frm1;
        int indexReceived, new_editReceived;
        DatosNormal dnReceived;
        DatosListaImagen dliReceived;

        public DataForm(Form1 frm1Send, int new_editSend, byte viewSelectSend)
        {
            InitializeComponent();
            frm1 = frm1Send;
            viewSelect = viewSelectSend;
            new_editReceived = new_editSend;
        }

        public DataForm(Form1 frm1Send, int new_editSend, byte viewSelectSend, int indexSend, DatosNormal dnSend)
        {
            InitializeComponent();
            frm1 = frm1Send;
            viewSelect = viewSelectSend;
            new_editReceived = new_editSend;
            indexReceived = indexSend;
            dnReceived = dnSend;

            title = dnReceived.getTitle();
            //imgFile = dnReceived.getImageFile();
            imagen = dnReceived.getImage();

            txtTitle.Text = title;
            //pbImage.Image = Bitmap.FromFile(imgFile);
            pbImage.Image = imagen;
            lblDimens.Visible = false;
        }

        public DataForm(Form1 frm1Send, int new_editSend, byte viewSelectSend, int indexSend, DatosListaImagen dliSend)
        {
            InitializeComponent();
            frm1 = frm1Send;
            viewSelect = viewSelectSend;
            new_editReceived = new_editSend;
            indexReceived = indexSend;
            dliReceived = dliSend;

            title = dliReceived.getTitle();
            //imgFile = dliReceived.getImageFile();
            imagen = dliReceived.getImage();

            txtTitle.Text = title;
            //pbImage.Image = Bitmap.FromFile(imgFile);
            pbImage.Image = imagen;
            lblDimens.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgFile = ofd.FileName;
                imagen = Bitmap.FromFile(imgFile);
                pbImage.Image = imagen;
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
                    dn.setDatas(imagen, title);

                    dn.getPanelPb().Click += frm1.getControlUser;
                    dn.getPb().Click += frm1.getControlUser;
                    dn.getLbl().Click += frm1.getControlUser;

                    dn.getPanelPb().MouseUp += frm1.getControlUser;
                    dn.getPb().MouseUp += frm1.getControlUser;
                    dn.getLbl().MouseUp += frm1.getControlUser;

                    frm1.panelFondo.Controls.Add(dn);
                    frm1.listaDnPanel.Add(dn);
                }
                else if (viewSelect == 2)
                {
                    DatosListaImagen dli = new DatosListaImagen();
                    dli.setDatas(imagen, title);

                    dli.getPanelPb().Click += frm1.getControlUser;
                    dli.getPb().Click += frm1.getControlUser;
                    dli.getLbl().Click += frm1.getControlUser;

                    dli.getPanelPb().MouseUp += frm1.getControlUser;
                    dli.getPb().MouseUp += frm1.getControlUser;
                    dli.getLbl().MouseUp += frm1.getControlUser;

                    frm1.panelFondo.Controls.Add(dli);
                    frm1.listaDliPanel.Add(dli);
                }

            } else if(new_editReceived == 2)
            {
                if (viewSelect == 1)
                {
                    DatosNormal dn = new DatosNormal();
                    dn.setDatas(imagen, title);

                    frm1.eventosDatosNormal(dn);

                    frm1.listaDnPanel.RemoveAt(indexReceived);
                    frm1.listaDnPanel.Insert(indexReceived, dn);
                    frm1.panelFondo.Controls.Clear();
                    foreach(DatosNormal d in frm1.listaDnPanel)
                    {
                        frm1.panelFondo.Controls.Add(d);
                    }
                }
                else if (viewSelect == 2)
                {
                    DatosListaImagen dli = new DatosListaImagen();
                    dli.setDatas(imagen, title);

                    frm1.eventosDatosListaImagen(dli);

                    frm1.listaDliPanel.RemoveAt(indexReceived);
                    frm1.listaDliPanel.Insert(indexReceived, dli);
                    frm1.panelFondo.Controls.Clear();
                    foreach(DatosListaImagen d in frm1.listaDliPanel)
                    {
                        frm1.panelFondo.Controls.Add(d);
                    }
                }
            }
            frm1.panelFondoControles();
            this.Dispose();
        }

    }
}