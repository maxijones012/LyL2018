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
            OrdenAMFrm frm = new OrdenAMFrm();
            Orden orden = new Orden();
            orden.findbykey(204);
            frm.ShowOrden(orden, null);
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmpleadoAMFrm frm = new EmpleadoAMFrm();
            frm.NewEmpleado(null);
        }

        private void modificacionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmpleadoAMFrm frm = new EmpleadoAMFrm();
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
    }
}
