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
    public partial class machines : Form
    {
        public machines()
        {
            InitializeComponent();
        }

        private void button_printer_Click(object sender, EventArgs e)
        {
            Scanner move6 = new Scanner();
            move6.Show();
            
        }

        private void button_scanner_Click(object sender, EventArgs e)
        {
            Printer move5 = new Printer();
            move5.Show();
        }

        private void button_quit_machines_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit from the current app ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
