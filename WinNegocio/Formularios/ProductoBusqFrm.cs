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
    public partial class ProductoBusqFrm : Form
    {
        public ProductoBusqFrm()
        {
            InitializeComponent();
        }

        private void IdProductoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.IdProductoTxt.Enabled = this.IdProductocheck.Checked;
            if (this.IdProductocheck.Checked)
            {
                this.ListTodocheck.Checked = false;
                this.IdProductocheck.Focus();
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            ProductoResultsFrm pfrm;

            int idProducto = 0;
            string NombreProd = null;
            int esNumero;

            if (!ListTodocheck.Checked && !this.IdProductocheck.Checked && !this.NombreProdcheck.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.NombreProdcheck.Checked && this.NombreProdTxt.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre o parte del nombre.", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else {

                if (this.NombreProdcheck.Checked && Int32.TryParse(this.NombreProdTxt.Text, out esNumero))
                {
                    MessageBox.Show("Solo se pueden ingresar caracteres.", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            
            }

            if (!ListTodocheck.Checked && this.IdProductocheck.Checked)
                idProducto = Convert.ToInt32(this.IdProductoTxt.Text);
            NombreProd = NombreProdTxt.Text;
            pfrm = new ProductoResultsFrm();
            Cursor.Current = Cursors.WaitCursor;
            this.Visible = false;
            pfrm.ResultadosProducto(idProducto, NombreProd);
            this.Dispose();
        }

        private void ListTodoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ListTodocheck.Checked)
            {

                this.IdProductocheck.Checked = false;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BuscarBtn_Click(sender, e);
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void NombreProdcheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
