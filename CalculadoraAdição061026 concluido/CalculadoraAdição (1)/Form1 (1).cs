using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraAdição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Soma_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(Txt1.Text); //Double convetendo para numeros em casas decimais
            double valor2 = Convert.ToDouble(Txt2.Text); //Double convetendo para numeros em casas decimais
            double resultado = valor1 + valor2;  //Convetetndo resultados(Números quebrados)
            MessageBox.Show(resultado.ToString()); // Metodo Tostring convete o valor do número em letras e textos

        }

        private void Btn_Subtração_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(Txt1.Text); 
            int valor2 = Convert.ToInt32(Txt2.Text); 
            int resultado = valor1 - valor2;
            MessageBox.Show(resultado.ToString());


        }

        private void Btn_Divisão_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(Txt1.Text);
            int valor2 = Convert.ToInt32(Txt2.Text);
            int resultado = valor1 /valor2;
            MessageBox.Show(resultado.ToString());
        }

        private void Btn_Multiplicação_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(Txt1.Text); // int convetendo pra numeros inteiros
            int valor2 = Convert.ToInt32(Txt2.Text); //
            int resultado = valor1 * valor2;
            MessageBox.Show(resultado.ToString());

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt1.Clear(); // apaga os valores de numero 1
            Txt2.Clear(); //apaga os valores de numero 2

        }
    }
}
