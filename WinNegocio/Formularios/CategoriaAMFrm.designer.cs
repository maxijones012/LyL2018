namespace WinNegocio.Formularios
{
    partial class CategoriaAMFrm
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
            this.IdMsk = new System.Windows.Forms.MaskedTextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(171, 138);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(83, 31);
            this.CancelarBtn.TabIndex = 19;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(30, 138);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(83, 31);
            this.AceptarBtn.TabIndex = 18;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(111, 31);
            this.IdMsk.Mask = "999999999";
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(143, 20);
            this.IdMsk.TabIndex = 22;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(111, 69);
            this.NombreTxt.MaxLength = 50;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(143, 20);
            this.NombreTxt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Identif. Categoria:";
            // 
            // CategoriaAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 196);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Name = "CategoriaAMFrm";
            this.Text = "CategoriaAMFrm";
            this.Load += new System.EventHandler(this.CategoriaAMFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}