using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Admi
{
    public partial class ListaEstu : Form
    {
        public ListaEstu()
        {
            InitializeComponent();
        }

        private void ListaEs_Enter(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Class_dato.Alumnos;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";

            dataGridView1.Columns.Add("Direccion", "Dirección");
            dataGridView1.Columns["Direccion"].DataPropertyName = "Direccion";

            dataGridView1.Columns.Add("Telf", "Teléfono");
            dataGridView1.Columns["Telf"].DataPropertyName = "Telf";

            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns["Email"].DataPropertyName = "Email";
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
