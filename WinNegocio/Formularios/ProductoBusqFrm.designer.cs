namespace WinNegocio.Formularios
{
    partial class ProductoBusqFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdProductoTxt = new System.Windows.Forms.TextBox();
            this.NombreProdTxt = new System.Windows.Forms.TextBox();
            this.ListTodocheck = new System.Windows.Forms.CheckBox();
            this.NombreProdcheck = new System.Windows.Forms.CheckBox();
            this.IdProductocheck = new System.Windows.Forms.CheckBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdProductoTxt);
            this.groupBox1.Controls.Add(this.NombreProdTxt);
            this.groupBox1.Controls.Add(this.ListTodocheck);
            this.groupBox1.Controls.Add(this.NombreProdcheck);
            this.groupBox1.Controls.Add(this.IdProductocheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios:";
            // 
            // IdProductoTxt
            // 
            this.IdProductoTxt.Enabled = false;
            this.IdProductoTxt.Location = new System.Drawing.Point(153, 19);
            this.IdProductoTxt.Name = "IdProductoTxt";
            this.IdProductoTxt.Size = new System.Drawing.Size(100, 20);
            this.IdProductoTxt.TabIndex = 4;
            // 
            // NombreProdTxt
            // 
            this.NombreProdTxt.Enabled = false;
            this.NombreProdTxt.Location = new System.Drawing.Point(153, 61);
            this.NombreProdTxt.Name = "NombreProdTxt";
            this.NombreProdTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreProdTxt.TabIndex = 3;
            // 
            // ListTodocheck
            // 
            this.ListTodocheck.AutoSize = true;
            this.ListTodocheck.Location = new System.Drawing.Point(27, 97);
            this.ListTodocheck.Name = "ListTodocheck";
            this.ListTodocheck.Size = new System.Drawing.Size(79, 17);
            this.ListTodocheck.TabIndex = 2;
            this.ListTodocheck.Text = "Listar Todo";
            this.ListTodocheck.UseVisualStyleBackColor = true;
            // 
            // NombreProdcheck
            // 
            this.NombreProdcheck.AutoSize = true;
            this.NombreProdcheck.Location = new System.Drawing.Point(27, 61);
            this.NombreProdcheck.Name = "NombreProdcheck";
            this.NombreProdcheck.Size = new System.Drawing.Size(109, 17);
            this.NombreProdcheck.TabIndex = 1;
            this.NombreProdcheck.Text = "Nombre Producto";
            this.NombreProdcheck.UseVisualStyleBackColor = true;
            this.NombreProdcheck.CheckedChanged += new System.EventHandler(this.NombreProdcheck_CheckedChanged);
            // 
            // IdProductocheck
            // 
            this.IdProductocheck.AutoSize = true;
            this.IdProductocheck.Location = new System.Drawing.Point(27, 29);
            this.IdProductocheck.Name = "IdProductocheck";
            this.IdProductocheck.Size = new System.Drawing.Size(107, 17);
            this.IdProductocheck.TabIndex = 0;
            this.IdProductocheck.Text = "Identif. Producto:";
            this.IdProductocheck.UseVisualStyleBackColor = true;
            this.IdProductocheck.CheckedChanged += new System.EventHandler(this.IdProductocheck_CheckedChanged);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(56, 214);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 23);
            this.BuscarBtn.TabIndex = 1;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(275, 213);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 2;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ProductoBusqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductoBusqFrm";
            this.Text = "ProductoBusqFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.TextBox IdProductoTxt;
        private System.Windows.Forms.TextBox NombreProdTxt;
        private System.Windows.Forms.CheckBox ListTodocheck;
        private System.Windows.Forms.CheckBox NombreProdcheck;
        private System.Windows.Forms.CheckBox IdProductocheck;
    }
}