using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Printer : Form
    {
        public Printer()
        {
            InitializeComponent();

        }

        private void button_click(object sender, EventArgs e)
        {
                Button buttons = (Button)sender;
                text_screen.Text = text_screen.Text + buttons.Text;
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(text_screen.Text);
                int z = int.Parse(textBox_of_papers.Text);
                int y = int.Parse((z - x).ToString());
                textBox_of_papers.Text = y.ToString();

                if (x > 100)
                {
                    z = x + y;
                    textBox_of_papers.Text = z.ToString();
                    MessageBox.Show("There are too many copies. Not Valid");
                    text_screen.Clear();

                }

                else if (z > 1 && z <16 )
                {
                    if (y >= 0)
                    {
                        print_label.Visible = true;
                        bunifuCircleProgressbar1.Visible = true;
                        timer1.Enabled = true;
                        timer1.Interval = 100;
                        timer1_Tick(sender, e);
                        text_screen.Enabled = false;
                        cancel_button.Enabled = true;
                        print_button.Enabled = false;
                        MessageBox.Show("You need to load paper soon, bacause your papers are less than 15");
                    }
                    else
                    {
                        z = x + y;
                        textBox_of_papers.Text = z.ToString();
                        MessageBox.Show("Not enough papers");
                        text_screen.Clear();
                    }
                }
                else if (z - x < 0)
                {

                    if (z == 0)
                    {
                        z = x + y;
                        textBox_of_papers.Text = z.ToString();
                        MessageBox.Show("You need to load first and then start the process");
                        text_screen.Clear();

                    }
                    else
                    {
                        z = x + y;
                        textBox_of_papers.Text = z.ToString();
                        MessageBox.Show("You run out of papers. You can only ask for copies " + z + " or less");
                        text_screen.Clear();
                    }
                   
                }
                else if (x == 0)
                {
                    MessageBox.Show("Not valid number for copies!");
                    text_screen.Clear();
                }
                else
                {
                    print_label.Visible = true;
                    bunifuCircleProgressbar1.Visible = true;
                    timer1.Enabled = true;
                    timer1.Interval = 100;
                    timer1_Tick(sender, e);
                    text_screen.Enabled = false;
                    cancel_button.Enabled = true;
                    print_button.Enabled = false;
                }

                if (text_ink.Text == "0" || text_ink_color.Text == "0")
                    MessageBox.Show("You need to load ink to print");

                else if (comboBox_colors.Text == "Colorful" && text_screen.Text != "")
                {
                    bunifuProgressBar2.Value = x / 10;
                    int j = int.Parse(text_ink_color.Text);
                    int t = int.Parse((j - (x / 10)).ToString());
                    text_ink_color.Text = t.ToString();
                }

                else if (comboBox_colors.Text == "Black-White" && text_screen.Text != "")
                {
                    bunifuProgressBar1.Value = x / 10;
                    int i = int.Parse(text_ink.Text);
                    int k = int.Parse((i - (x / 10)).ToString());
                    text_ink.Text = k.ToString();
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("You need to put valid number for copies");
                print_button.Enabled = true;
            }

        }

        private void Printer_Load(object sender, EventArgs e)
        {
            text_screen.MaxLength = 2;
            button_load_inks.Enabled = false;
            button_load_pappers.Enabled = false;
            
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            text_screen.Clear();

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (MessageBox.Show("Are you sure you want to Cancel the process ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cancel_button.Enabled = false;
                timer1.Enabled = false;
                text_screen.Enabled = false;
                print_button.Enabled = true;
                bunifuCircleProgressbar1.Visible = false;
                bunifuCircleProgressbar1.Value = 0;
                print_label.Visible = false;
            }
            else
                timer1.Enabled = true;
        }

        private void yes_label_Click(object sender, EventArgs e)
        {
            yes_label.Visible = false;
            no_label.Visible = false;
            print_label.Visible = false;
            ask_label.Visible = false;
            print_button.Enabled = true;
            cancel_button.Enabled = false;
            text_screen.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value != 100)
            {
                bunifuCircleProgressbar1.Value++;
                button_load_pappers.Enabled = false;
                button_load_inks.Enabled = false;
                clear_button.Enabled = false;
                comboBox_colors.Enabled = false;
                comboBox_pappers.Enabled = false;
            }

            else
            {
                timer1.Stop();
                bunifuCircleProgressbar1.Value = 0;
                MessageBox.Show("Your printing is done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bunifuCircleProgressbar1.Visible = false;
                print_label.Visible = false;
                ask_label.Visible = true;
                yes_label.Visible = true;
                no_label.Visible = true;
                cancel_button.Enabled = false;
                button_load_pappers.Enabled = true;
                button_load_inks.Enabled = true;
                clear_button.Enabled = true;
                comboBox_colors.Enabled = true;
                comboBox_pappers.Enabled = true;
            }
        }

        private void button_load_pappers_Click(object sender, EventArgs e)
        {
            textBox_load_pappers.Visible = true;
            button_ok_load.Visible = true;
        }

        private void button_ok_load_Click(object sender, EventArgs e)
        {
            int q = int.Parse(textBox_of_papers.Text); //ekei opou tha pane ta xartia
            int u = int.Parse(textBox_load_pappers.Text); //xartia pou bazei o xrhsths
            if (u > 100 || u == 0)
            {
                MessageBox.Show("Put number of papers more than zero and less than hundred");
                textBox_load_pappers.Clear();
            }
            else
            {
                int h = q + u;
                textBox_of_papers.Text = h.ToString();
                textBox_load_pappers.Visible = false;
                button_ok_load.Visible = false;
            }
        }

        private void button_load_inks_Click(object sender, EventArgs e)
        {
            textBox_load_blackInk.Visible = true;
            textBox_load_colofulInk.Visible = true;
            button_load_black.Visible = true;
            button_load_colorful.Visible = true;

        }

        private void button_load_colorful_Click(object sender, EventArgs e)
        {
            int q = int.Parse(text_ink_color.Text); // ekei pou tha paei o arithmos
            int u = int.Parse(textBox_load_colofulInk.Text); // pou tha balei o xrhsths
            if (u > 100 || u == 0)
            {
                MessageBox.Show("Put number of papers more than zero");
                textBox_load_colofulInk.Clear();
            }
            else
            {
                int h = q + u;
                if (h > 100)
                    MessageBox.Show("Overflowed");
                else
                {
                    text_ink_color.Text = h.ToString();
                    bunifuProgressBar2.Value -= h;
                    textBox_load_colofulInk.Visible = false;
                    button_load_colorful.Visible = false;
                }
            }
        }

        private void button_load_black_Click(object sender, EventArgs e)
        {
            int q = int.Parse(text_ink.Text);
            int u = int.Parse(textBox_load_blackInk.Text);
            if (u > 100 || u == 0)
            {
                MessageBox.Show("Put number of papers more than zero ");
                textBox_load_blackInk.Clear();
            }
            else
            {
                int h = q + u;
                if (h > 100)
                    MessageBox.Show("Overflowed");
                else
                {
                    text_ink.Text = h.ToString();
                    bunifuProgressBar1.Value -= h;
                    textBox_load_blackInk.Visible = false;
                    button_load_black.Visible = false;
                }
            }
        }

        private void text_screen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void no_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_quit_printer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit from the current app ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }

}

