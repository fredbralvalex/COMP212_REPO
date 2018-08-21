using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frederico_Alexandre_Lab06_Ex01
{
    public partial class Form1 : Form
    {
        Controller controller;
        int[] arrayInt;
        Double[] arrayDouble;

        public Form1()
        {
            InitializeComponent();
            controller = Controller.GetInstance();
        }

        private void GenerateIntBtn_Click(object sender, EventArgs e)
        {
            arrayInt = controller.GenerateIntArrayList(10);
            arrayDouble = null;
            ArrayListElements.Text = controller.PrintOutArray(arrayInt);
            this.ActiveControl = ResultTextBox;
        }

        private void GenerateDoubleBtn_Click(object sender, EventArgs e)
        {
            arrayDouble = controller.GenerateDoubleArrayList(10);
            arrayInt = null;
            ArrayListElements.Text = controller.PrintOutArray(arrayDouble);
            this.ActiveControl = ResultTextBox;
        }

        private void FindNumberBtn_Click(object sender, EventArgs e)
        {
            //checking which list has to be used to perform search
            int index;
            try {

                if (arrayInt == null)
                {
                    double value = Convert.ToDouble(FindNumberTextBox.Text);
                    index = controller.SearchElement(arrayDouble, value);
                } else
                {
                    int value = Convert.ToInt32(FindNumberTextBox.Text);
                    index = controller.SearchElement(arrayInt, value);
                }
            } catch (FormatException Exception)
            {
                Console.WriteLine(Exception.Message);
                index = -1;
            }

            if (index > -1)
            {
                ResultTextBox.Text = "Element found at position: " + index;
                ResultTextBox.ForeColor = Color.Green;
            } else
            {
                ResultTextBox.Text = "Element not found!";
                ResultTextBox.ForeColor = Color.Red;
            }
            this.ActiveControl = ResultTextBox;
        }
    }    
}
