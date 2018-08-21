using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksQueryDriver
{
    public partial class BookService : Form
    {
        private BookController bookService = new BookController();
        public BookService()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = true;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }

        private void ButtonFirstQuestion_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = bookService.QueryFirstQuestion();
        }
        private void ButtonSecondQuestion_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = bookService.QuerySecondQuestion();
        }
        private void ButtonThirdQuestion_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = bookService.QueryThirdQuestion();
        }
    }
}
