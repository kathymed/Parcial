using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        bool secuencia = true;
        double primero, segundo, resultado;
        string operacion;
                
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "7";
            }
            else
            {
                Pantalla.MaxLength = 12;  
            }
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
            else
            {
                Pantalla.MaxLength = 12;
            }
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "9";
            }
            else
            {
                Pantalla.MaxLength = 12;
            }
        }
        // SUMA
        private void btnSignoSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
           
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
            else
            {
                Pantalla.MaxLength = 12;
            }
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
            else
            {
                Pantalla.MaxLength = 12;
            }
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
            else
            {
                Pantalla.MaxLength = 12;
            }
        }

        //MENOS
        private void btnSignoMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "1";
            }
            else
            {
                Pantalla.MaxLength = 12;
            }
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "2";
            }
            else
            {
                Pantalla.MaxLength = 12;
            }
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 12)
            {
                Pantalla.Text = Pantalla.Text + "3";
            }
            else
            {
                Pantalla.MaxLength = 12;
            }
        }

        private void btnSignoPor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            }
        }

        private void btnSignoPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btnSignoDividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnNumero3_Click_1(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);
            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
             }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
