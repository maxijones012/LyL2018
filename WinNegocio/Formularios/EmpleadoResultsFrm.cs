using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibNegocio.db;

namespace WinNegocio.Formularios
{
    public partial class EmpleadoResultsFrm : Form, IFormGridReload
    {
        public EmpleadoResultsFrm()
        {
            InitializeComponent();
        }



        public void ResultadosEmpleado(int idEmpleado = 0, string nombreEmpleado = null)
        {
            if (idEmpleado == 0 && nombreEmpleado == "")
            {
                /*
                * Se requiere este seteo para que se posibilite el mapeo de columnas que se Agregaron
                * desde el diseñador, Click con boton derecho sobre seleccion de grilla -> Edit Columns
                */
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll();
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }

            if (idEmpleado != 0 && nombreEmpleado == "")
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("empleado_id = '{0}'", idEmpleado));
                this.gridEmpleado.DataSource = lista;
            }

            if (idEmpleado == 0 && nombreEmpleado != "")
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                                                                                //ESTE NOMBRE SE DEBE CORRESPONDE CON LA BASA nombre del string = nombre de la base;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%'", nombreEmpleado));
                this.gridEmpleado.DataSource = lista;
            }
            if (idEmpleado != 0 && nombreEmpleado != "")
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll();
                this.gridEmpleado.DataSource = lista;
            }

            this.ShowDialog();
        }
       

        private void EmpleadoResultsFrm_Load(object sender, EventArgs e)
        {

        }

        public void ReloadGrid()
        {
            this.gridEmpleado.Refresh();
        }

        private void gridEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpleadoAMFrm frm = new EmpleadoAMFrm();


            frm.ShowEmpleado((this.gridEmpleado.Rows[e.RowIndex].DataBoundItem as Empleado), this);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
