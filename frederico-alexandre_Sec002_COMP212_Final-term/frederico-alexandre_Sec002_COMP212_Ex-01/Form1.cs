using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frederico_alexandre_Sec002_COMP212_Ex_01
{
    public partial class Form1 : Form
    {
        ProductController controller = ProductController.GetInstance();
        ValuesController VController = ValuesController.GetInstance();

        public Form1()
        {
            InitializeComponent();

            //Generate default products
            controller.GenerateProducts();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            OutputTb.Text = controller.PrintProducts();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long Id = 0;
                double price = 0;
                try
                {
                    Id = Convert.ToInt64(IDTb.Text);
                }
                catch (FormatException f)
                {
                    throw new ArgumentException("Please, provide a valid ID for product!");
                }

                try
                {                    
                    price = Convert.ToDouble(PriceTb.Text);
                }
                catch (FormatException f)
                {
                    throw new ArgumentException("Please, provide a valid Price for product!");
                }


                string name = NameTb.Text;
                if (name == null || name =="")
                {
                    throw new ArgumentException("Please, provide a valid Name for product!");
                }
                string company = CompanyTb.Text;
                if (company == null || company == "")
                {
                    throw new ArgumentException("Please, provide a valid Company Name for product!");
                }
                controller.AddProduct(Id, name, price, company);

                OutputTb.Text = controller.PrintProducts();
            }
            catch(FormatException f)
            {
                MessageBox.Show(this, "Please, provide valid arguments!", "Product Info-Sorted Dictionary");
            } catch (ArgumentException a)
            {
                MessageBox.Show(this, a.Message, "Product Info-Sorted Dictionary");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            
            //Tryin to remove by ID
            if (IDTb.Text != null && IDTb.Text != "")
            {
                try
                {
                    long Id = 0;
                    Id = Convert.ToInt64(IDTb.Text);
                    controller.RemoveProduct(Id);
                    OutputTb.Text = controller.PrintProducts();
                    return;
                }
                catch (FormatException f)
                {
                    MessageBox.Show(this, "Please, provide valid ID for product!", "Product Info-Sorted Dictionary");
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show(this, a.Message, "Product Info-Sorted Dictionary");
                }
            } else if (NameTb.Text != null && NameTb.Text != "")
            {
                try
                {
                    string name = NameTb.Text;
                    controller.RemoveProduct(name);
                    OutputTb.Text = controller.PrintProducts();
                    return;
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show(this, a.Message, "Product Info-Sorted Dictionary");
                }

            } else
            {
                MessageBox.Show(this, "Please Provide information to Remove!", "Product Info-Sorted Dictionary");
            }


        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (IDTb.Text != null && IDTb.Text != "")
            {
                try
                {
                    long Id = 0;
                    Id = Convert.ToInt64(IDTb.Text);
                    Product p = controller.SearchProduct(Id);
                    if (p == null)
                    {
                        throw new ArgumentException("Product Does not exists!");
                    }
                    OutputTb.Text = p.ToString();
                    return;
                }
                catch (FormatException f)
                {
                    MessageBox.Show(this, "Please, provide valid ID for product!", "Product Info-Sorted Dictionary");
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show(this, a.Message, "Product Info-Sorted Dictionary");
                }
            }
            else if (NameTb.Text != null && NameTb.Text != "")
            {
                try
                {
                    Product p = controller.SearchProduct(NameTb.Text);
                    if (p == null)
                    {
                        throw new ArgumentException("Product Does not exists!");
                    }
                    OutputTb.Text = p.ToString();
                    return;
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show(this, a.Message, "Product Info-Sorted Dictionary");
                }

            }
            else
            {
                MessageBox.Show(this, "Please Provide information to Remove!", "Product Info-Sorted Dictionary");
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            VController.GenerateList(5);
            LinkListValLb.DataSource = VController.ListOfIntegers.ToList();
        }

        private void AddFrontBtn_Click(object sender, EventArgs e)
        {
            if (VController.ListOfIntegers.Count <= 0)
            {
                VController.GenerateList(5);
            }
            VController.AddAtFront();
            LinkListValLb.DataSource = VController.ListOfIntegers.ToList();
        }

        private void RemoveFrontBtn_Click(object sender, EventArgs e)
        {
            try
            {
                VController.RemoveFromFront();
                LinkListValLb.DataSource = VController.ListOfIntegers.ToList();
            } catch (ArgumentException a)
            {
                MessageBox.Show(this, a.Message, "LinkedList of Values");
            }
        }

        private void LargestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int number = VController.LargestInteger();
                OutputTb.Text = "The largest number in the list is: " + number;

            }catch (ArgumentException a)
            {
                MessageBox.Show(this, a.Message, "LinkedList of Values");
            }
        }
    }
}
