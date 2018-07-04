namespace WinNegocio.Formularios
{
    partial class CategoriaResultsFrm
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
            this.GridCategoria = new System.Windows.Forms.DataGridView();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCategoria
            // 
            this.GridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.GridCategoria.Location = new System.Drawing.Point(30, 12);
            this.GridCategoria.Name = "GridCategoria";
            this.GridCategoria.ReadOnly = true;
            this.GridCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCategoria.Size = new System.Drawing.Size(277, 216);
            this.GridCategoria.TabIndex = 0;
            this.GridCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCategoria_CellContentClick);
            this.GridCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCategoria_CellDoubleClick);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(232, 241);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.CerrarBtn.TabIndex = 1;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "NombreCategoria";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CategoriaResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 276);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.GridCategoria);
            this.Name = "CategoriaResultsFrm";
            this.Text = "CategoriaResultsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.GridCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCategoria;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}