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
    public partial class CategoriaBusqFrm : Form
    {
        public CategoriaBusqFrm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListTodoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ListTodoChk.Checked)
            {
                this.NombreChk.Checked = false;

            }
        }

        private void NombreChk_CheckedChanged_1(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
            if (this.NombreChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.NombreTxt.Focus();
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            CategoriaResultsFrm pfrm;

            string nombre = null;
            if (!ListTodoChk.Checked && !this.NombreChk.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //if (!ListTodoChk.Checked && this.CedulaRucChk.Checked)
            //cedula_ruc = this.CeulaRucTxt.Text;
            if(this.NombreChk.Checked)
                nombre = NombreTxt.Text;
            pfrm = new CategoriaResultsFrm();
            Cursor.Current = Cursors.WaitCursor;
            this.Visible = false;
            pfrm.ResultadosCategoria(nombre);
            this.Dispose(); 
        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
