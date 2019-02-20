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
    public partial class book_machines : Form
    {
        public book_machines()
        {
            InitializeComponent();
        }

        private void label_machines_Click_1(object sender, EventArgs e)
        {
            machines move7 = new machines();
            move7.Show();

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            elevator move8 = new elevator();
            move8.Show();
        }

        private void button_quit_book_machines_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit from the current app ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
