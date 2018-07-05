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
    public partial class DetalleOrdenAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;
        
        DetalleOrden detalle_orden;

        public DetalleOrdenAMFrm()
        {
            InitializeComponent();
        }

        public void ShowDetalleOrden(DetalleOrden detordenIvk, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de detalle de orden";
            detalle_orden = detordenIvk;
            this.OrdenIdTxt.Text = detalle_orden.OrdenId.ToString();
            DetalleId.Text = detalle_orden.DetalleId.ToString();
            ProductoCbo.SelectedItem = detalle_orden.ProductoObj;
            CantidadTxt.Text = detalle_orden.Cantidad.ToString();
        }
        public void NewDetalleOrden(IFormGridReload frmGrid, int OrdenId, int cantrenglones)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo detalle de Orden";
            this.operacion = OperacionForm.frmAlta;
            cantrenglones++;
            this.OrdenIdTxt.Text = OrdenId.ToString();
            this.DetalleId.Text = cantrenglones.ToString();
            this.ShowDialog();
        }


        private void DetalleOrdenAMFrm_Load(object sender, EventArgs e)
        {
            this.ProductoCbo.DataSource = ManagerDB<Producto>.findAll();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // validar cantidad 
                if (this.operacion == OperacionForm.frmAlta)
                {
                    detalle_orden = new DetalleOrden();
                }
                /* Comprobar que esten los datos obligatorios*/
                detalle_orden.OrdenId = Convert.ToInt32(OrdenIdTxt.Text);
                detalle_orden.DetalleId = Convert.ToInt32(DetalleId.Text);
                detalle_orden.ProductoId = (ProductoCbo.SelectedItem as Producto).ProductoId;
                detalle_orden.Cantidad = Convert.ToInt32(CantidadTxt.Text);
               
                if (!detalle_orden.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo detalle " : "Error al intentar editar informacion de Cliente", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nueva Orden  dado de alta" : "Actualizacion de informacion de Orden", operacion == OperacionForm.frmAlta ? "Ingreso de Orden..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nueva Orden" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_frmGrid != null)
                _frmGrid.ReloadGrid();
            this.Dispose();
        }
    }
}
