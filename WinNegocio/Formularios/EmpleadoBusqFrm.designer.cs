namespace WinNegocio.Formularios
{
    partial class EmpleadoBusqFrm
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
            this.NombreEmpTxt = new System.Windows.Forms.TextBox();
            this.idEmpleadoTxt = new System.Windows.Forms.TextBox();
            this.ListarTodoCbo = new System.Windows.Forms.CheckBox();
            this.NombreCheckBox = new System.Windows.Forms.CheckBox();
            this.idEmpleadoCbo = new System.Windows.Forms.CheckBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreEmpTxt);
            this.groupBox1.Controls.Add(this.idEmpleadoTxt);
            this.groupBox1.Controls.Add(this.ListarTodoCbo);
            this.groupBox1.Controls.Add(this.NombreCheckBox);
            this.groupBox1.Controls.Add(this.idEmpleadoCbo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // NombreEmpTxt
            // 
            this.NombreEmpTxt.Enabled = false;
            this.NombreEmpTxt.Location = new System.Drawing.Point(122, 74);
            this.NombreEmpTxt.Name = "NombreEmpTxt";
            this.NombreEmpTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreEmpTxt.TabIndex = 4;
            this.NombreEmpTxt.TextChanged += new System.EventHandler(this.NombreEmpTxt_TextChanged);
            // 
            // idEmpleadoTxt
            // 
            this.idEmpleadoTxt.Location = new System.Drawing.Point(122, 36);
            this.idEmpleadoTxt.Name = "idEmpleadoTxt";
            this.idEmpleadoTxt.Size = new System.Drawing.Size(100, 20);
            this.idEmpleadoTxt.TabIndex = 3;
            // 
            // ListarTodoCbo
            // 
            this.ListarTodoCbo.AutoSize = true;
            this.ListarTodoCbo.Location = new System.Drawing.Point(19, 128);
            this.ListarTodoCbo.Name = "ListarTodoCbo";
            this.ListarTodoCbo.Size = new System.Drawing.Size(79, 17);
            this.ListarTodoCbo.TabIndex = 2;
            this.ListarTodoCbo.Text = "Listar Todo";
            this.ListarTodoCbo.UseVisualStyleBackColor = true;
            this.ListarTodoCbo.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // NombreCheckBox
            // 
            this.NombreCheckBox.AutoSize = true;
            this.NombreCheckBox.Location = new System.Drawing.Point(19, 74);
            this.NombreCheckBox.Name = "NombreCheckBox";
            this.NombreCheckBox.Size = new System.Drawing.Size(63, 17);
            this.NombreCheckBox.TabIndex = 1;
            this.NombreCheckBox.Text = "Nombre";
            this.NombreCheckBox.UseVisualStyleBackColor = true;
            this.NombreCheckBox.CheckedChanged += new System.EventHandler(this.NombreCbo_CheckedChanged);
            // 
            // idEmpleadoCbo
            // 
            this.idEmpleadoCbo.AutoSize = true;
            this.idEmpleadoCbo.Location = new System.Drawing.Point(19, 36);
            this.idEmpleadoCbo.Name = "idEmpleadoCbo";
            this.idEmpleadoCbo.Size = new System.Drawing.Size(85, 17);
            this.idEmpleadoCbo.TabIndex = 0;
            this.idEmpleadoCbo.Text = "Id Empleado";
            this.idEmpleadoCbo.UseVisualStyleBackColor = true;
            this.idEmpleadoCbo.CheckedChanged += new System.EventHandler(this.idEmpleadoCbo_CheckedChanged);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(31, 223);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 23);
            this.BuscarBtn.TabIndex = 1;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(159, 223);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 2;
            this.CancelarBtn.Text = "CancelarBtn";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // EmpleadoBusqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmpleadoBusqFrm";
            this.Text = "EmpleadoBusqFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ListarTodoCbo;
        private System.Windows.Forms.CheckBox NombreCheckBox;
        private System.Windows.Forms.CheckBox idEmpleadoCbo;
        private System.Windows.Forms.TextBox NombreEmpTxt;
        private System.Windows.Forms.TextBox idEmpleadoTxt;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CancelarBtn;

    }
}