namespace WinNegocio.Formularios
{
    partial class ProveedorResultsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridProveedor = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerrar = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProveedor
            // 
            this.gridProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.Nombre});
            this.gridProveedor.GridColor = System.Drawing.Color.Lime;
            this.gridProveedor.Location = new System.Drawing.Point(12, 12);
            this.gridProveedor.Name = "gridProveedor";
            this.gridProveedor.Size = new System.Drawing.Size(485, 190);
            this.gridProveedor.TabIndex = 0;
            this.gridProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridProveedor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "ProveedorId";
            this.IdProveedor.HeaderText = "Ident. Proveedor";
            this.IdProveedor.Name = "IdProveedor";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "NombreProveedor";
            this.Nombre.HeaderText = "Nombre Proveedor";
            this.Nombre.Name = "Nombre";
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(458, 226);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 1;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(47, 226);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(299, 13);
            this.info.TabIndex = 16;
            this.info.Text = "Para modificar un proveedor, haga doble click sobre el campo";
            // 
            // ProveedorResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 261);
            this.Controls.Add(this.info);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.gridProveedor);
            this.Location = new System.Drawing.Point(144, 325);
            this.Name = "ProveedorResultsFrm";
            this.Text = "ProveedorResultsFrm";
            this.Load += new System.EventHandler(this.ProveedorResultsFrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProveedor;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label info;
    }
}