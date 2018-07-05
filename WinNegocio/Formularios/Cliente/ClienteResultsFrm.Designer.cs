namespace WinNegocio.Formularios
{
    partial class ClientesResultsFrm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.CedulaRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CedulaRuc,
            this.NombreCia,
            this.NombreContacto,
            this.DirCliente,
            this.Fax,
            this.Email,
            this.Celular,
            this.Fijo});
            this.gridClientes.GridColor = System.Drawing.Color.Lime;
            this.gridClientes.Location = new System.Drawing.Point(2, 2);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(854, 310);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick_1);
            this.gridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellDoubleClick);
            this.gridClientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridClientes_DataBindingComplete_1);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(540, 336);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(84, 27);
            this.CerrarBtn.TabIndex = 14;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // CedulaRuc
            // 
            this.CedulaRuc.DataPropertyName = "CedulaRuc";
            this.CedulaRuc.HeaderText = "Cedula";
            this.CedulaRuc.Name = "CedulaRuc";
            // 
            // NombreCia
            // 
            this.NombreCia.DataPropertyName = "NombreCia";
            this.NombreCia.HeaderText = "Nombre Cia";
            this.NombreCia.Name = "NombreCia";
            // 
            // NombreContacto
            // 
            this.NombreContacto.DataPropertyName = "NombreContacto";
            this.NombreContacto.HeaderText = "NombreContacto";
            this.NombreContacto.Name = "NombreContacto";
            // 
            // DirCliente
            // 
            this.DirCliente.DataPropertyName = "DirCliente";
            this.DirCliente.HeaderText = "Direccion";
            this.DirCliente.Name = "DirCliente";
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // Fijo
            // 
            this.Fijo.DataPropertyName = "Fijo";
            this.Fijo.HeaderText = "Fijo";
            this.Fijo.Name = "Fijo";
            // 
            // ClientesResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 382);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.gridClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesResultsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.ClientesResultsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fijo;
    }
}