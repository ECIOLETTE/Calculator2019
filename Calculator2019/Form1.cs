using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2019
{
    public partial class Form1 : Form
    { 
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
            
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void BtnN1_Click(object sender, EventArgs e)
        {
        
        }

        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            equation.Text = ""; 
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            if ((result.Text == "00") || (operation_pressed))
                result.Clear();

            operation_pressed = false;

            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }else
                result.Text = result.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
            value = 0;
        }

        private void Equation_Click(object sender, EventArgs e)
        {

        }

        private void BtnKmMi_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(result.Text);
            double resultado = 0;

            resultado = (valor * 0.6213);
            equation.Text = (resultado + " Mi").ToString();

        }

        private void BtnMiKm_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(result.Text);
            double resultado = 0;

            resultado = (valor * 1.6093);
            equation.Text = (resultado + " Mi").ToString();
        }

        private void BtnKgLb_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(result.Text);
            double resultado = 0;

            resultado = (valor * 2.2046);
            equation.Text = (resultado + " Lb").ToString();
        }

        private void BtnLbKg_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(result.Text);
            double resultado = 0;

            resultado = (valor * 0.4535);
            equation.Text = (resultado + " Kg").ToString();
        }
    }
}
