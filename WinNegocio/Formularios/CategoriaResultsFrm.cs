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
    public partial class CategoriaResultsFrm : Form, IFormGridReload
    {
        public CategoriaResultsFrm()
        {
            InitializeComponent();
        }

        public void ResultadosCategoria(string nombre = null)
        {
            if (nombre == null)
            {
                /*
                * Se requiere este seteo para que se posibilite el mapeo de columnas que se Agregaron
                * desde el diseñador, Click con boton derecho sobre seleccion de grilla -> Edit Columns
                */
                this.GridCategoria.AutoGenerateColumns = false;
                List<Categoria> lista = ManagerDB<Categoria>.findAll();
                this.GridCategoria.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            
            if (nombre != null)
            {
                this.GridCategoria.AutoGenerateColumns = false;
                List<Categoria> lista = ManagerDB<Categoria>.findAll(String.Format("nombre_categoria like '%{0}%'", nombre));
                this.GridCategoria.DataSource = lista;
            }

            this.ShowDialog();
        }


        public void ReloadGrid()
        {
            this.GridCategoria.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void GridCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriaAMFrm frm = new CategoriaAMFrm();

            frm.ShowCategoria((this.GridCategoria.Rows[e.RowIndex].DataBoundItem as Categoria), this);
        }

        private void GridCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
