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
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void btnGuardarAlu_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxDir.Text) ||
                string.IsNullOrEmpty(textBoxTel.Text) || string.IsNullOrEmpty(textBoxEmai.Text) || string.IsNullOrEmpty(textBoxExp.Text) ||
                string.IsNullOrEmpty(textBoxTil.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                alumno.Id = textBoxId.Text;
                alumno.Nombre = textBoxName.Text;
                alumno.Direccion = textBoxDir.Text;
                alumno.Telf = textBoxTel.Text;
                alumno.Email = textBoxEmai.Text;
                alumno.Exp = textBoxExp.Text;
                alumno.Tiulacion = textBoxTil.Text;
                Datos.Alumnos.Add(alumno);
                MessageBox.Show("Datos Agregados", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnCancelAlu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
