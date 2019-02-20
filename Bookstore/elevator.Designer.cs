namespace Bookstore
{
    partial class elevator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elevator));
            this.label_books = new System.Windows.Forms.Label();
            this.label_current_floor = new System.Windows.Forms.Label();
            this.label_coffe_floor = new System.Windows.Forms.Label();
            this.label_entrance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_quit_elevator = new System.Windows.Forms.Button();
            this.button_help_elevator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_books
            // 
            this.label_books.AutoSize = true;
            this.label_books.BackColor = System.Drawing.Color.Transparent;
            this.label_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_books.ForeColor = System.Drawing.Color.Black;
            this.label_books.Location = new System.Drawing.Point(675, 390);
            this.label_books.Name = "label_books";
            this.label_books.Size = new System.Drawing.Size(101, 33);
            this.label_books.TabIndex = 1;
            this.label_books.Text = "Books";
            // 
            // label_current_floor
            // 
            this.label_current_floor.AutoSize = true;
            this.label_current_floor.BackColor = System.Drawing.Color.Transparent;
            this.label_current_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_floor.ForeColor = System.Drawing.Color.Black;
            this.label_current_floor.Location = new System.Drawing.Point(587, 242);
            this.label_current_floor.Name = "label_current_floor";
            this.label_current_floor.Size = new System.Drawing.Size(286, 31);
            this.label_current_floor.TabIndex = 2;
            this.label_current_floor.Text = "Books And Machines";
            // 
            // label_coffe_floor
            // 
            this.label_coffe_floor.AutoSize = true;
            this.label_coffe_floor.BackColor = System.Drawing.Color.Transparent;
            this.label_coffe_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coffe_floor.ForeColor = System.Drawing.Color.Black;
            this.label_coffe_floor.Location = new System.Drawing.Point(634, 115);
            this.label_coffe_floor.Name = "label_coffe_floor";
            this.label_coffe_floor.Size = new System.Drawing.Size(170, 33);
            this.label_coffe_floor.TabIndex = 3;
            this.label_coffe_floor.Text = "Coffe Floor";
            // 
            // label_entrance
            // 
            this.label_entrance.AutoSize = true;
            this.label_entrance.BackColor = System.Drawing.Color.Transparent;
            this.label_entrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entrance.ForeColor = System.Drawing.Color.Black;
            this.label_entrance.Location = new System.Drawing.Point(665, 527);
            this.label_entrance.Name = "label_entrance";
            this.label_entrance.Size = new System.Drawing.Size(139, 33);
            this.label_entrance.TabIndex = 4;
            this.label_entrance.Text = "Entrance";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(895, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 92);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(889, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 98);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(889, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 98);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(889, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 89);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_quit_elevator
            // 
            this.button_quit_elevator.BackColor = System.Drawing.Color.Transparent;
            this.button_quit_elevator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_quit_elevator.BackgroundImage")));
            this.button_quit_elevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quit_elevator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quit_elevator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_quit_elevator.Location = new System.Drawing.Point(12, 547);
            this.button_quit_elevator.Name = "button_quit_elevator";
            this.button_quit_elevator.Size = new System.Drawing.Size(75, 57);
            this.button_quit_elevator.TabIndex = 9;
            this.button_quit_elevator.UseVisualStyleBackColor = false;
            this.button_quit_elevator.Click += new System.EventHandler(this.button_quit_elevator_Click);
            // 
            // button_help_elevator
            // 
            this.button_help_elevator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_help_elevator.BackgroundImage")));
            this.button_help_elevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_help_elevator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_help_elevator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help_elevator.Location = new System.Drawing.Point(12, 24);
            this.button_help_elevator.Name = "button_help_elevator";
            this.button_help_elevator.Size = new System.Drawing.Size(75, 55);
            this.button_help_elevator.TabIndex = 10;
            this.button_help_elevator.UseVisualStyleBackColor = true;
            // 
            // elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 627);
            this.Controls.Add(this.button_help_elevator);
            this.Controls.Add(this.button_quit_elevator);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_entrance);
            this.Controls.Add(this.label_coffe_floor);
            this.Controls.Add(this.label_current_floor);
            this.Controls.Add(this.label_books);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "elevator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "elevator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_books;
        private System.Windows.Forms.Label label_current_floor;
        private System.Windows.Forms.Label label_coffe_floor;
        private System.Windows.Forms.Label label_entrance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_quit_elevator;
        private System.Windows.Forms.Button button_help_elevator;
    }
}