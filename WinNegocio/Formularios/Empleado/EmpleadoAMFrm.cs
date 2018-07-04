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
    public enum OperacionFormEmpleado
    {
        frmConsulta = 0, frmAlta = 1, frmModificacion = 2
    }

    public partial class EmpleadoAMFrm : Form
    {
        OperacionFormEmpleado operacion = OperacionFormEmpleado.frmConsulta;
        IFormGridReload _frmGrid;

        Empleado emp;
        public EmpleadoAMFrm()
        {
            InitializeComponent();
        }

        public void ShowEmpleado(Empleado em, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionFormEmpleado.frmModificacion;
            this.Text = "Modificacion de informacion de Empleado";
            em = emp;
            this.IdMsk.Enabled = false;
           // this.EmpleadoIdTxt = Convert.ToInt32(em.EmpleadoId);
            this.NombreTxt.Text = em.Nombre;
            this.fechaEmpleadoDte.Value = em.FechaNac;
            this.Reporta_aCbo.SelectedItem = em.EmpleadoId;
  
            this.ShowDialog();
        }

        public void NewEmpleado(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nueva Orden";
            this.operacion = OperacionFormEmpleado.frmAlta;
            this.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoIdTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void AceptarBtn_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    if (this.operacion == OperacionFormEmpleado.frmAlta)
                    {
                        emp = new Empleado();
                        
                    }
                    /* Comprobar que esten los datos obligatorios*/
                    emp.Nombre = this.NombreTxt.Text;
                    emp.Apellido = this.apellidoTxt.Text;
                    emp.FechaNac = fechaEmpleadoDte.Value;
                    //emp.FechaNac = Convert.ToDateTime(this.FechaNacTxt.Text);
                    emp.ReportaA = (this.Reporta_aCbo.SelectedItem as Empleado).EmpleadoId;
                    //emp.Extension = Convert.ToInt32(this.Extension.Text);
                    //emp.saveObj();
                    if (!emp.saveObj())
                    {
                        MessageBox.Show(operacion == OperacionFormEmpleado.frmAlta ? "Error al intentar ingresar nuevo Empleado" : "Error al intentar editar informacion de Empleado", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show(operacion == OperacionFormEmpleado.frmAlta ? "Nuevo Empleado dado de alta" : "Actualizacion de informacion de Empleado", operacion == OperacionFormEmpleado.frmAlta ? "Ingreso de Empleado..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar " + (operacion == OperacionFormEmpleado.frmAlta ? "ingresar nuevo Empleado" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_frmGrid != null)
                    _frmGrid.ReloadGrid();
                this.Dispose();
            }
        }

        private void EmpleadoAMFrm_Load_1(object sender, EventArgs e)
        {
            this.Reporta_aCbo.DataSource = ManagerDB<Empleado>.findAll();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NombreCiaTxt_TextChanged(object sender, EventArgs e)
        {

        }






    }
}
