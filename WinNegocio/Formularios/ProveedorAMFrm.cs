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
    public enum OperacionFormProv
    {
        frmConsulta = 0, frmAlta = 1, frmModificacion = 2
    }

    public partial class ProveedorAMFrm : Form
    {
        OperacionFormProv operacion = OperacionFormProv.frmConsulta;
        IFormGridReload _frmGrid;

        Proveedor prov;
        public ProveedorAMFrm()
        {
            InitializeComponent();
        }

        public void ShowProveedor(Proveedor proveedor, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionFormProv.frmModificacion;
            this.Text = "Modificacion de informacion de Proveedor";
            prov = proveedor;
            //this.IdMsk.Enabled = false;
            this.id.Text = Convert.ToString(prov.ProveedorId);
            this.nombre.Text = prov.NombreProveedor;
            this.contacto.Text= prov.ContactoProveedor;
            this.celular.Text= prov.CeluProveedor;
            this.fijo.Text= prov.FijoProveedor;
            this.ShowDialog();
        }

        public void NewProveedor(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo Proveedor";
            this.operacion = OperacionFormProv.frmAlta;
            this.ShowDialog();
        }



        private void AceptarBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.operacion == OperacionFormProv.frmAlta)
                {
                    prov = new Proveedor();
                    //prov.ProveedorId = Convert.ToInt32(this.id.Text);
                }
                /* Comprobar que esten los datos obligatorios*/
                prov.NombreProveedor = this.nombre.Text;
                prov.ContactoProveedor = this.contacto.Text;
                prov.CeluProveedor = this.celular.Text;
                prov.FijoProveedor = this.fijo.Text;             
                //prov.saveObj();
                if (!prov.saveObj())
                {
                    MessageBox.Show(operacion == OperacionFormProv.frmAlta ? "Error al intentar ingresar nuevo Proveedor" : "Error al intentar editar informacion de Proveedor", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionFormProv.frmAlta ? "Nuevo Proveedor dado de alta" : "Actualizacion de informacion de Proveedor", operacion == OperacionFormProv.frmAlta ? "Ingreso de paciente..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar " + (operacion == OperacionFormProv.frmAlta ? "ingresar nuevo Cliente" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_frmGrid != null)
                _frmGrid.ReloadGrid();
                this.Dispose();
        }

        private void ProveedorAMFrm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

 
    }
}
