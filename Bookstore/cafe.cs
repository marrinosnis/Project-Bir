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
    public partial class cafe : Form
    {
        public cafe()
        {
            InitializeComponent();
        }

        private void button_back_to_elevator_Click(object sender, EventArgs e)
        {
            elevator move12 = new elevator();
            move12.Show();
        }

        private void button_quit_cafe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit from the current app ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
