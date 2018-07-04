namespace WinNegocio.Formularios
{
    partial class EmpleadoAMFrm
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
            this.IdMsk = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.fechaEmpleadoDte = new System.Windows.Forms.DateTimePicker();
            this.FechaNacTxt = new System.Windows.Forms.Label();
            this.reporta_aTxt = new System.Windows.Forms.Label();
            this.Reporta_aCbo = new System.Windows.Forms.ComboBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(91, 36);
            this.IdMsk.Mask = "999999999";
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(106, 20);
            this.IdMsk.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(91, 69);
            this.NombreTxt.MaxLength = 30;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(143, 20);
            this.NombreTxt.TabIndex = 7;
            this.NombreTxt.TextChanged += new System.EventHandler(this.NombreCiaTxt_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(22, 69);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre:";
            this.Nombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(91, 105);
            this.apellidoTxt.MaxLength = 30;
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(143, 20);
            this.apellidoTxt.TabIndex = 9;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(22, 105);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 8;
            this.Apellido.Text = "Apellido";
            // 
            // fechaEmpleadoDte
            // 
            this.fechaEmpleadoDte.Location = new System.Drawing.Point(91, 144);
            this.fechaEmpleadoDte.Name = "fechaEmpleadoDte";
            this.fechaEmpleadoDte.Size = new System.Drawing.Size(200, 20);
            this.fechaEmpleadoDte.TabIndex = 10;
            this.fechaEmpleadoDte.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FechaNacTxt
            // 
            this.FechaNacTxt.AutoSize = true;
            this.FechaNacTxt.Location = new System.Drawing.Point(19, 144);
            this.FechaNacTxt.Name = "FechaNacTxt";
            this.FechaNacTxt.Size = new System.Drawing.Size(66, 13);
            this.FechaNacTxt.TabIndex = 11;
            this.FechaNacTxt.Text = "Fecha Nac.:";
            this.FechaNacTxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // reporta_aTxt
            // 
            this.reporta_aTxt.AutoSize = true;
            this.reporta_aTxt.Location = new System.Drawing.Point(22, 181);
            this.reporta_aTxt.Name = "reporta_aTxt";
            this.reporta_aTxt.Size = new System.Drawing.Size(57, 13);
            this.reporta_aTxt.TabIndex = 12;
            this.reporta_aTxt.Text = "Reporta a:";
            // 
            // Reporta_aCbo
            // 
            this.Reporta_aCbo.DisplayMember = "ApellidoNombre";
            this.Reporta_aCbo.FormattingEnabled = true;
            this.Reporta_aCbo.Location = new System.Drawing.Point(91, 178);
            this.Reporta_aCbo.Name = "Reporta_aCbo";
            this.Reporta_aCbo.Size = new System.Drawing.Size(121, 21);
            this.Reporta_aCbo.TabIndex = 13;
            this.Reporta_aCbo.ValueMember = "EmpleadoId";
            this.Reporta_aCbo.SelectedIndexChanged += new System.EventHandler(this.EmpleadoIdTxt_SelectedIndexChanged);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(154, 271);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 14;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click_1);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(300, 270);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 15;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // EmpleadoAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 331);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.Reporta_aCbo);
            this.Controls.Add(this.reporta_aTxt);
            this.Controls.Add(this.FechaNacTxt);
            this.Controls.Add(this.fechaEmpleadoDte);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.label1);
            this.Name = "EmpleadoAMFrm";
            this.Text = "EmpleadoAMFrm";
            this.Load += new System.EventHandler(this.EmpleadoAMFrm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.DateTimePicker fechaEmpleadoDte;
        private System.Windows.Forms.Label FechaNacTxt;
        private System.Windows.Forms.Label reporta_aTxt;
        private System.Windows.Forms.ComboBox Reporta_aCbo;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button cancelar;
    }
}