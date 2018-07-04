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
    public partial class DetalleOrdenFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;
        //DetalleOrden detalleOrden;

        private DetalleOrden detalleOrden;

        public DetalleOrden DetalleOrden
        {
            get { return detalleOrden; }
            set { detalleOrden = value; }
        }

        private int _ordenId;

        public int OrdenId
        {
            get { return _ordenId; }
            set { _ordenId = value; }
        }
        

        public DetalleOrdenFrm()
        {
            InitializeComponent();
        }

        public void ShowOrden(DetalleOrden ordenIvk, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de orden";
            detalleOrden = ordenIvk;
            this.OrdenIdTxt.Text = detalleOrden.OrdenId.ToString();
            this.ProductoCbo.SelectedItem = detalleOrden.ProductoId;
            this.detalleOrden.Cantidad = Convert.ToInt32(this.cantidadTxt.Text); 

            //cliente
/*this.FechaOrdenDtp.Value = orden.FechaOrden;
this.DescuentoTxt.Text = orden.Descuento.ToString();
this.DetallesOrden.AutoGenerateColumns = false;
this.DetallesOrden.DataSource = ManagerDB<DetalleOrden>.findAll("orden_id= " + orden.OrdenId.ToString());
*/
            this.ShowDialog();
        }

        public void NewDetalleOrden(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo Detalle Orden";
            this.operacion = OperacionForm.frmAlta;
            this.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetalleOrdencs_Load(object sender, EventArgs e)
        {
            this.ProductoCbo.DataSource = ManagerDB<Producto>.findAll();
        }

        private void OrdenIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void detalle_idCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.operacion == OperacionForm.frmAlta)
                {
                    detalleOrden = new DetalleOrden();

                }
                /* Comprobar que esten los datos obligatorios*/
                detalleOrden.ProductoId = ((Producto)ProductoCbo.SelectedItem).ProductoId;
                /*orden.EmpleadoId = ((Empleado)EmpleadoCbo.SelectedItem).EmpleadoId;
                orden.FechaOrden = FechaOrdenDtp.Value;
                orden.Descuento = Convert.ToInt32(this.DescuentoTxt.Text);*/
                if (!detalleOrden.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nueva Orden" : "Error al intentar editar informacion de Cliente", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void OrdenIdTxt_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
