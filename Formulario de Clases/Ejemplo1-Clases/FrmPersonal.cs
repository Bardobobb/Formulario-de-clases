using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejemplo1_Clases
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void btnGuardarAlu_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxDir.Text) ||
                string.IsNullOrEmpty(textBoxTel.Text) || string.IsNullOrEmpty(textBoxEmai.Text) || string.IsNullOrEmpty(textBoxUni.Text) ||
                string.IsNullOrEmpty(textBoxCate.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                personal.Id = textBoxId.Text;
                personal.Nombre = textBoxName.Text;
                personal.Direccion = textBoxDir.Text;
                personal.Telf = textBoxTel.Text;
                personal.Email = textBoxEmai.Text;
                personal.Unidad = textBoxUni.Text;
                personal.Categoria = textBoxCate.Text;
                Datos.Personanles.Add(personal);
                MessageBox.Show("Datos Agregados", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancelAlu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
