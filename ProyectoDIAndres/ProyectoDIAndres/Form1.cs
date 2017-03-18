using System.Collections.Generic;
using System.Windows.Forms;
using ControlDatos;

namespace ProyectoDIAndres {

    public partial class Form1 : Form {

        public byte viewSelect;
        private List<ControlDatos.DatosNormal> listaDn = new List<DatosNormal>();
        private List<ControlDatos.DatosListaImagen> listaDli = new List<DatosListaImagen>();
        
        public Form1() {
            InitializeComponent();
        }

        private void miNew_Click(object sender, System.EventArgs e) {
            showDataForm();
        }

        private void showDataForm() {
            DataForm frm = new DataForm(this, viewSelect);
            frm.Show();
        }

        private void miIcon_Click(object sender, System.EventArgs e) {
            miIcon.Checked = true;
            tsMiIcon.Checked = true;
            miIconList.Checked = false;
            tsMiIconList.Checked = false;
            viewSelect = 1;

            listaDn.Clear();
            panelFondo.Controls.Clear();
            foreach (DatosListaImagen c in panelFondo.Controls)
            {
                listaDli.Add(c);
            }

            panelFondo.FlowDirection = FlowDirection.LeftToRight;
            foreach (DatosListaImagen c in listaDli)
            {
                DatosNormal dn = new DatosNormal();
                dn.setDatas(c.getImageFile(), c.getTitle());
                panelFondo.Controls.Add(dn);
            }
        }

        private void miIconList_Click(object sender, System.EventArgs e) {
            miIcon.Checked = false;
            tsMiIcon.Checked = false;
            miIconList.Checked = true;
            tsMiIconList.Checked = true;
            viewSelect = 2;
            panelFondo.FlowDirection = FlowDirection.TopDown;

            //listaDli.Clear();
            //foreach (Control c in panelFondo.Controls)
            //{
            //    listaDn.Add((ControlDatos.DatosNormal)c);
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}