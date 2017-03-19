using System.Collections.Generic;
using System.Windows.Forms;
using ControlDatos;
using System;

namespace ProyectoDIAndres {

    public partial class Form1 : Form {

        public byte viewSelect;
        private List<DatosNormal> listaDnVista;
        private List<DatosListaImagen> listaDliVista;
        public List<DatosNormal> listaDnPanel;
        public List<DatosListaImagen> listaDliPanel;
        private DatosNormal dnSelected;
        private DatosListaImagen dliSelected;

        public Form1() {
            InitializeComponent();

            viewSelect = 1;
            listaDnVista = new List<DatosNormal>();
            listaDliVista = new List<DatosListaImagen>();
            listaDnPanel = new List<DatosNormal>();
            listaDliPanel = new List<DatosListaImagen>();
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
                    dn.setDatas(c.getImage(), c.getTitle());
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
                    dli.setDatas(c.getImage(), c.getTitle());
                    eventosDatosListaImagen(dli);
                    listaDliPanel.Add(dli);
                    panelFondo.Controls.Add(dli);
                    panelFondoControles();
                }
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {

        }

        private void miGitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/XathorDroid/ProyectoDI/tree/ProyectoFinal/ProyectoDIAndres";
            System.Diagnostics.Process.Start("IExplore", url);
        }

        private void tsBtnDelAll_Click(object sender, System.EventArgs e)
        {
            panelFondo.Controls.Clear();
            listaDliVista.Clear();
            listaDnVista.Clear();
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
                frm = new DataForm(this, new_edit, viewSelect);
            } else
            {                
                if(viewSelect == 1)
                {
                    int index = panelFondo.Controls.IndexOf(dnSelected);
                    frm = new DataForm(this, new_edit, viewSelect, index, dnSelected);
                } else
                {
                    int index = panelFondo.Controls.IndexOf(dliSelected);
                    frm = new DataForm(this, new_edit, viewSelect, index, dliSelected);
                }
            }
            frm.Show();
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
    }
}