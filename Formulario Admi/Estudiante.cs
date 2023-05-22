using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Formulario_Admi
{
    public partial class Estudiante : Form
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        { 

           var Estu = new Estudiante(textNombre.Text, textDir.Text, textTelf.Text, textEmail.Text);
           Class_dato.Alumnos.Add(Estu);

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
