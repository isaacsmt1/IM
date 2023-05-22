namespace Formulario_Admi
{
    partial class Profesor
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
            this.DatosP = new System.Windows.Forms.GroupBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelf = new System.Windows.Forms.TextBox();
            this.textDir = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.DatosP.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosP
            // 
            this.DatosP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DatosP.Controls.Add(this.Cancelar);
            this.DatosP.Controls.Add(this.Guardar);
            this.DatosP.Controls.Add(this.textEmail);
            this.DatosP.Controls.Add(this.textTelf);
            this.DatosP.Controls.Add(this.textDir);
            this.DatosP.Controls.Add(this.textNombre);
            this.DatosP.Controls.Add(this.Email);
            this.DatosP.Controls.Add(this.Telefono);
            this.DatosP.Controls.Add(this.Direccion);
            this.DatosP.Controls.Add(this.Nombre);
            this.DatosP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosP.Location = new System.Drawing.Point(50, 31);
            this.DatosP.Name = "DatosP";
            this.DatosP.Size = new System.Drawing.Size(700, 389);
            this.DatosP.TabIndex = 1;
            this.DatosP.TabStop = false;
            this.DatosP.Text = "Datos del Profesor";
            this.DatosP.Enter += new System.EventHandler(this.DatosP_Enter);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(424, 339);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(150, 50);
            this.Cancelar.TabIndex = 9;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(206, 339);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(150, 50);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(270, 259);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(280, 34);
            this.textEmail.TabIndex = 7;
            // 
            // textTelf
            // 
            this.textTelf.Location = new System.Drawing.Point(270, 197);
            this.textTelf.Name = "textTelf";
            this.textTelf.Size = new System.Drawing.Size(280, 34);
            this.textTelf.TabIndex = 6;
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(270, 131);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(280, 34);
            this.textDir.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(270, 71);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(280, 34);
            this.textNombre.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(104, 265);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(64, 28);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(95, 203);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(94, 28);
            this.Telefono.TabIndex = 2;
            this.Telefono.Text = "Telefono";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(104, 137);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(102, 28);
            this.Direccion.TabIndex = 1;
            this.Direccion.Text = "Direccion";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(104, 74);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(89, 28);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatosP);
            this.Name = "Profesor";
            this.Text = "Profesor";
            this.DatosP.ResumeLayout(false);
            this.DatosP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosP;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTelf;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Nombre;
    }
}