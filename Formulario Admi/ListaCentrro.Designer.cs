namespace Formulario_Admi
{
    partial class ListaCentrro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cancelar = new System.Windows.Forms.Button();
            this.ListaCentro = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ListaCentro.SuspendLayout();
            this.SuspendLayout();
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
            // ListaCentro
            // 
            this.ListaCentro.Controls.Add(this.Cancelar);
            this.ListaCentro.Controls.Add(this.dataGridView1);
            this.ListaCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCentro.Location = new System.Drawing.Point(71, 33);
            this.ListaCentro.Name = "ListaCentro";
            this.ListaCentro.Size = new System.Drawing.Size(600, 405);
            this.ListaCentro.TabIndex = 0;
            this.ListaCentro.TabStop = false;
            this.ListaCentro.Text = "Lista de Centros";
            this.ListaCentro.Enter += new System.EventHandler(this.ListaCentro_Enter);
            // 
            // ListaCentrro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaCentro);
            this.Name = "ListaCentrro";
            this.Text = "ListaCentrro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ListaCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.GroupBox ListaCentro;
    }
}