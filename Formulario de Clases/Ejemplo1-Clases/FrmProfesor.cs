using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejemplo1_Clases
{
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        { 
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            DatosProfesor(profesor);
        }
        private void DatosProfesor(Profesor profesor)
        {
            
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxDir.Text) ||
                string.IsNullOrEmpty(textBoxTel.Text) || string.IsNullOrEmpty(textBoxEmai.Text) || string.IsNullOrEmpty(textBoxInss.Text) ||
                double.IsNaN(double.Parse(textBoxSal.Text)))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                profesor.Id = textBoxId.Text;
                profesor.Nombre = textBoxName.Text;
                profesor.Direccion = textBoxDir.Text;
                profesor.Telf = textBoxTel.Text;
                profesor.Email = textBoxEmai.Text;
                profesor.INSS = textBoxInss.Text;
                profesor.Salario = double.Parse(textBoxSal.Text);
                Datos.Profesores.Add(profesor);
                MessageBox.Show("Datos Agregados", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

       
    

