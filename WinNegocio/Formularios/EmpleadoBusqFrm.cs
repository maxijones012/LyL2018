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
    public partial class EmpleadoBusqFrm : Form
    {
        
        public EmpleadoBusqFrm()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoResultsFrm pfrm;
            int id_Empleado = 0;
            string nombre_Empleado = null;
            if (!ListarTodoCbo.Checked && !this.idEmpleadoCbo.Checked && !this.NombreCheckBox.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                if (!ListarTodoCbo.Checked && this.idEmpleadoCbo.Checked)
                    id_Empleado = Convert.ToInt32(this.idEmpleadoTxt.Text);
                nombre_Empleado = NombreEmpTxt.Text;
                pfrm = new EmpleadoResultsFrm();
                Cursor.Current = Cursors.WaitCursor;
                this.Visible = false;
                pfrm.ResultadosEmpleado(id_Empleado,nombre_Empleado);
                this.Dispose();
            }

        private void NombreEmplChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreEmpTxt.Enabled = this.NombreCheckBox.Checked;
            if (this.NombreCheckBox.Checked)
            {
                this.ListarTodoCbo.Checked = false;
                this.NombreCheckBox.Focus();
            }
        }
        private void ListarTodo_Changed(object sender, EventArgs e)
        {
            if (this.ListarTodoCbo.Checked)
            {

                this.idEmpleadoCbo.Checked = false;
                
            }
        }

        private void idEmpleadoCbo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NombreCbo_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreEmpTxt.Enabled = this.NombreCheckBox.Checked;
            if (this.NombreCheckBox.Checked) {

                this.ListarTodoCbo.Checked = false;
                this.NombreEmpTxt.Focus();

            }
        }

        private void NombreEmpTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
