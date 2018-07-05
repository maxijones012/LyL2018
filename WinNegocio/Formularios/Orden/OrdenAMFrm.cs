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
    public partial class OrdenAMFrm : Form, IFormGridReload
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;
        Orden orden;
        DetalleOrden detalle_orden;
        public OrdenAMFrm()
        {
            InitializeComponent();
        }
        public void ShowOrden(Orden ordenIvk, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de orden";
            orden = ordenIvk;
            this.OrdenIdTxt.Text = orden.OrdenId.ToString();
            this.EmpleadoCbo.SelectedItem = orden.EmpleadoObj;
            //cliente
            this.ClienteCbo.SelectedItem = orden.ClienteObj;
            this.FechaOrdenDtp.Value = orden.FechaOrden;
            this.DescuentoTxt.Text = orden.Descuento.ToString();
            this.gridDetallesOrden.AutoGenerateColumns = false;
            this.gridDetallesOrden.DataSource = ManagerDB<DetalleOrden>.findAll("orden_id= " + orden.OrdenId.ToString()); 

            this.ShowDialog();
        }
        public void NewOrden(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nueva Orden";
            this.operacion = OperacionForm.frmAlta;
            this.ShowDialog();
        }

        public void ReloadGrid() {
            this.gridDetallesOrden.Refresh();
        }

        private void OrdenAMFrm_Load(object sender, EventArgs e)
        {
            // propiedades del control a configurar para que se carguen en el control
            this.EmpleadoCbo.DataSource = ManagerDB<Empleado>.findAll();
            this.ClienteCbo.DataSource = ManagerDB<Cliente>.findAll();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.operacion == OperacionForm.frmAlta)
                {
                    orden = new Orden();
                    
                }
                /* Comprobar que esten los datos obligatorios*/
                orden.ClienteId = ((Cliente)ClienteCbo.SelectedItem).ClienteId;
                orden.EmpleadoId = ((Empleado)EmpleadoCbo.SelectedItem).EmpleadoId;
                orden.FechaOrden = FechaOrdenDtp.Value;
                orden.Descuento = Convert.ToInt32(this.DescuentoTxt.Text);
                if (!orden.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nueva Orden" : "Error al intentar editar informacion de Cliente", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (this.operacion == OperacionForm.frmAlta)
                    this.AgregarDetalleBtn.Enabled = true;
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

        private void DetallesOrden_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DetalleOrden deto = new DetalleOrden();

            foreach (DataGridViewRow item in this.gridDetallesOrden.Rows)
            {

                //item.Cells[1].Value = (item.DataBoundItem as DetalleOrden).ProductoObj.Descripcion;

                deto = (item.DataBoundItem as DetalleOrden);
                //item.Cells[0].Value = deto.OrdenObj.OrdenId;
                //item.Cells[0].Value = deto.DetalleId;
                item.Cells[1].Value = deto.ProductoObj.Descripcion;
                //item.Cells[2].Value = deto.Cantidad;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DetalleOrdenAMFrm detfrm = new DetalleOrdenAMFrm();
            detfrm.NewDetalleOrden(this, this.orden.OrdenId, gridDetallesOrden.Rows.Count);
            
            
        }

        private void EmpleadoCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FechaOrdenDtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClienteCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DetallesOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void gridDetallesOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleOrdenFrm detfrm = new DetalleOrdenFrm();
            detfrm.ShowDetalleOrden((gridDetallesOrden.Rows[e.RowIndex].DataBoundItem as DetalleOrden), this);
        }
        void IFormGridReload.ReloadGrid()
        {
            this.gridDetallesOrden.DataSource = ManagerDB<DetalleOrden>.findAll("orden_id= " + orden.OrdenId.ToString()); 
        }
    }
}
