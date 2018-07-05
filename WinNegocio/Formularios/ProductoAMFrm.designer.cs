namespace WinNegocio.Formularios
{
    partial class ProductoAMFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.PrecioUnitTxt = new System.Windows.Forms.TextBox();
            this.ExistenciaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdProovcbo = new System.Windows.Forms.ComboBox();
            this.IdCategoriaBco = new System.Windows.Forms.ComboBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdProducto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(86, 146);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(100, 20);
            this.DescripcionTxt.TabIndex = 7;
            // 
            // PrecioUnitTxt
            // 
            this.PrecioUnitTxt.Location = new System.Drawing.Point(86, 172);
            this.PrecioUnitTxt.Name = "PrecioUnitTxt";
            this.PrecioUnitTxt.Size = new System.Drawing.Size(100, 20);
            this.PrecioUnitTxt.TabIndex = 8;
            // 
            // ExistenciaTxt
            // 
            this.ExistenciaTxt.Location = new System.Drawing.Point(86, 208);
            this.ExistenciaTxt.Name = "ExistenciaTxt";
            this.ExistenciaTxt.Size = new System.Drawing.Size(100, 20);
            this.ExistenciaTxt.TabIndex = 9;
            this.ExistenciaTxt.TextChanged += new System.EventHandler(this.ExistenciaTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio Unitario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Existencia";
            // 
            // IdProovcbo
            // 
            this.IdProovcbo.DisplayMember = "NombreProveedor";
            this.IdProovcbo.FormattingEnabled = true;
            this.IdProovcbo.Location = new System.Drawing.Point(86, 66);
            this.IdProovcbo.Name = "IdProovcbo";
            this.IdProovcbo.Size = new System.Drawing.Size(121, 21);
            this.IdProovcbo.TabIndex = 12;
            this.IdProovcbo.ValueMember = "ProveedorId";
            this.IdProovcbo.SelectedIndexChanged += new System.EventHandler(this.IdProovcbo_SelectedIndexChanged);
            // 
            // IdCategoriaBco
            // 
            this.IdCategoriaBco.DisplayMember = "NombreCategoria";
            this.IdCategoriaBco.FormattingEnabled = true;
            this.IdCategoriaBco.Location = new System.Drawing.Point(87, 106);
            this.IdCategoriaBco.Name = "IdCategoriaBco";
            this.IdCategoriaBco.Size = new System.Drawing.Size(121, 21);
            this.IdCategoriaBco.TabIndex = 13;
            this.IdCategoriaBco.ValueMember = "IdCategoria";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(42, 255);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 14;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(164, 254);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 15;
            this.CancelarBtn.Text = "Cancelar ";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ProductoAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 289);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.IdCategoriaBco);
            this.Controls.Add(this.IdProovcbo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExistenciaTxt);
            this.Controls.Add(this.PrecioUnitTxt);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductoAMFrm";
            this.Text = "ProductoAMFrm";
            this.Load += new System.EventHandler(this.ProductoAMFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.TextBox PrecioUnitTxt;
        private System.Windows.Forms.TextBox ExistenciaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IdProovcbo;
        private System.Windows.Forms.ComboBox IdCategoriaBco;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}