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
    public partial class ProveedorResultsFrm : Form, IFormGridReload
    {
        public ProveedorResultsFrm()
        {
            InitializeComponent();
        }

        public void ResultadosProveedor(int idProveedor = 0, string nombre = null)
        {
            if (idProveedor == 0 && nombre == null)
            {
                /*
                * Se requiere este seteo para que se posibilite el mapeo de columnas que se Agregaron
                * desde el diseñador, Click con boton derecho sobre seleccion de grilla -> Edit Columns
                */
                this.gridProveedor.AutoGenerateColumns = false;
                List<Proveedor> lista = ManagerDB<Proveedor>.findAll();
                this.gridProveedor.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }

            if (idProveedor != 0 && nombre == null)
            {
                this.gridProveedor.AutoGenerateColumns = false;
                List<Proveedor> lista = ManagerDB<Proveedor>.findAll(String.Format("Id Proveedor = '{0}'", idProveedor));
                this.gridProveedor.DataSource = lista;
            }

            if (idProveedor == 0 && nombre != null)
            {
                this.gridProveedor.AutoGenerateColumns = false;
                List<Proveedor> lista = ManagerDB<Proveedor>.findAll(String.Format("nombre_Proveedor like '%{0}%'", nombre));
                this.gridProveedor.DataSource = lista;
            }
            buscarIDProveedorNombre(idProveedor, nombre);

            this.ShowDialog();
        }

        private void buscarIDProveedorNombre(int idProveedor, string nombre)
        {
            if (idProveedor != 0 && nombre != null)
            {
                this.gridProveedor.AutoGenerateColumns = false;
                List<Proveedor> lista = ManagerDB<Proveedor>.findAll(String.Format("id Proveedor = '{0}' and nombre like '%{1}%'", IdProveedor, nombre));
                this.gridProveedor.DataSource = lista;
            }
        }
        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProveedor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Proveedor p;
            foreach (DataGridViewRow row in gridProveedor.Rows)
            {
                DataGridViewCell cell;
                p = (row.DataBoundItem as Proveedor);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}, {1}", p.ProveedorId, p.NombreProveedor);
            }
        }

        private void NuevoProveedorBtn_Click(object sender, EventArgs e)
        {
            ProveedorAMFrm frm = new ProveedorAMFrm();

            frm.NewProveedor(this);
        }

        public void ReloadGrid()
        {
            this.gridProveedor.Refresh();
        }

        private void ProveedorResultsFrm_Load(object sender, EventArgs e)
        {

        }

        private void gridProveedor_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Proveedor prov;
            foreach (var item in this.gridProveedor.Rows)
            {
                prov = (item as DataGridViewRow).DataBoundItem as Proveedor;
                (item as DataGridViewRow).Cells[2].Value = prov.ProveedorId + " - " + prov.NombreProveedor;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                ProveedorAMFrm frm = new ProveedorAMFrm();

                frm.ShowProveedor((this.gridProveedor.Rows[e.RowIndex].DataBoundItem as Proveedor), this);
            }
        }

        private void ProveedorResultsFrm_Load_1(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
