using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinNegocio.Formularios
{
    public partial class ProveedorBusqFrm : Form
    {
         public ProveedorBusqFrm()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {

                this.checkBox2.Checked = false;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.IdProveeTxt.Enabled = this.checkBox1.Checked;
            if (this.checkBox1.Checked)
            {
                this.checkBox3.Checked = false;
                this.IdProveeTxt.Focus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.checkBox2.Checked;
            if (this.checkBox2.Checked)
            {
                this.checkBox3.Checked = false;
                this.NombreTxt.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveedorResultsFrm pfrm;
            int id_prove = 0;
            string nombre = null;
            
            
            if (!checkBox3.Checked && !this.checkBox1.Checked && !this.checkBox2.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            //if (!checkBox2.Checked && this.checkBox1.Checked)
              //  nombre = this.NombreTxt.Text;
            if (!checkBox3.Checked && this.checkBox1.Checked)
                id_prove = Convert.ToInt32(this.IdProveeTxt.Text);
                    //Convert.ToInt32(this.IdProveeTxt.Text);
            nombre = NombreTxt.Text;
            pfrm = new ProveedorResultsFrm();
            Cursor.Current = Cursors.WaitCursor;
            this.Visible = false;

            pfrm.ResultadosProveedor(id_prove, nombre);
            
            this.Dispose(); 
        }

        public ProveedorResultsFrm pfrm { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
