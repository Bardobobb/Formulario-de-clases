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
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Centro cent = new Centro(textBoxNameCen.Text,textBoxDirCen.Text, textBoxTelCen.Text, textBoxEmaiCen.Text);
            Datos.Centros.Add(cent);
            MessageBox.Show("Se ha agreado un elemento");
            textBoxNameCen.Clear();
            textBoxDirCen.Clear();
            textBoxTelCen.Clear();
            textBoxEmaiCen.Clear();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
