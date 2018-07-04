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
    public partial class CategoriaAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;

        Categoria cat;
        public void NewCategoria(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo Categoria";
            this.operacion = OperacionForm.frmAlta;
            this.ShowDialog();
        }

        public CategoriaAMFrm()
        {
            InitializeComponent();
        }
        public void ShowCategoria(Categoria categoria, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de categoria";
            cat = categoria;
            this.IdMsk.Enabled = false;
            this.NombreTxt.Text = cat.NombreCategoria;
            this.IdMsk.Text = cat.CategoriaId.ToString();

            this.ShowDialog();
        }
        private void label2_Click(object sender, EventArgs e)
        {

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
                    cat = new Categoria();
                    //cl.ClienteId = Convert.ToInt32(this.IdMsk.Text);
                }
                /* Comprobar que esten los datos obligatorios*/
                cat.NombreCategoria = this.NombreTxt.Text;
                
                if (!cat.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nueva Categoria" : "Error al intentar editar informacion de la Categoria", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nueva Categoria dada de alta" : "Actualizacion de informacion de Categoria", operacion == OperacionForm.frmAlta ? "Ingreso de paciente..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nueva Categoia" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Dispose();

        }

        private void CategoriaAMFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
