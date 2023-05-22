namespace Formulario_Admi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarC = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCentrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarC,
            this.listaDeCentrosToolStripMenuItem});
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.centroToolStripMenuItem.Text = "Centro";
            this.centroToolStripMenuItem.Click += new System.EventHandler(this.centroToolStripMenuItem_Click);
            // 
            // AgregarC
            // 
            this.AgregarC.Name = "AgregarC";
            this.AgregarC.Size = new System.Drawing.Size(224, 26);
            this.AgregarC.Text = "Agregar";
            this.AgregarC.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // listaDeCentrosToolStripMenuItem
            // 
            this.listaDeCentrosToolStripMenuItem.Name = "listaDeCentrosToolStripMenuItem";
            this.listaDeCentrosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeCentrosToolStripMenuItem.Text = "Lista de Centros";
            this.listaDeCentrosToolStripMenuItem.Click += new System.EventHandler(this.listaDeCentrosToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.listaDeProfesoresToolStripMenuItem});
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // listaDeProfesoresToolStripMenuItem
            // 
            this.listaDeProfesoresToolStripMenuItem.Name = "listaDeProfesoresToolStripMenuItem";
            this.listaDeProfesoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeProfesoresToolStripMenuItem.Text = "Lista de Profesores";
            this.listaDeProfesoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeProfesoresToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regarToolStripMenuItem,
            this.listaDeEstudiantesToolStripMenuItem});
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // regarToolStripMenuItem
            // 
            this.regarToolStripMenuItem.Name = "regarToolStripMenuItem";
            this.regarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.regarToolStripMenuItem.Text = "Agregar";
            this.regarToolStripMenuItem.Click += new System.EventHandler(this.regarToolStripMenuItem_Click);
            // 
            // listaDeEstudiantesToolStripMenuItem
            // 
            this.listaDeEstudiantesToolStripMenuItem.Name = "listaDeEstudiantesToolStripMenuItem";
            this.listaDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeEstudiantesToolStripMenuItem.Text = "Lista de Estudiantes";
            this.listaDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.listaDeEstudiantesToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.listaDePersonalToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // listaDePersonalToolStripMenuItem
            // 
            this.listaDePersonalToolStripMenuItem.Name = "listaDePersonalToolStripMenuItem";
            this.listaDePersonalToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listaDePersonalToolStripMenuItem.Text = "Lista de Trabajadores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregarC;
        private System.Windows.Forms.ToolStripMenuItem listaDeCentrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDePersonalToolStripMenuItem;
    }
}

