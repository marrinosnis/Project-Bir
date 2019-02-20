namespace Bookstore
{
    partial class cafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cafe));
            this.button_back_to_elevator = new System.Windows.Forms.Button();
            this.button_quit_cafe = new System.Windows.Forms.Button();
            this.button_help_cafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_back_to_elevator
            // 
            this.button_back_to_elevator.BackColor = System.Drawing.Color.Transparent;
            this.button_back_to_elevator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back_to_elevator.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_to_elevator.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_back_to_elevator.Location = new System.Drawing.Point(282, 584);
            this.button_back_to_elevator.Name = "button_back_to_elevator";
            this.button_back_to_elevator.Size = new System.Drawing.Size(803, 51);
            this.button_back_to_elevator.TabIndex = 0;
            this.button_back_to_elevator.Text = "Go Back to Elevator";
            this.button_back_to_elevator.UseVisualStyleBackColor = false;
            this.button_back_to_elevator.Click += new System.EventHandler(this.button_back_to_elevator_Click);
            // 
            // button_quit_cafe
            // 
            this.button_quit_cafe.BackColor = System.Drawing.Color.Transparent;
            this.button_quit_cafe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_quit_cafe.BackgroundImage")));
            this.button_quit_cafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quit_cafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quit_cafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit_cafe.Location = new System.Drawing.Point(12, 556);
            this.button_quit_cafe.Name = "button_quit_cafe";
            this.button_quit_cafe.Size = new System.Drawing.Size(75, 59);
            this.button_quit_cafe.TabIndex = 1;
            this.button_quit_cafe.UseVisualStyleBackColor = false;
            this.button_quit_cafe.Click += new System.EventHandler(this.button_quit_cafe_Click);
            // 
            // button_help_cafe
            // 
            this.button_help_cafe.BackColor = System.Drawing.Color.Transparent;
            this.button_help_cafe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_help_cafe.BackgroundImage")));
            this.button_help_cafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_help_cafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_help_cafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help_cafe.Location = new System.Drawing.Point(1005, 511);
            this.button_help_cafe.Name = "button_help_cafe";
            this.button_help_cafe.Size = new System.Drawing.Size(65, 55);
            this.button_help_cafe.TabIndex = 2;
            this.button_help_cafe.UseVisualStyleBackColor = false;
            // 
            // cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 627);
            this.Controls.Add(this.button_help_cafe);
            this.Controls.Add(this.button_quit_cafe);
            this.Controls.Add(this.button_back_to_elevator);
            this.Name = "cafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cafe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_back_to_elevator;
        private System.Windows.Forms.Button button_quit_cafe;
        private System.Windows.Forms.Button button_help_cafe;
    }
}