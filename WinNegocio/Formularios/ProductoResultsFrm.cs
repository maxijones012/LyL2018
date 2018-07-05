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
    public partial class ProductoResultsFrm : Form, IFormGridReload
    {
        public ProductoResultsFrm()
        {
            InitializeComponent();
        }

        public void ResultadosProducto(int idProducto = 0, string nombre = "")
        {
            if (idProducto == 0 && nombre == "")
            {
                /*
                * Se requiere este seteo para que se posibilite el mapeo de columnas que se Agregaron
                * desde el diseñador, Click con boton derecho sobre seleccion de grilla -> Edit Columns
                */
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll();
                this.gridProducto.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }

            if (idProducto != 0 && nombre == "")
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("producto_id = '{0}'", idProducto));
                this.gridProducto.DataSource = lista;
            }

            if (idProducto == 0 && nombre != "")
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("descripcion like '%{0}%'", nombre));
                this.gridProducto.DataSource = lista;
            }
            if (idProducto != 0 && nombre != "")
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("producto_id = '{0}' and descripcion like '%{1}%'", idProducto, nombre));
                this.gridProducto.DataSource = lista;
            }

            this.ShowDialog();
        }
        private void gridProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoAMFrm frm = new ProductoAMFrm();

            frm.ShowProducto((this.gridProducto.Rows[e.RowIndex].DataBoundItem as Producto), this);
        }
        private void gridProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void ReloadGrid()
        {
            this.gridProducto.Refresh();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
