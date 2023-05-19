using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuAgrega_Click(object sender, EventArgs e)
        {
            FrmCentro centro = new FrmCentro();
            centro.Show();

        }

        private void menuListCent_Click(object sender, EventArgs e)
        {
            ListaCentro listacen = new ListaCentro();
            listacen.Show();
        }

        private void agregarProfe_Click(object sender, EventArgs e)
        {
            FrmProfesor profesor = new FrmProfesor();
            profesor.Show();
        }

        private void listaDeProfesorTool_Click(object sender, EventArgs e)
        {
            ListaProfesores lisprof = new ListaProfesores();
            lisprof.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAlumnos frmAlumnos = new FrmAlumnos();
            frmAlumnos.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaAlumnos listaAlumnos = new ListaAlumnos();
            listaAlumnos.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonal frmPersonal = new FrmPersonal();
            frmPersonal.Show(); 
        }

        private void listaDePersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPersonal listaPersonal = new ListaPersonal();
            listaPersonal.Show();
        }
    }
}
