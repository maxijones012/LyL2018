namespace WinNegocio.Formularios
{
    partial class OrdenAMFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrdenIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpleadoCbo = new System.Windows.Forms.ComboBox();
            this.ClienteCbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaOrdenDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DescuentoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.gridDetallesOrden = new System.Windows.Forms.DataGridView();
            this.Renglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarDetalleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetallesOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrdenId";
            // 
            // OrdenIdTxt
            // 
            this.OrdenIdTxt.Enabled = false;
            this.OrdenIdTxt.Location = new System.Drawing.Point(92, 15);
            this.OrdenIdTxt.Name = "OrdenIdTxt";
            this.OrdenIdTxt.Size = new System.Drawing.Size(96, 20);
            this.OrdenIdTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado:";
            // 
            // EmpleadoCbo
            // 
            this.EmpleadoCbo.DisplayMember = "ApellidoNombre";
            this.EmpleadoCbo.FormattingEnabled = true;
            this.EmpleadoCbo.Location = new System.Drawing.Point(92, 44);
            this.EmpleadoCbo.Name = "EmpleadoCbo";
            this.EmpleadoCbo.Size = new System.Drawing.Size(110, 21);
            this.EmpleadoCbo.TabIndex = 3;
            this.EmpleadoCbo.ValueMember = "EmpleadoId";
            this.EmpleadoCbo.SelectedIndexChanged += new System.EventHandler(this.EmpleadoCbo_SelectedIndexChanged);
            // 
            // ClienteCbo
            // 
            this.ClienteCbo.DisplayMember = "NombreCia";
            this.ClienteCbo.FormattingEnabled = true;
            this.ClienteCbo.Location = new System.Drawing.Point(92, 84);
            this.ClienteCbo.Name = "ClienteCbo";
            this.ClienteCbo.Size = new System.Drawing.Size(110, 21);
            this.ClienteCbo.TabIndex = 5;
            this.ClienteCbo.ValueMember = "ClienteId";
            this.ClienteCbo.SelectedIndexChanged += new System.EventHandler(this.ClienteCbo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente:";
            // 
            // FechaOrdenDtp
            // 
            this.FechaOrdenDtp.Location = new System.Drawing.Point(92, 112);
            this.FechaOrdenDtp.Name = "FechaOrdenDtp";
            this.FechaOrdenDtp.Size = new System.Drawing.Size(156, 20);
            this.FechaOrdenDtp.TabIndex = 6;
            this.FechaOrdenDtp.ValueChanged += new System.EventHandler(this.FechaOrdenDtp_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // DescuentoTxt
            // 
            this.DescuentoTxt.Location = new System.Drawing.Point(96, 147);
            this.DescuentoTxt.Name = "DescuentoTxt";
            this.DescuentoTxt.Size = new System.Drawing.Size(105, 20);
            this.DescuentoTxt.TabIndex = 8;
            this.DescuentoTxt.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descuento:";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(129, 227);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(59, 24);
            this.AceptarBtn.TabIndex = 10;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(216, 227);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(63, 22);
            this.CancelarBtn.TabIndex = 11;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // gridDetallesOrden
            // 
            this.gridDetallesOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetallesOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Renglon,
            this.Producto,
            this.Cantidad});
            this.gridDetallesOrden.Location = new System.Drawing.Point(323, 15);
            this.gridDetallesOrden.Name = "gridDetallesOrden";
            this.gridDetallesOrden.Size = new System.Drawing.Size(344, 185);
            this.gridDetallesOrden.TabIndex = 12;
            this.gridDetallesOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetallesOrden_CellContentClick);
            this.gridDetallesOrden.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetallesOrden_CellDoubleClick);
            this.gridDetallesOrden.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DetallesOrden_DataBindingComplete);
            // 
            // Renglon
            // 
            this.Renglon.DataPropertyName = "DetalleId";
            this.Renglon.HeaderText = "Renglon";
            this.Renglon.Name = "Renglon";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // AgregarDetalleBtn
            // 
            this.AgregarDetalleBtn.Location = new System.Drawing.Point(545, 229);
            this.AgregarDetalleBtn.Name = "AgregarDetalleBtn";
            this.AgregarDetalleBtn.Size = new System.Drawing.Size(106, 23);
            this.AgregarDetalleBtn.TabIndex = 13;
            this.AgregarDetalleBtn.Text = "Agregar Detalle";
            this.AgregarDetalleBtn.UseVisualStyleBackColor = true;
            this.AgregarDetalleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrdenAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 304);
            this.Controls.Add(this.AgregarDetalleBtn);
            this.Controls.Add(this.gridDetallesOrden);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescuentoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaOrdenDtp);
            this.Controls.Add(this.ClienteCbo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpleadoCbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrdenIdTxt);
            this.Controls.Add(this.label1);
            this.Name = "OrdenAMFrm";
            this.Text = "OrdenAMFrm";
            this.Load += new System.EventHandler(this.OrdenAMFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetallesOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrdenIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EmpleadoCbo;
        private System.Windows.Forms.ComboBox ClienteCbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaOrdenDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescuentoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.DataGridView gridDetallesOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renglon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button AgregarDetalleBtn;
    }
}