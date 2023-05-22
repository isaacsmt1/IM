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
    public partial class FmCentro : Form
    {
        public FmCentro()
        {
            InitializeComponent();
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            var Centro = new FmCentro(textNombre.Text, textDir.Text, textTelf.Text, textEmail.Text);
            Class_dato.Centros.Add(Centro);
            Close();

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
