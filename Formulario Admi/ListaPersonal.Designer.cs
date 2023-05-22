namespace Formulario_Admi
{
    partial class ListaPersonal
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
            this.ListaTa = new System.Windows.Forms.GroupBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListaTa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaTa
            // 
            this.ListaTa.Controls.Add(this.Cancelar);
            this.ListaTa.Controls.Add(this.dataGridView1);
            this.ListaTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaTa.Location = new System.Drawing.Point(100, 23);
            this.ListaTa.Name = "ListaTa";
            this.ListaTa.Size = new System.Drawing.Size(600, 405);
            this.ListaTa.TabIndex = 1;
            this.ListaTa.TabStop = false;
            this.ListaTa.Text = "Lista de Trabajadores";
            this.ListaTa.Enter += new System.EventHandler(this.ListaTa_Enter);
            // 
            // Cancelar
            // 
            this.Cancelar.AllowDrop = true;
            this.Cancelar.Location = new System.Drawing.Point(466, 365);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(150, 50);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(601, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // ListaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaTa);
            this.Name = "ListaPersonal";
            this.Text = "ListaPersonal";
            this.ListaTa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ListaTa;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}