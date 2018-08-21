using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frederico_Alexandre_Lab07_Sec_002
{
    public partial class Form1 : Form
    {

        private Controller controller;
        public Form1()
        {
            controller = Controller.GetInstance();
            InitializeComponent();
        }

        /* Event handler to generate numbers*/
        private void GenerateValuesBTN_Click(object sender, EventArgs e)
        {
            if (IntegersRB.Checked)
            {
                ListItemsLB.DataSource = controller.GenerateIntList(10);
            } else if (DoublesRB.Checked)
            {
                ListItemsLB.DataSource = controller.GenerateDoubleList(10);

            } else if (CharsRB.Checked)
            {
                ListItemsLB.DataSource = controller.GenerateCharList(10);
            } else
            {
                MessageBox.Show(this, "Please, choose the type of the list!", "Display List of Values and Search");
            }
        }

        /*Event handler for Searching the value*/
        private void SearchBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //trying to convert to the desired type - case is not possible throw a exception
                bool found = false;
                if (IntegersRB.Checked)
                {
                    int element = Convert.ToInt32(InputValuesSearchTB.Text);
                    found = controller.SearchData((List<int>)ListItemsLB.DataSource, element);
                }
                else if (DoublesRB.Checked)
                {
                    double element = Convert.ToDouble(InputValuesSearchTB.Text);
                    found = controller.SearchData((List<Double>)ListItemsLB.DataSource, element);

                }
                else if (CharsRB.Checked)
                {
                    char element = Convert.ToChar(InputValuesSearchTB.Text);
                    found = controller.SearchData((List<char>)ListItemsLB.DataSource, element);
                }
                else
                {
                    MessageBox.Show(this, "Please, choose the type of the list!", "Display List of Values and Search");
                }

                if (found)
                {
                    MessageBox.Show(this, "Element found!", "Display List of Values and Search");
                } else
                {
                    MessageBox.Show(this, "Element not found!", "Display List of Values and Search");
                }
            } catch(FormatException)
            {
                MessageBox.Show(this, "Please, provide a valid " + (IntegersRB.Checked?"Integer ": DoublesRB.Checked?"Double ": CharsRB.Checked?"Char ":"") + "parameter!", "Display List of Values and Search");
            }
        }

        /*Event handler for Displaying values between indeces*/
        private void DisplayBTN_Click(object sender, EventArgs e)
        {

            try
            {
                if (ListItemsLB.DataSource == null)
                {
                    throw new ArgumentException("Please, generate values for the list!");
                }

                int lowIndex = -1;
                int highIndex = -1;
                try
                {
                    lowIndex = Convert.ToInt32(InputLowIndexTB.Text);
                }
                catch (FormatException)
                {
                    throw new ArgumentException("Please, provide a valid Low Index!");
                }

                try
                {
                    highIndex = Convert.ToInt32(InputHighIndexTB.Text);
                }
                catch (FormatException)
                {
                    throw new ArgumentException("Please, provide a valid High Index!");
                }

                //Get the result list and convert to a string to be shown in the text
                string listElement = "";
                if (IntegersRB.Checked)
                {
                    listElement = controller.PrintData(controller.PrintData((List<int>)ListItemsLB.DataSource, lowIndex, highIndex));
                }
                else if (DoublesRB.Checked)
                {
                    listElement = controller.PrintData(controller.PrintData((List<Double>)ListItemsLB.DataSource, lowIndex, highIndex));

                }
                else if (CharsRB.Checked)
                {
                    listElement = controller.PrintData(controller.PrintData((List<char>)ListItemsLB.DataSource, lowIndex, highIndex));
                }
                else
                {
                    MessageBox.Show(this, "Please, choose the type of the list!", "Display List of Values and Search");
                }

                OutputValuesLowHigh.Text = listElement;
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(this, a.Message, "Display List of Values and Search");
            }
        }

        /*Event handler for check if is even or odd*/
        private void CheckEvenOddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int numberToCheck = Convert.ToInt32(InputCheckOddEvenTB.Text);
                if (numberToCheck < 0)
                {
                    throw new FormatException();
                }
                bool isOdd = controller.IsOdd(numberToCheck);
                MessageBox.Show(this, "The number provided is " + (isOdd?"Odd":"Even"+"!"), "Check for Even\\Odd");
            }
            catch (FormatException a)
            {
                MessageBox.Show(this, "Please, provide a valid integer!", "Check for Even\\Odd");
            }
        }

        /*Event handler for calculate the factorial*/
        private async void CalculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //uses a check box to make the funtion wait for the desired time in order to teste another function
                int time = 0;
                if (UseWaitCB.Checked)
                {
                    try
                    {
                        time = Convert.ToInt32(timeTB.Text);
                    }
                    catch (FormatException a)
                    {
                        throw new ArgumentException("Please, provide a valid ms time!");
                    }
                }

                ulong number = Convert.ToUInt64(FatorialTB.Text);
                if (number <= 0)
                {
                    throw new FormatException();
                }
                
                //create an asynchronous task
                Task<ulong> task = Task.Run(() => controller.Factorial(number));
                //wait for the task to finish
                await task;
                //using the delay - if not informed use 0 ms
                await Task.Delay(time);

                ulong factorial = task.Result;

                MessageBox.Show(this, "The factorial of " + number + " is " + factorial + "!", "Calculate Asynchronously");
            }
            catch (FormatException a)
            {
                MessageBox.Show(this, "Please, provide a valid long!", "Calculate Asynchronously");
            } catch (ArgumentException ae)
            {
                MessageBox.Show(this, ae.Message, "Calculate Asynchronously");
            }
        }

    }
}
