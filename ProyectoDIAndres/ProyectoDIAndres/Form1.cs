using System.Collections.Generic;
using System.Windows.Forms;
using ControlDatos;

namespace ProyectoDIAndres {

    public partial class Form1 : Form {

        public byte viewSelect;
        private List<DatosNormal> listaDn;
        private List<DatosListaImagen> listaDli;
        
        public Form1() {
            InitializeComponent();

            viewSelect = 1;
            listaDn = new List<DatosNormal>();
            listaDli = new List<DatosListaImagen>();
        }

        private void miNew_Click(object sender, System.EventArgs e) {
            showDataForm();
        }

        private void miExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void miIcon_Click(object sender, System.EventArgs e)
        {
            cambiarVista(miIcon, tsMiIcon, miIconList, tsMiIconList);
            viewSelect = 1;

            listaDn.Clear();
            foreach (DatosListaImagen c in panelFondo.Controls)
            {
                listaDli.Add(c);
            }
            panelFondo.Controls.Clear();

            panelFondo.FlowDirection = FlowDirection.LeftToRight;
            foreach (DatosListaImagen c in listaDli)
            {
                DatosNormal dn = new DatosNormal();
                dn.setDatas(c.getImageFile(), c.getTitle());
                panelFondo.Controls.Add(dn);
            }
        }

        private void miIconList_Click(object sender, System.EventArgs e) {
            cambiarVista(miIconList, tsMiIconList, miIcon, tsMiIcon);
            viewSelect = 2;
            
            listaDli.Clear();
            foreach (DatosNormal c in panelFondo.Controls)
            {
                listaDn.Add(c);
            }
            panelFondo.Controls.Clear();

            panelFondo.FlowDirection = FlowDirection.TopDown;
            foreach (DatosNormal c in listaDn)
            {
                DatosListaImagen dli = new DatosListaImagen();
                dli.setDatas(c.getImageFile(), c.getTitle());
                panelFondo.Controls.Add(dli);
            }
        }

        private void tsBtnDelAll_Click(object sender, System.EventArgs e)
        {
            panelFondo.Controls.Clear();
            listaDli.Clear();
            listaDn.Clear();
        }

        private void showDataForm()
        {
            DataForm frm = new DataForm(this, viewSelect);
            frm.Show();
        }

        private void cambiarVista(ToolStripMenuItem mi1, ToolStripMenuItem ts1, ToolStripMenuItem mi2, ToolStripMenuItem ts2)
        {
            mi1.Checked = true;
            ts1.Checked = true;
            mi2.Checked = false;
            ts2.Checked = false;
        }
    }
}