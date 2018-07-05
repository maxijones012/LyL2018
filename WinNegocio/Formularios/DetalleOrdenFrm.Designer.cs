namespace WinNegocio.Formularios
{
    partial class DetalleOrdenFrm
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
            this.ProductoCbo = new System.Windows.Forms.ComboBox();
            this.producto_id = new System.Windows.Forms.Label();
            this.detalle_idCbo = new System.Windows.Forms.Label();
            this.OrdenIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidadTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DetalleIdTxt = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductoCbo
            // 
            this.ProductoCbo.DisplayMember = "Descripcion";
            this.ProductoCbo.FormattingEnabled = true;
            this.ProductoCbo.Location = new System.Drawing.Point(101, 77);
            this.ProductoCbo.Name = "ProductoCbo";
            this.ProductoCbo.Size = new System.Drawing.Size(110, 21);
            this.ProductoCbo.TabIndex = 3;
            this.ProductoCbo.ValueMember = "ProductoId";
            this.ProductoCbo.SelectedIndexChanged += new System.EventHandler(this.ProductoCbo_SelectedIndexChanged);
            // 
            // producto_id
            // 
            this.producto_id.AutoSize = true;
            this.producto_id.Location = new System.Drawing.Point(31, 85);
            this.producto_id.Name = "producto_id";
            this.producto_id.Size = new System.Drawing.Size(53, 13);
            this.producto_id.TabIndex = 6;
            this.producto_id.Text = "Producto:";
            // 
            // detalle_idCbo
            // 
            this.detalle_idCbo.AutoSize = true;
            this.detalle_idCbo.Location = new System.Drawing.Point(40, 55);
            this.detalle_idCbo.Name = "detalle_idCbo";
            this.detalle_idCbo.Size = new System.Drawing.Size(52, 13);
            this.detalle_idCbo.TabIndex = 4;
            this.detalle_idCbo.Text = "DetalleId:";
            this.detalle_idCbo.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrdenIdTxt
            // 
            this.OrdenIdTxt.Enabled = false;
            this.OrdenIdTxt.Location = new System.Drawing.Point(101, 19);
            this.OrdenIdTxt.Name = "OrdenIdTxt";
            this.OrdenIdTxt.ReadOnly = true;
            this.OrdenIdTxt.Size = new System.Drawing.Size(96, 20);
            this.OrdenIdTxt.TabIndex = 1;
            this.OrdenIdTxt.TextChanged += new System.EventHandler(this.OrdenIdTxt_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "OrdenId";
            // 
            // cantidadTxt
            // 
            this.cantidadTxt.Location = new System.Drawing.Point(101, 104);
            this.cantidadTxt.Name = "cantidadTxt";
            this.cantidadTxt.Size = new System.Drawing.Size(96, 20);
            this.cantidadTxt.TabIndex = 4;
            this.cantidadTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad:";
            // 
            // DetalleIdTxt
            // 
            this.DetalleIdTxt.Enabled = false;
            this.DetalleIdTxt.Location = new System.Drawing.Point(101, 52);
            this.DetalleIdTxt.Name = "DetalleIdTxt";
            this.DetalleIdTxt.Size = new System.Drawing.Size(96, 20);
            this.DetalleIdTxt.TabIndex = 2;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(50, 205);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 5;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(168, 205);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 15;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // DetalleOrdenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.DetalleIdTxt);
            this.Controls.Add(this.cantidadTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrdenIdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductoCbo);
            this.Controls.Add(this.producto_id);
            this.Controls.Add(this.detalle_idCbo);
            this.Name = "DetalleOrdenFrm";
            this.Text = "DetalleOrdencs";
            this.Load += new System.EventHandler(this.DetalleOrdencs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductoCbo;
        private System.Windows.Forms.Label producto_id;
        private System.Windows.Forms.Label detalle_idCbo;
        private System.Windows.Forms.TextBox OrdenIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidadTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DetalleIdTxt;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button cancelar;
    }
}