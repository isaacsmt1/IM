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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            var Profesors = new Profesor(textNombre.Text, textDir.Text, textTelf.Text, textEmail.Text);
            Class_dato.Personanles.Add(Profesors);
            Close();

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DatosP_Enter(object sender, EventArgs e)
        {

        }

        private void Salario_Click(object sender, EventArgs e)
        {

        }
    }
}
