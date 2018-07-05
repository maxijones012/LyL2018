namespace WinNegocio.Formularios
{
    partial class EmpleadoResultsFrm
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
            this.gridEmpleado = new System.Windows.Forms.DataGridView();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmpleado
            // 
            this.gridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.NombreEmpleado});
            this.gridEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gridEmpleado.Name = "gridEmpleado";
            this.gridEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpleado.Size = new System.Drawing.Size(381, 150);
            this.gridEmpleado.TabIndex = 0;
            this.gridEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpleado_CellContentClick);
            this.gridEmpleado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpleado_CellDoubleClick);
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdEmpleado.DataPropertyName = "EmpleadoId";
            this.IdEmpleado.HeaderText = "EmpleadoId";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Width = 88;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreEmpleado.DataPropertyName = "Nombre";
            this.NombreEmpleado.HeaderText = "NombreEmpleado";
            this.NombreEmpleado.MinimumWidth = 15;
            this.NombreEmpleado.Name = "NombreEmpleado";
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(329, 189);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // EmpleadoResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 221);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.gridEmpleado);
            this.Name = "EmpleadoResultsFrm";
            this.Text = "EmpleadoResultsFrm";
            this.Load += new System.EventHandler(this.EmpleadoResultsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmpleado;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
    }
}