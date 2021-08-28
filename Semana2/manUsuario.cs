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
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string cumple = dtpBirth.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telef = txtTelefono.Text;
            string email = txtEmail.Text;
            string direc = txtAddress.Text;

            dgvUsuarios.Rows.Add(dni,cumple,nombre,apellido,telef,email,direc);

            txtDNI.Clear();
            dtpBirth.Text = DateTime.Now.ToShortDateString();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }
    }
}
