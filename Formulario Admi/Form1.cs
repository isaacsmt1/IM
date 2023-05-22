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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmCentro Centro = new FmCentro();
            Centro.ShowDialog();
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesor Profesores = new Profesor();
            Profesores.ShowDialog();
        }

        private void regarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante Alumno = new Estudiante();
            Alumno.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Personal Trabajador = new Personal();
            Trabajador.ShowDialog();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentrro listaC = new ListaCentrro();
            listaC.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesorcs list = new ListaProfesorcs();
            list.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEstu listaEstu = new ListaEstu();
            listaEstu.ShowDialog();
        }

        private void listaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPersonal listaPersonal = new ListaPersonal();
            listaPersonal.ShowDialog();
        }
    }
}
