using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bookstore
{
    public partial class Scanner : Form
    {
        bool close = true;
        bool one = false;
        int dir = 1;
        int times = 0;
        int count = 2;

        public Scanner()
        {
            InitializeComponent();
        }


        private void button_scanner_Click(object sender, EventArgs e)
        {
            if (close == false)
                MessageBox.Show("You can't scanner with open lid. Please close first");
            else if (count == 2)
            {
                MessageBox.Show("You need to load document first");
            }
            else
            {
                strech_Tick(sender, e);
                button_cancel.Enabled = true;
            }
        }

        private void button_open_lid_Click(object sender, EventArgs e)
        {
           
            button_open_lid.Visible = false;
            button_close_lid.Visible = true;
            close = false;
            count += 1;
            pictureBox_open.Visible = true;
            pictureBox_close.Visible = false;

        }

        private void button_close_lid_Click(object sender, EventArgs e)
        {
            button_open_lid.Visible = true;
            button_close_lid.Visible = false;
            close = true;
            count -= 2;
            pictureBox_close.Visible = true;
            pictureBox_open.Visible = false;
            
            
        }

        private void strech_Tick(object sender, EventArgs e)
        {
            strech.Enabled = true;
            bunifuCircleProgressbar1.Visible = true;
            scannig_label.Visible = true;
            wait_label.Visible = true;

            if (bunifuCircleProgressbar1.Value == 95) // κάπου εδώ είναι το πρόβλημα
            {
                times += 1;
                dir -= 1; //μείωση
                bunifuCircleProgressbar1.animationIterval = 4;

                if (times == 3)
                {
                    disable();
                    times = 0;
                    bunifuCustomLabel1.Visible = true;
                    button_send_email.Visible = true;
                    button_send_to_print.Visible = true;

                }

            }
            
           else if(bunifuCircleProgressbar1.Value==5)
            {
                dir += 1; //αύξηση 
                bunifuCircleProgressbar1.animationIterval = 3;
            }

                bunifuCircleProgressbar1.Value += dir;       //μέχρι εδώ
        }
        
        void disable()
        {
            strech.Enabled = false;
            bunifuCircleProgressbar1.Visible = false;
            scannig_label.Visible = false;
            wait_label.Visible = false;
            button_scanner.Enabled = false;
            button_cancel.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Printer move = new Printer();
            move.Show();
            button_scanner.Enabled = true;
            button_cancel.Enabled = true;
            count = 2;
            button_send_to_print.Visible = false;
            email_textbox.Visible = false;
            button_send_email.Visible = false;
            button_Send_mail.Visible = false;
            bunifuCustomLabel1.Visible = false;

        }

        private void button_send_email_Click(object sender, EventArgs e)
        {
            email_textbox.Visible = true;
            button_send_to_print.Enabled = false;
            button_Send_mail.Visible = true;
            button_send_email.Enabled = false;
        }

        private void email_textbox_Enter(object sender, EventArgs e)
        {
            if(email_textbox.Text== "put your email")
            {
                email_textbox.Text = "";
                email_textbox.ForeColor = Color.Black;
            }
        }

        private void email_textbox_Leave(object sender, EventArgs e)
        {
            if (email_textbox.Text == "")
            {
                email_textbox.Text = "put your email";
                email_textbox.ForeColor = Color.Silver;
            }

            string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(email_textbox.Text, pattern))
            {
                errorProvider1.Clear();
                one = true; //bool
            }
            else
            {
                errorProvider1.SetError(this.email_textbox, "Please put correct mail");
                one = false;  //bool
                return;
            }
        }

        private void button_Send_mail_Click(object sender, EventArgs e)
        {
            if (one == true)  //bool
            {
                button_send_email.Enabled = true;
                email_textbox.Clear();
                email_textbox.Visible = false;
                button_send_to_print.Enabled = true;
                button_Send_mail.Visible = false;
                MessageBox.Show("Send to your email, succed");
                button_cancel.Enabled = true;
                button_scanner.Enabled = true;
                count = 2;
                button_send_to_print.Visible = false;
                email_textbox.Visible = false;
                button_send_email.Visible = false;
                button_Send_mail.Visible = false;
                bunifuCustomLabel1.Visible = false;

            }
            

        }

        private void button_quit_scanner_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit from the current app ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            
        }
    }
}