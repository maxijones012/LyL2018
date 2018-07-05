namespace WinNegocio.Formularios
{
    partial class ListadoOrden
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
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridOrden = new System.Windows.Forms.DataGridView();
            this.CedulaRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            // 
            // gridOrden
            // 
            this.gridOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CedulaRuc,
            this.NombreCia,
            this.Columna});
            this.gridOrden.Location = new System.Drawing.Point(-2, 1);
            this.gridOrden.Name = "gridOrden";
            this.gridOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrden.Size = new System.Drawing.Size(625, 316);
            this.gridOrden.TabIndex = 15;
            this.gridOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
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
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(494, 356);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(84, 27);
            this.CerrarBtn.TabIndex = 16;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            // 
            // ListadoOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.Controls.Add(this.gridOrden);
            this.Controls.Add(this.CerrarBtn);
            this.Name = "ListadoOrden";
            this.Text = "ListadoOrden";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridView gridOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCia;
        private System.Windows.Forms.Button CerrarBtn;
    }
}