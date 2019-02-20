namespace Bookstore
{
    partial class BookPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookPlace));
            this.label_books = new System.Windows.Forms.Label();
            this.label_books_machine = new System.Windows.Forms.Label();
            this.label_cafe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_help_entrance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_books
            // 
            this.label_books.AutoSize = true;
            this.label_books.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_books.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_books.Location = new System.Drawing.Point(736, 372);
            this.label_books.Name = "label_books";
            this.label_books.Size = new System.Drawing.Size(67, 16);
            this.label_books.TabIndex = 0;
            this.label_books.Text = "1th Books";
            this.label_books.Click += new System.EventHandler(this.label_books_Click);
            // 
            // label_books_machine
            // 
            this.label_books_machine.AutoSize = true;
            this.label_books_machine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_books_machine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_books_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_books_machine.Location = new System.Drawing.Point(736, 339);
            this.label_books_machine.Name = "label_books_machine";
            this.label_books_machine.Size = new System.Drawing.Size(155, 16);
            this.label_books_machine.TabIndex = 1;
            this.label_books_machine.Text = "2th Books And Machines";
            this.label_books_machine.Click += new System.EventHandler(this.label_books_machine_Click);
            // 
            // label_cafe
            // 
            this.label_cafe.AutoSize = true;
            this.label_cafe.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_cafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cafe.Location = new System.Drawing.Point(736, 302);
            this.label_cafe.Name = "label_cafe";
            this.label_cafe.Size = new System.Drawing.Size(56, 16);
            this.label_cafe.TabIndex = 2;
            this.label_cafe.Text = "3th Cafe";
            this.label_cafe.Click += new System.EventHandler(this.label_cafe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elevator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.Color.Transparent;
            this.button_quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_quit.BackgroundImage")));
            this.button_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit.Location = new System.Drawing.Point(12, 559);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(82, 65);
            this.button_quit.TabIndex = 4;
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // button_help_entrance
            // 
            this.button_help_entrance.BackColor = System.Drawing.Color.Transparent;
            this.button_help_entrance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_help_entrance.BackgroundImage")));
            this.button_help_entrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_help_entrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_help_entrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help_entrance.Location = new System.Drawing.Point(1005, 559);
            this.button_help_entrance.Name = "button_help_entrance";
            this.button_help_entrance.Size = new System.Drawing.Size(65, 56);
            this.button_help_entrance.TabIndex = 5;
            this.button_help_entrance.UseVisualStyleBackColor = false;
            // 
            // BookPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 627);
            this.Controls.Add(this.button_help_entrance);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_cafe);
            this.Controls.Add(this.label_books_machine);
            this.Controls.Add(this.label_books);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BookPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookPlace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_books;
        private System.Windows.Forms.Label label_books_machine;
        private System.Windows.Forms.Label label_cafe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_help_entrance;
    }
}