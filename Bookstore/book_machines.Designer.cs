namespace Bookstore
{
    partial class book_machines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_machines));
            this.label_machines = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.button_quit_book_machines = new System.Windows.Forms.Button();
            this.button_help_bookmachines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_machines
            // 
            this.label_machines.AutoSize = true;
            this.label_machines.BackColor = System.Drawing.Color.Transparent;
            this.label_machines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_machines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_machines.Location = new System.Drawing.Point(341, 253);
            this.label_machines.Name = "label_machines";
            this.label_machines.Size = new System.Drawing.Size(77, 20);
            this.label_machines.TabIndex = 1;
            this.label_machines.Text = "Machines";
            this.label_machines.Click += new System.EventHandler(this.label_machines_Click_1);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_exit.Location = new System.Drawing.Point(143, 232);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(52, 13);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "               ";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // button_quit_book_machines
            // 
            this.button_quit_book_machines.BackColor = System.Drawing.Color.Transparent;
            this.button_quit_book_machines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_quit_book_machines.BackgroundImage")));
            this.button_quit_book_machines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quit_book_machines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit_book_machines.Location = new System.Drawing.Point(12, 560);
            this.button_quit_book_machines.Name = "button_quit_book_machines";
            this.button_quit_book_machines.Size = new System.Drawing.Size(69, 55);
            this.button_quit_book_machines.TabIndex = 3;
            this.button_quit_book_machines.UseVisualStyleBackColor = false;
            this.button_quit_book_machines.Click += new System.EventHandler(this.button_quit_book_machines_Click);
            // 
            // button_help_bookmachines
            // 
            this.button_help_bookmachines.BackColor = System.Drawing.Color.Transparent;
            this.button_help_bookmachines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_help_bookmachines.BackgroundImage")));
            this.button_help_bookmachines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_help_bookmachines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_help_bookmachines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help_bookmachines.Location = new System.Drawing.Point(1060, 545);
            this.button_help_bookmachines.Name = "button_help_bookmachines";
            this.button_help_bookmachines.Size = new System.Drawing.Size(77, 64);
            this.button_help_bookmachines.TabIndex = 4;
            this.button_help_bookmachines.UseVisualStyleBackColor = false;
            // 
            // book_machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 627);
            this.Controls.Add(this.button_help_bookmachines);
            this.Controls.Add(this.button_quit_book_machines);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.label_machines);
            this.Name = "book_machines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "book_machines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_machines;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button button_quit_book_machines;
        private System.Windows.Forms.Button button_help_bookmachines;
    }
}