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
    public partial class ListaCentro : Form
    {
        public ListaCentro()
        {
            InitializeComponent();
        }

        private void ListaCentro_Load(object sender, EventArgs e)
        {
            dataGridViewListCent.DataSource = Datos.Centros;   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
