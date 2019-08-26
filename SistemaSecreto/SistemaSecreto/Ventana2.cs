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
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)//botcerrar
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)//botcomprar
        {
            int conteo = 0;
            string seleccion;
            
            if(cbc.Checked == true)
            {
                conteo++;
            }
            if (cbb.Checked == true)
            {
                conteo++;
            }
            if(tarjet.Checked == true)
            {
                seleccion = "Tarjeta de Credito";
            }
            else
            {
                seleccion = "PayPal";
            }
            MessageBox.Show("Has Seleccionado" + conteo + " Cursos y tu método de pago es " + seleccion);
        }
    }
}
