using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace Ej2
{
    public partial class Form1 : Form
    {
        private double val1;
        private double val2;

        private double resultado;
        private int operacion;
        private double dem;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //limpiar
            tbDisplay.Text = "";
        }
        //numeros
        private void btn1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "0";
        }
        //operaciones
        private void btnigual_Click(object sender, EventArgs e)
        {
            //igual
            val2 = Convert.ToDouble(tbDisplay.Text);
            switch (operacion) 
            {
                case 1:
                    resultado = val1 + val2;
                    break;
                case 2:
                    resultado = val1 - val2;
                    break ;
                case 3:
                    resultado = val1 * val2;
                    break;
                case 4:
                    resultado = val1 / val2;
                    
                    break;
            }
            resultado = Math.Round(resultado, 2);
            tbDisplay.Text = Convert.ToString(resultado);
        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            //suma
            operacion = 1;
            val1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
                
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            //resta
            operacion = 2;
            val1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            //multiplicacion
            operacion = 3;
            val1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            //division
            operacion = 4;
            val1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            //punto
            tbDisplay.Text = tbDisplay.Text + ",";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}