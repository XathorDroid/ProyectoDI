using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoDIAndres {

    public partial class Form1 : Form {

        public byte viewSelect;
        private List<ControlDatos.DatosNormal> listaDn;
        private List<ControlDatos.DatosListaImagen> listaDli;
        
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
            foreach (Control c in panelFondo.Controls)
            {
                listaDli.Add((ControlDatos.DatosListaImagen)c);
            }

            panelFondo.FlowDirection = FlowDirection.LeftToRight;
            foreach (ControlDatos.DatosNormal c in listaDn)
            {
                ControlDatos.DatosNormal dn = new ControlDatos.DatosNormal();
            }
        }

        private void miIconList_Click(object sender, System.EventArgs e) {
            miIcon.Checked = false;
            tsMiIcon.Checked = false;
            miIconList.Checked = true;
            tsMiIconList.Checked = true;
            viewSelect = 2;
            panelFondo.FlowDirection = FlowDirection.TopDown;

            listaDli.Clear();
            foreach (Control c in panelFondo.Controls)
            {
                listaDn.Add((ControlDatos.DatosNormal)c);
            }
        }
    }
}