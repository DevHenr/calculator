using EtecAE.Calculadora.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacao = "";
        int v1, v2;
        public Form1()
        {
            InitializeComponent();


            
            
        }

        /* Queria mudar o ToInt32 para ToInt64, pra que pudesse ter cálculos maiores,
        mas para servir como exemplo já é o suficiente */

        private void BtnResult_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(textBox1.Text) || operacao == "")
            {
                BtnResult.Enabled = true;
            }
            else
            {
                v2 = Convert.ToInt32(textBox1.Text);

                if (operacao == "+")
                {
                    var calculo = new Calculador();
                    textBox1.Text = Convert.ToString(calculo.Somar(v1, v2));

                }
                else if (operacao == "-")
                {
                    var calculo = new Calculador();
                    textBox1.Text = Convert.ToString(calculo.Subtrair(v1, v2));

                }
                else if (operacao == "*")
                {
                    var calculo = new Calculador();
                    textBox1.Text = Convert.ToString(calculo.Multiplicar(v1, v2));

                }
                else
                {

                    var calculo = new Calculador();
                    textBox1.Text = Convert.ToString(calculo.Dividir(v1, v2));

                }


                conta.Text = v1 + " " + operacao + " " + v2;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
              if (string.IsNullOrWhiteSpace(textBox1.Text))
              {
                 btnSomar.Enabled = false;

                MessageBox.Show("Por favor insira um valor!");

                btnSomar.Enabled = true;

              }
              else 
              {
                  

                  v1 = Convert.ToInt32(textBox1.Text);
                  operacao = "+";
                  textBox1.Clear();

                  conta.Text = v1 + " " + operacao;
              }
      
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                btnSubtrair.Enabled = false;

                MessageBox.Show("Por favor insira um valor!");

                btnSubtrair.Enabled = true;

            }
            else
            {

                v1 = Convert.ToInt32(textBox1.Text);
                operacao = "-";
                textBox1.Clear();

                conta.Text = v1 + " " + operacao;

            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                btnMultiplicar.Enabled = false;

                MessageBox.Show("Por favor insira um valor!");

                btnMultiplicar.Enabled = true;

            }
            else
            {


                v1 = Convert.ToInt32(textBox1.Text);
                operacao = "*";
                textBox1.Clear();

                conta.Text = v1 + " " + operacao;
            }
        }



        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                btnDividir.Enabled = false;

                MessageBox.Show("Por favor insira um valor!");

                btnDividir.Enabled = true;

            }
            else
            {

                v1 = Convert.ToInt32(textBox1.Text);
                operacao = "/";
                textBox1.Clear();

                conta.Text = v1 + " " + operacao;
            }

        }



        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            operacao = "";
            conta.Text = "";
            textBox1.Text = "";
            v1 = 0;
            v2 = 0;

        }


    }
}
