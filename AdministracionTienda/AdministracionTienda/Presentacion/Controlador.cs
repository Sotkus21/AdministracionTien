using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionTienda.Presentacion
{
    public partial class Controlador : Form
    {
        public Controlador()
        {
            InitializeComponent();
        }

        private void BTNexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
