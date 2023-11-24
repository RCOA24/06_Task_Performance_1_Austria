using CalculatorPrivateAssembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _06_Task_Performance_1_Austria
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(TB1.Text);
            float num2 = float.Parse(TB2.Text);

            if (CB1.Text == "+") {
                TB3.Text = BasicComputation.Addition(num1, num2).ToString();
            }
          else if (CB1.Text == "-") {
                TB3.Text = BasicComputation.Substraction(num1, num2).ToString();
            }
          else if (CB1.Text == "*") {
                TB3.Text = BasicComputation.Multiplication(num1, num2).ToString();
            }
          else if (CB1.Text == "/") {
                TB3.Text = BasicComputation.Division(num1, num2).ToString();
            }

        }
    }
}
