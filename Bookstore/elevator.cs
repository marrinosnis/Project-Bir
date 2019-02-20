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
    public partial class elevator : Form
    {
        public elevator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cafe move12 = new cafe();
            move12.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            book_machines move9 = new book_machines();
            move9.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //books Mr. Nikos
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookPlace move10 = new BookPlace();
            move10.Show();
            this.Dispose();
        }

        private void button_quit_elevator_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit from the current app ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
