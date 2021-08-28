using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] users = { "lvaldivia", "fmurillo", "fernando01" };

            string usuario = "lvaldivia";
            string pass = "123456";
            if (txtUsuario.Text.Equals(usuario) && txtPassword.Text.Equals(pass))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            } else {
                MessageBox.Show("Credenciales incorrectas","Validación");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
