namespace WinNegocio.Formularios
{
    partial class ProductoResultsFrm
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
            this.gridProducto = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cerrar = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducto
            // 
            this.gridProducto.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Nombre,
            this.PrecioUnitario,
            this.Existencia});
            this.gridProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridProducto.Location = new System.Drawing.Point(12, 12);
            this.gridProducto.Name = "gridProducto";
            this.gridProducto.Size = new System.Drawing.Size(528, 231);
            this.gridProducto.TabIndex = 0;
            this.gridProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducto_CellContentClick);
            this.gridProducto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducto_CellDoubleClick);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "ProductoId";
            this.idProducto.HeaderText = "Producto";
            this.idProducto.Name = "idProducto";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Descripcion";
            this.Nombre.HeaderText = "Descripcion";
            this.Nombre.Name = "Nombre";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "Existencia";
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(428, 273);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(56, 264);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(293, 13);
            this.info.TabIndex = 16;
            this.info.Text = "Para modificar un producto, haga doble click sobre el campo";
            // 
            // ProductoResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 308);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.gridProducto);
            this.Location = new System.Drawing.Point(144, 325);
            this.Name = "ProductoResultsFrm";
            this.Text = "ProductoResultsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Label info;
    }
}