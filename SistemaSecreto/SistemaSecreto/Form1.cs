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
            this.Close();//cierra el formulario
        }

        private void Botiniciar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "juancho" && txtpassword.Text == "123tamarindo")
            {
                MessageBox.Show("Bienvenido Sr. Don Juancho");
                this.Hide(); //Escondemos ventana
                Ventana2 cursosventana = new Ventana2();
                cursosventana.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no valido");
                txtuser.Text = "";
                txtpassword.Text= "";
                txtuser.Focus();
            }
        }

        private void Txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar ==(int)Keys.Enter)
            {
                if (txtuser.Text == "juancho" && txtpassword.Text == "123tamarindo")
                {
                    MessageBox.Show("Bienvenido Sr. Don Juancho");
                    this.Hide(); //Escondemos ventana
                    Ventana2 cursosventana = new Ventana2();
                    cursosventana.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña no valido");
                    txtuser.Text = "";
                    txtpassword.Text = "";
                    txtuser.Focus();
                }
            }
        }
    }
}
