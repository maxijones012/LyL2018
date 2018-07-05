using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql; // Libreria para conectar con PostgreSQL
using LibNegocio.db; // incluir espacio de nombre para poder acceder a los objetos de negocios.

namespace WinNegocio.Formularios
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {            
            InitializeComponent();
        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {
               
        }     
               

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            ClientesResultsFrm frm = new ClientesResultsFrm();
            frm.ShowDialog();
        }

        private void ListadosBtn_Click(object sender, EventArgs e)
        {
            
        }     
                
        private void SearchDniBtn_Click(object sender, EventArgs e)
        {/*
            Cliente p = new Cliente();
            p.findbykey(this.DniSearchTxt.Text);
            ClientesAMFrm fampac = new ClientesAMFrm();
            fampac.ShowCliente(p);*/
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dgresult = MessageBox.Show("Desea salir del sistema?", "salir....", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dgresult == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteAMFrm frm = new ClienteAMFrm();
            frm.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteBusqFrm pbusq = new ClienteBusqFrm();
            pbusq.Show();
        }

        private void FormTestBtn_Click(object sender, EventArgs e)
        {
            FormTestModel frm = new  FormTestModel();
            frm.Show();
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OrdenAMFrm frm = new OrdenAMFrm();
            frm.NewOrden(null);
        }

        private void listadoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OrdenBusqFrm frm = new OrdenBusqFrm();
            frm.ShowDialog();
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmpleadoAMFrm frm = new EmpleadoAMFrm();
            frm.NewEmpleado(null);
        }

        private void modificacionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmpleadoBusqFrm frm = new EmpleadoBusqFrm();
            frm.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CategoriaAMFrm frm = new CategoriaAMFrm();
            frm.NewCategoria(null);
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CategoriaBusqFrm frm = new CategoriaBusqFrm();
            frm.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProveedorAMFrm frm = new ProveedorAMFrm();
            frm.NewProveedor(null);
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProveedorBusqFrm frm = new ProveedorBusqFrm();
            frm.Show();

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesResultsFrm frm = new ClientesResultsFrm();
            frm.ResultadosCliente(null,null);
           
        }

        private void listadoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmpleadoResultsFrm frm = new EmpleadoResultsFrm();
            frm.ResultadosEmpleado(0, null);
        }

        private void listadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductoResultsFrm frm = new ProductoResultsFrm();
            frm.ResultadosProducto(0, null);
        }

        private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CategoriaResultsFrm frm = new CategoriaResultsFrm();
            frm.ResultadosCategoria("");

        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductoResultsFrm frm = new ProductoResultsFrm();
            frm.ResultadosProducto(0, null);

        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductoAMFrm frm = new ProductoAMFrm();
            frm.NewProducto(null);
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductoBusqFrm frm = new ProductoBusqFrm();
            frm.Show();
        }

        private void modificacionToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OrdenBusqFrm frm = new OrdenBusqFrm();
            frm.ShowDialog();
        }
    }
}
