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
            cambiarVista(miIcon, tsMiIcon, miIconList, tsMiIconList);
            viewSelect = 1;

            listaDnVista.Clear();
            foreach (DatosListaImagen c in panelFondo.Controls)
            {
                listaDliVista.Add(c);
            }
            panelFondo.Controls.Clear();

            panelFondo.FlowDirection = FlowDirection.LeftToRight;
            foreach (DatosListaImagen c in listaDliVista)
            {
                DatosNormal dn = new DatosNormal();
                dn.setDatas(c.getImageFile(), c.getTitle());
                panelFondo.Controls.Add(dn);
            }
        }

        private void miIconList_Click(object sender, System.EventArgs e) {
            cambiarVista(miIconList, tsMiIconList, miIcon, tsMiIcon);
            viewSelect = 2;

            listaDliVista.Clear();
            foreach (DatosNormal c in panelFondo.Controls)
            {
                listaDnVista.Add(c);
            }
            panelFondo.Controls.Clear();

            panelFondo.FlowDirection = FlowDirection.TopDown;
            foreach (DatosNormal c in listaDnVista)
            {
                DatosListaImagen dli = new DatosListaImagen();
                dli.setDatas(c.getImageFile(), c.getTitle());
                panelFondo.Controls.Add(dli);
            }
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
                    frm = new DataForm(this, new_edit, index, dnSelected);
                } else
                {
                    int index = panelFondo.Controls.IndexOf(dliSelected);
                    frm = new DataForm(this, new_edit, index, dliSelected);
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
    }
}