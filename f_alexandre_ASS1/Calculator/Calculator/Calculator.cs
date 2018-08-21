using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //Controller to make the operations, keeping the GUI away from the core        
        CalculatorController controller = new CalculatorController();        
        public Calculator()
        {
            InitializeComponent();
            visor.Text = controller.Ce();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("3");
        }       
        private void btn4_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("6");
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("9");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDigit("0");
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            visor.Text = controller.AppendDot();
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Sqrt();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Add();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Back();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Mul();
        }
        private void btnminus_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Sub();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Log();
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Eq();
        }

        private void btnslash_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Div();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Eks();
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            visor.Text = controller.Ce();
        }
    }
}
