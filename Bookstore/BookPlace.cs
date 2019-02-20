using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class BookPlace : Form
    {
        public BookPlace()
        {
            InitializeComponent();
        }

        private void label_books_machine_Click(object sender, EventArgs e)
        {
            book_machines move4 = new book_machines();
            move4.Show();
        }

        private void label_cafe_Click(object sender, EventArgs e)
        {
            cafe move11 = new cafe();
            move11.Show();
            
        }

        private void label_books_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            elevator move12 = new elevator();
            move12.Show();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit from the current app ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
