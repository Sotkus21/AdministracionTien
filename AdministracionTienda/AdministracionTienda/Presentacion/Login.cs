using AdministracionTienda.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionTienda.Negocios;
using static AdministracionTienda.Negocios.Negocio;

namespace AdministracionTienda
{
    public partial class Login : Form
    {
        Controlador fp = new Controlador();
        private UserBusiness userBusiness;
        public Login()
        {
            InitializeComponent();
            userBusiness = new UserBusiness();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_user.Text;
            string password = tb_pass.Text;

            if (userBusiness.Login(username, password))
            {
                MessageBox.Show("Login exitoso");
                fp.Show();
                return;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            
            
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }



    }
}
