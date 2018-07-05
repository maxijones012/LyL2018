namespace WinNegocio.Formularios
{
    partial class DetalleOrdenAMFrm
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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.ProductoCbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrdenIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetalleId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(276, 220);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(63, 22);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(199, 219);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(59, 24);
            this.AceptarBtn.TabIndex = 5;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cantidad:";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(153, 152);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(105, 20);
            this.CantidadTxt.TabIndex = 4;
            this.CantidadTxt.Text = "0";
            // 
            // ProductoCbo
            // 
            this.ProductoCbo.DisplayMember = "Descripcion";
            this.ProductoCbo.FormattingEnabled = true;
            this.ProductoCbo.Location = new System.Drawing.Point(149, 122);
            this.ProductoCbo.Name = "ProductoCbo";
            this.ProductoCbo.Size = new System.Drawing.Size(110, 21);
            this.ProductoCbo.TabIndex = 3;
            this.ProductoCbo.ValueMember = "ProductoId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Producto:";
            // 
            // OrdenIdTxt
            // 
            this.OrdenIdTxt.Enabled = false;
            this.OrdenIdTxt.Location = new System.Drawing.Point(149, 20);
            this.OrdenIdTxt.Name = "OrdenIdTxt";
            this.OrdenIdTxt.Size = new System.Drawing.Size(96, 20);
            this.OrdenIdTxt.TabIndex = 1;
           // this.OrdenIdTxt.TextChanged += new System.EventHandler(this.OrdenIdTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "OrdenId";
            // 
            // DetalleId
            // 
            this.DetalleId.Enabled = false;
            this.DetalleId.Location = new System.Drawing.Point(149, 73);
            this.DetalleId.Name = "DetalleId";
            this.DetalleId.Size = new System.Drawing.Size(96, 20);
            this.DetalleId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Renglon";
            // 
            // DetalleOrdenAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 262);
            this.Controls.Add(this.DetalleId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.ProductoCbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrdenIdTxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalleOrdenAMFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleOrdenAMFrm";
            this.Load += new System.EventHandler(this.DetalleOrdenAMFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.ComboBox ProductoCbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrdenIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DetalleId;
        private System.Windows.Forms.Label label3;
    }
}