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
    public partial class ProductoAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;
                
        Producto prod;

        public ProductoAMFrm()
        {
            InitializeComponent();
        }

        public void ShowProducto(Producto producto, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de Producto";
            prod = producto;
            //this.IdM.Enabled = false;
            this.IdProovcbo.Text = Convert.ToString(prod.ProveedorId);
            this.IdCategoriaBco.Text = Convert.ToString(prod.CategoriaId);
            this.DescripcionTxt.Text = prod.Descripcion;
            this.PrecioUnitTxt.Text = Convert.ToString(prod.PrecioUnitario);
            this.ExistenciaTxt.Text = Convert.ToString(prod.Existencia);

            this.ShowDialog();
        }

        public void NewProducto (IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo Producto";
            this.operacion = OperacionForm.frmAlta;
            this.ShowDialog();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (this.operacion == OperacionForm.frmAlta)
                    {
                        prod = new Producto();
                        //cl.ClienteId = Convert.ToInt32(this.IdMsk.Text);
                    }
                    /* Comprobar que esten los datos obligatorios*/
                    prod.Descripcion = this.DescripcionTxt.Text;
                    prod.CategoriaId = (this.IdCategoriaBco.SelectedItem as Categoria).CategoriaId;
                    prod.ProveedorId = (this.IdProovcbo.SelectedItem as Proveedor).ProveedorId;
                    prod.Existencia = Convert.ToInt32(this.ExistenciaTxt.Text);
                    prod.PrecioUnitario = Convert.ToInt32(this.PrecioUnitTxt.Text);
                    //prod.saveObj();
                    if (!prod.saveObj())
                    {
                        MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo Producto" : "Error al intentar editar informacion de Producto", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nuevo Producto dado de alta" : "Actualizacion de informacion de Producto", operacion == OperacionForm.frmAlta ? "Ingreso de Producto..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nuevo Producto" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_frmGrid != null)
                    _frmGrid.ReloadGrid();
                this.Dispose();
            }

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void IdProovcbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductoAMFrm_Load(object sender, EventArgs e)
        {
            this.IdProovcbo.DataSource = ManagerDB<Proveedor>.findAll();
            this.IdCategoriaBco.DataSource = ManagerDB<Categoria>.findAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExistenciaTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
