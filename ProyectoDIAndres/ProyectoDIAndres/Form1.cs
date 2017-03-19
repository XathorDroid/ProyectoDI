using System.Collections.Generic;
using System.Windows.Forms;
using ControlDatos;
using System;
using System.Threading;
using System.Globalization;
using System.Drawing;

namespace ProyectoDIAndres {

    public partial class Form1 : Form {

        public byte viewSelect;
        private string language = "";
        public List<DatosNormal> listaDnPanel;
        public List<DatosListaImagen> listaDliPanel;
        public List<string> titles;
        public List<string> imageFiles;
        private DatosNormal dnSelected;
        private DatosListaImagen dliSelected;

        public Form1()
        {
            InitializeComponent();

            language = Thread.CurrentThread.CurrentUICulture.Name;
            if (language == "es-ES")
            {
                miSpain.Checked = true;
            }
            else
            {
                miEnglish.Checked = true;
            }

            viewSelect = 1;
            listaDnPanel = new List<DatosNormal>();
            listaDliPanel = new List<DatosListaImagen>();
            titles = new List<string>();
            imageFiles = new List<string>();
            dnSelected = null;
            dliSelected = null;
        }

        private void miNew_Click(object sender, System.EventArgs e) {
            showDataForm(1);
        }

        private void miExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void miIcon_Click(object sender, System.EventArgs e)
        {
            if (miIcon.Checked == false)
            {
                cambiarVista(miIcon, tsMiIcon, miIconList, tsMiIconList);
                viewSelect = 1;

                listaDnPanel.Clear();
                listaDliPanel.Clear();
                foreach (DatosListaImagen c in panelFondo.Controls)
                {
                    listaDliPanel.Add(c);
                }
                panelFondo.Controls.Clear();

                panelFondo.FlowDirection = FlowDirection.LeftToRight;
                foreach (DatosListaImagen c in listaDliPanel)
                {
                    DatosNormal dn = new DatosNormal();
                    dn.setDatas(c.getImage(), c.getTitle(), c.getImageFile());
                    eventosDatosNormal(dn);
                    listaDnPanel.Add(dn);
                    panelFondo.Controls.Add(dn);
                    panelFondoControles();
                }
            }
        }

        private void miIconList_Click(object sender, System.EventArgs e) {
            if (miIconList.Checked == false)
            {
                cambiarVista(miIconList, tsMiIconList, miIcon, tsMiIcon);
                viewSelect = 2;

                listaDliPanel.Clear();
                listaDnPanel.Clear();
                foreach (DatosNormal c in panelFondo.Controls)
                {
                    listaDnPanel.Add(c);
                }
                panelFondo.Controls.Clear();

                panelFondo.FlowDirection = FlowDirection.TopDown;
                foreach (DatosNormal c in listaDnPanel)
                {
                    DatosListaImagen dli = new DatosListaImagen();
                    dli.setDatas(c.getImage(), c.getTitle(), c.getImageFile());
                    eventosDatosListaImagen(dli);
                    listaDliPanel.Add(dli);
                    panelFondo.Controls.Add(dli);
                    panelFondoControles();
                }
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm(language);
            af.ShowDialog();
        }

        private void miGitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/XathorDroid/ProyectoDI/tree/ProyectoFinal/ProyectoDIAndres";
            System.Diagnostics.Process.Start("IExplore", url);
        }

        private void miEnglish_Click(object sender, EventArgs e)
        {
            if (!miEnglish.Checked)
            {
                language = "";

                guardarColeccionTemporal();

                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                Controls.Clear();
                InitializeComponent();
                miEnglish.Checked = true;
                miSpain.Checked = false;

                recuperarColeccionTemporal();
            }
        }

        private void miSpain_Click(object sender, EventArgs e)
        {
            if (!miSpain.Checked)
            {
                language = "es";

                guardarColeccionTemporal();

                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                Controls.Clear();
                InitializeComponent();
                miSpain.Checked = true;
                miEnglish.Checked = false;

                recuperarColeccionTemporal();
            }
        }

        private void tsBtnDelAll_Click(object sender, System.EventArgs e)
        {
            panelFondo.Controls.Clear();
            listaDliPanel.Clear();
            listaDnPanel.Clear();
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            if (dnSelected != null || dliSelected != null)
            {
                showDataForm(2);
            }
        }

        private void cmsRemove_Click(object sender, EventArgs e) {
            if (viewSelect == 1)
            {
                int var = 0;
                foreach(DatosNormal d in listaDnPanel)
                {
                    if(d.Equals(dnSelected))
                    {
                        var = listaDnPanel.IndexOf(d);
                    }
                }
                listaDnPanel.RemoveAt(var);
                panelFondo.Controls.Remove(dnSelected);
            } else
            {
                int var = 0;
                foreach(DatosListaImagen d in listaDliPanel)
                {
                    if(d.Equals(dliSelected))
                    {
                        var = listaDliPanel.IndexOf(d);
                    }
                }
                listaDliPanel.RemoveAt(var);
                panelFondo.Controls.Remove(dliSelected);
            }
        }

        public void getControlUser(object sender, EventArgs e) {
            cleanBackgrounds();

            if (sender is Panel)
            {
                Panel panel = (Panel)sender;
                if (panel.Parent is DatosNormal)
                {
                    dnSelected = (DatosNormal)panel.Parent;
                    dnSelected.BackColor = System.Drawing.Color.Aquamarine;
                } else
                {
                    dliSelected = (DatosListaImagen)panel.Parent;
                    dliSelected.BackColor = System.Drawing.Color.Aquamarine;
                }
            }
            else if (sender is Label)
            {
                Label lbl = (Label)sender;
                if (lbl.Parent.Parent is DatosNormal)
                {
                    dnSelected = (DatosNormal)lbl.Parent.Parent;
                    dnSelected.BackColor = System.Drawing.Color.Aquamarine;
                } else
                {
                    dliSelected = (DatosListaImagen)lbl.Parent.Parent;
                    dliSelected.BackColor = System.Drawing.Color.Aquamarine;
                }
            }
            else if (sender is PictureBox)
            {
                PictureBox pb = (PictureBox)sender;
                if (pb.Parent.Parent is DatosNormal)
                {
                    dnSelected = (DatosNormal)pb.Parent.Parent;
                    dnSelected.BackColor = System.Drawing.Color.Aquamarine;
                } else
                {
                    dliSelected = (DatosListaImagen)pb.Parent.Parent;
                    dliSelected.BackColor = System.Drawing.Color.Aquamarine;
                }
            }
        }

        private void panelFondo_Click(object sender, EventArgs e)
        {
            cleanBackgrounds();
        }

        private void showDataForm(byte new_edit)
        {
            DataForm frm;

            if (new_edit == 1)
            {
                frm = new DataForm(this, new_edit, viewSelect, language);
            } else
            {                
                if(viewSelect == 1)
                {
                    int index = panelFondo.Controls.IndexOf(dnSelected);
                    frm = new DataForm(this, new_edit, viewSelect, index, dnSelected, language);
                } else
                {
                    int index = panelFondo.Controls.IndexOf(dliSelected);
                    frm = new DataForm(this, new_edit, viewSelect, index, dliSelected, language);
                }
            }
            //frm.Show();
            frm.ShowDialog();
        }

        private void cambiarVista(ToolStripMenuItem mi1, ToolStripMenuItem ts1, ToolStripMenuItem mi2, ToolStripMenuItem ts2)
        {
            mi1.Checked = true;
            ts1.Checked = true;
            mi2.Checked = false;
            ts2.Checked = false;
        }

        private void cleanBackgrounds()
        {
            if (dnSelected != null)
            {
                dnSelected.BackColor = System.Drawing.Color.Transparent;
            }

            if (dliSelected != null)
            {
                dliSelected.BackColor = System.Drawing.Color.Transparent;
            }
        }

        public void eventosDatosNormal(DatosNormal dn)
        {
            dn.getPanelPb().Click += getControlUser;
            dn.getPb().Click += getControlUser;
            dn.getLbl().Click += getControlUser;

            dn.getPanelPb().MouseUp += getControlUser;
            dn.getPb().MouseUp += getControlUser;
            dn.getLbl().MouseUp += getControlUser;
        }

        public void eventosDatosListaImagen(DatosListaImagen dli)
        {
            dli.getPanelPb().Click += getControlUser;
            dli.getPb().Click += getControlUser;
            dli.getLbl().Click += getControlUser;

            dli.getPanelPb().MouseUp += getControlUser;
            dli.getPb().MouseUp += getControlUser;
            dli.getLbl().MouseUp += getControlUser;
        }

        public void panelFondoControles()
        {
            foreach (Control c in panelFondo.Controls)
            {
                c.ContextMenuStrip = msControls;
            }
        }

        public void guardarColeccionTemporal()
        {
            if(viewSelect == 1)
            {
                titles.Clear();
                imageFiles.Clear();
                foreach(DatosNormal d in panelFondo.Controls)
                {
                    titles.Add(d.getTitle());
                    imageFiles.Add(d.getImageFile());
                }
            } else
            {
                titles.Clear();
                imageFiles.Clear();
                foreach (DatosListaImagen d in panelFondo.Controls)
                {
                    titles.Add(d.getTitle());
                    imageFiles.Add(d.getImageFile());
                }
            }
            Properties.Settings.Default.vista = viewSelect;
            Properties.Settings.Default.titles = titles;
            Properties.Settings.Default.imageFiles = imageFiles;
        }

        public void recuperarColeccionTemporal()
        {
            Image imagen = null;

            viewSelect = Properties.Settings.Default.vista;
            titles = Properties.Settings.Default.titles;
            imageFiles = Properties.Settings.Default.imageFiles;

            if(viewSelect == 1)
            {
                miIcon.Checked = true;
                tsMiIcon.Checked = true;
                miIconList.Checked = false;
                tsMiIconList.Checked = false;
                for (int i = 0; i < titles.Count; i++)
                {
                    DatosNormal dn = new DatosNormal();
                    if(imageFiles[i] != null)
                    {
                        imagen = Bitmap.FromFile(imageFiles[i]);
                    } else
                    {
                        imagen = null;
                    }
                    dn.setDatas(imagen, titles[i], imageFiles[i]);

                    eventosDatosNormal(dn);

                    panelFondo.Controls.Add(dn);
                }
            } else
            {
                miIconList.Checked = true;
                tsMiIconList.Checked = true;
                miIcon.Checked = false;
                tsMiIcon.Checked = false;
                for (int i = 0; i < titles.Count; i++)
                {
                    DatosListaImagen dli = new DatosListaImagen();
                    if (imageFiles[i] != null)
                    {
                        imagen = Bitmap.FromFile(imageFiles[i]);
                    }
                    else
                    {
                        imagen = null;
                    }
                    dli.setDatas(imagen, titles[i], imageFiles[i]);

                    eventosDatosListaImagen(dli);

                    panelFondo.Controls.Add(dli);
                }
            }
            panelFondoControles();
        }
    }
}