namespace Bookstore
{
    partial class Scanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner));
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_scanner = new System.Windows.Forms.Button();
            this.label_open_lid = new System.Windows.Forms.Label();
            this.button_open_lid = new System.Windows.Forms.Button();
            this.button_close_lid = new System.Windows.Forms.Button();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.strech = new System.Windows.Forms.Timer(this.components);
            this.scannig_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.wait_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button_send_email = new System.Windows.Forms.Button();
            this.button_send_to_print = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_Send_mail = new System.Windows.Forms.Button();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_open = new System.Windows.Forms.PictureBox();
            this.button_quit_scanner = new System.Windows.Forms.Button();
            this.button_help_scanner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_open)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Enabled = false;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(617, 330);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(110, 72);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_scanner
            // 
            this.button_scanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scanner.Location = new System.Drawing.Point(814, 330);
            this.button_scanner.Name = "button_scanner";
            this.button_scanner.Size = new System.Drawing.Size(94, 90);
            this.button_scanner.TabIndex = 11;
            this.button_scanner.Text = "Scanner";
            this.button_scanner.UseVisualStyleBackColor = true;
            this.button_scanner.Click += new System.EventHandler(this.button_scanner_Click);
            // 
            // label_open_lid
            // 
            this.label_open_lid.AutoSize = true;
            this.label_open_lid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_open_lid.ForeColor = System.Drawing.Color.Black;
            this.label_open_lid.Location = new System.Drawing.Point(12, 9);
            this.label_open_lid.Name = "label_open_lid";
            this.label_open_lid.Size = new System.Drawing.Size(255, 24);
            this.label_open_lid.TabIndex = 12;
            this.label_open_lid.Text = "Push to open or close the Lid";
            // 
            // button_open_lid
            // 
            this.button_open_lid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open_lid.Location = new System.Drawing.Point(66, 36);
            this.button_open_lid.Name = "button_open_lid";
            this.button_open_lid.Size = new System.Drawing.Size(98, 31);
            this.button_open_lid.TabIndex = 13;
            this.button_open_lid.Text = "OPEN LID";
            this.button_open_lid.UseVisualStyleBackColor = true;
            this.button_open_lid.Click += new System.EventHandler(this.button_open_lid_Click);
            // 
            // button_close_lid
            // 
            this.button_close_lid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close_lid.ForeColor = System.Drawing.Color.Black;
            this.button_close_lid.Location = new System.Drawing.Point(66, 36);
            this.button_close_lid.Name = "button_close_lid";
            this.button_close_lid.Size = new System.Drawing.Size(98, 31);
            this.button_close_lid.TabIndex = 14;
            this.button_close_lid.Text = "CLOSE LID";
            this.button_close_lid.UseVisualStyleBackColor = true;
            this.button_close_lid.Visible = false;
            this.button_close_lid.Click += new System.EventHandler(this.button_close_lid_Click);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 1;
            this.bunifuCircleProgressbar1.animationSpeed = 1;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(52, 198);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(153, 153);
            this.bunifuCircleProgressbar1.TabIndex = 15;
            this.bunifuCircleProgressbar1.Value = 20;
            this.bunifuCircleProgressbar1.Visible = false;
            // 
            // strech
            // 
            this.strech.Interval = 20;
            this.strech.Tick += new System.EventHandler(this.strech_Tick);
            // 
            // scannig_label
            // 
            this.scannig_label.AutoSize = true;
            this.scannig_label.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scannig_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scannig_label.Location = new System.Drawing.Point(24, 162);
            this.scannig_label.Name = "scannig_label";
            this.scannig_label.Size = new System.Drawing.Size(246, 27);
            this.scannig_label.TabIndex = 16;
            this.scannig_label.Text = "Scanning Loading...";
            this.scannig_label.Visible = false;
            // 
            // wait_label
            // 
            this.wait_label.AutoSize = true;
            this.wait_label.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wait_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wait_label.Location = new System.Drawing.Point(62, 375);
            this.wait_label.Name = "wait_label";
            this.wait_label.Size = new System.Drawing.Size(143, 27);
            this.wait_label.TabIndex = 17;
            this.wait_label.Text = "Please Wait";
            this.wait_label.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(630, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(245, 29);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Scanning Complete";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // button_send_email
            // 
            this.button_send_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_send_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send_email.Location = new System.Drawing.Point(546, 70);
            this.button_send_email.Name = "button_send_email";
            this.button_send_email.Size = new System.Drawing.Size(141, 36);
            this.button_send_email.TabIndex = 21;
            this.button_send_email.Text = "Send to E-mail";
            this.button_send_email.UseVisualStyleBackColor = true;
            this.button_send_email.Visible = false;
            this.button_send_email.Click += new System.EventHandler(this.button_send_email_Click);
            // 
            // button_send_to_print
            // 
            this.button_send_to_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send_to_print.Location = new System.Drawing.Point(847, 70);
            this.button_send_to_print.Name = "button_send_to_print";
            this.button_send_to_print.Size = new System.Drawing.Size(75, 36);
            this.button_send_to_print.TabIndex = 22;
            this.button_send_to_print.Text = "Print";
            this.button_send_to_print.UseVisualStyleBackColor = true;
            this.button_send_to_print.Visible = false;
            this.button_send_to_print.Click += new System.EventHandler(this.button2_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.email_textbox.Location = new System.Drawing.Point(526, 120);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(190, 26);
            this.email_textbox.TabIndex = 23;
            this.email_textbox.Text = "put your email";
            this.email_textbox.Visible = false;
            this.email_textbox.Enter += new System.EventHandler(this.email_textbox_Enter);
            this.email_textbox.Leave += new System.EventHandler(this.email_textbox_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button_Send_mail
            // 
            this.button_Send_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Send_mail.Location = new System.Drawing.Point(574, 162);
            this.button_Send_mail.Name = "button_Send_mail";
            this.button_Send_mail.Size = new System.Drawing.Size(75, 33);
            this.button_Send_mail.TabIndex = 24;
            this.button_Send_mail.Text = "Send";
            this.button_Send_mail.UseVisualStyleBackColor = true;
            this.button_Send_mail.Visible = false;
            this.button_Send_mail.Click += new System.EventHandler(this.button_Send_mail_Click);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(170, 36);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 25;
            this.pictureBox_close.TabStop = false;
            // 
            // pictureBox_open
            // 
            this.pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_open.Image")));
            this.pictureBox_open.Location = new System.Drawing.Point(170, 36);
            this.pictureBox_open.Name = "pictureBox_open";
            this.pictureBox_open.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_open.TabIndex = 26;
            this.pictureBox_open.TabStop = false;
            this.pictureBox_open.Visible = false;
            // 
            // button_quit_scanner
            // 
            this.button_quit_scanner.BackColor = System.Drawing.Color.Transparent;
            this.button_quit_scanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_quit_scanner.BackgroundImage")));
            this.button_quit_scanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quit_scanner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_quit_scanner.Location = new System.Drawing.Point(12, 557);
            this.button_quit_scanner.Name = "button_quit_scanner";
            this.button_quit_scanner.Size = new System.Drawing.Size(75, 58);
            this.button_quit_scanner.TabIndex = 27;
            this.button_quit_scanner.UseVisualStyleBackColor = false;
            this.button_quit_scanner.Click += new System.EventHandler(this.button_quit_scanner_Click);
            // 
            // button_help_scanner
            // 
            this.button_help_scanner.BackColor = System.Drawing.Color.Transparent;
            this.button_help_scanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_help_scanner.BackgroundImage")));
            this.button_help_scanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_help_scanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_help_scanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help_scanner.Location = new System.Drawing.Point(983, 553);
            this.button_help_scanner.Name = "button_help_scanner";
            this.button_help_scanner.Size = new System.Drawing.Size(87, 62);
            this.button_help_scanner.TabIndex = 45;
            this.button_help_scanner.UseVisualStyleBackColor = false;
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 627);
            this.Controls.Add(this.button_help_scanner);
            this.Controls.Add(this.button_quit_scanner);
            this.Controls.Add(this.pictureBox_open);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.button_Send_mail);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.button_send_to_print);
            this.Controls.Add(this.button_send_email);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.wait_label);
            this.Controls.Add(this.scannig_label);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.button_close_lid);
            this.Controls.Add(this.button_open_lid);
            this.Controls.Add(this.label_open_lid);
            this.Controls.Add(this.button_scanner);
            this.Controls.Add(this.button_cancel);
            this.Name = "Scanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_scanner;
        private System.Windows.Forms.Label label_open_lid;
        private System.Windows.Forms.Button button_open_lid;
        private System.Windows.Forms.Button button_close_lid;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Timer strech;
        private Bunifu.Framework.UI.BunifuCustomLabel scannig_label;
        private Bunifu.Framework.UI.BunifuCustomLabel wait_label;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button button_send_email;
        private System.Windows.Forms.Button button_send_to_print;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button_Send_mail;
        private System.Windows.Forms.PictureBox pictureBox_open;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Button button_quit_scanner;
        private System.Windows.Forms.Button button_help_scanner;
    }
}