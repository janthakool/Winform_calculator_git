using System;
using System.Windows.Forms;

namespace Winform_calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        String triangle = "";
        String etc = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button19_Click(object sender, EventArgs e)
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
                case "x^y":
                    int value1 = 1;
                    int i = 0;

                    while (i < int.Parse(result.Text))
                    {
                        value1 *= (int)value;
                        i++;
                    }
                    result.Text = value1.ToString();
                    value1 = 1;
                    i = 0;
                    break;
                case "n!":
                    int j = 1;
                    int value2 = 1;
                    while (j <= (int)value)
                    {
                        value2 *= j;
                        j++;
                    }
                    result.Text = value2.ToString();
                    value2 = 1;
                    j = 1;
                    break;
                default:
                    break;
            }
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            
            result.Text = "0";
            operation = "";

        }
        
        private double DegreeToRadian(double angle)
        {
            result.Clear();
            return Math.PI * angle / 180.0;
        }
        private void triangle_Click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            triangle = c.Text;


            equation.Text = triangle;

            switch (triangle)
            {
                case "sin":
                    result.Text = (Math.Sin(DegreeToRadian(Double.Parse(result.Text)))).ToString();
                    break;
                case "cos":
                    result.Text = (Math.Cos(DegreeToRadian(Double.Parse(result.Text)))).ToString();
                    break;
                case "tan":
                    result.Text = (Math.Tan(DegreeToRadian(Double.Parse(result.Text)))).ToString();
                    break;

                case "cosec":
                    result.Text = ((1 / Math.Sin(DegreeToRadian(Double.Parse(result.Text))))).ToString();
                    break;
                case "sec":
                    result.Text = (1 / Math.Cos(DegreeToRadian(Double.Parse(result.Text)))).ToString();
                    break;
                case "cot":
                    result.Text = (1 / Math.Tan(DegreeToRadian(Double.Parse(result.Text)))).ToString();
                    break;
                default:
                    break;
            }
        }
        
        private void etc_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            etc = b.Text;
            equation.Text = etc;
            switch (etc)
            {
                case "π":
                    result.Text = (Double.Parse(result.Text) * Math.PI).ToString();
                    break;
                case "√":
                    result.Text = (Math.Sqrt(Double.Parse(result.Text))).ToString();
                    break;  
                default:
                    break;
            }
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }
    }
}
