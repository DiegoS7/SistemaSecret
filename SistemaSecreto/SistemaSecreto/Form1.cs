using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSecreto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Butsalir_Click(object sender, EventArgs e)
        {
            this.Close();//cierra el formulariosdfs
        }

        private void Botiniciar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "juancho" && txtpassword.Text == "123tamarindo")
            {
                MessageBox.Show("Bienvenido Sr. Don Juancho");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no valido");
                txtuser.Text = "";
                txtpassword.Text= "";
                txtuser.Focus();
            }
        }
    }
}
