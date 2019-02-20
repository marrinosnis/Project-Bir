namespace Bookstore
{
    partial class machines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(machines));
            this.button_scanner = new System.Windows.Forms.Button();
            this.button_printer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_quit_machines = new System.Windows.Forms.Button();
            this.button_help_machines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_scanner
            // 
            this.button_scanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_scanner.BackgroundImage")));
            this.button_scanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_scanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_scanner.Location = new System.Drawing.Point(2, 131);
            this.button_scanner.Name = "button_scanner";
            this.button_scanner.Size = new System.Drawing.Size(560, 359);
            this.button_scanner.TabIndex = 0;
            this.button_scanner.UseVisualStyleBackColor = true;
            this.button_scanner.Click += new System.EventHandler(this.button_printer_Click);
            // 
            // button_printer
            // 
            this.button_printer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_printer.BackgroundImage")));
            this.button_printer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_printer.Location = new System.Drawing.Point(684, 131);
            this.button_printer.Name = "button_printer";
            this.button_printer.Size = new System.Drawing.Size(386, 398);
            this.button_printer.TabIndex = 1;
            this.button_printer.UseVisualStyleBackColor = true;
            this.button_printer.Click += new System.EventHandler(this.button_scanner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scanner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(823, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Printer";
            // 
            // button_quit_machines
            // 
            this.button_quit_machines.BackColor = System.Drawing.Color.Transparent;
            this.button_quit_machines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_quit_machines.BackgroundImage")));
            this.button_quit_machines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quit_machines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quit_machines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit_machines.Location = new System.Drawing.Point(2, 548);
            this.button_quit_machines.Name = "button_quit_machines";
            this.button_quit_machines.Size = new System.Drawing.Size(75, 67);
            this.button_quit_machines.TabIndex = 4;
            this.button_quit_machines.UseVisualStyleBackColor = false;
            this.button_quit_machines.Click += new System.EventHandler(this.button_quit_machines_Click);
            // 
            // button_help_machines
            // 
            this.button_help_machines.BackColor = System.Drawing.Color.Transparent;
            this.button_help_machines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_help_machines.BackgroundImage")));
            this.button_help_machines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_help_machines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_help_machines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help_machines.Location = new System.Drawing.Point(983, 553);
            this.button_help_machines.Name = "button_help_machines";
            this.button_help_machines.Size = new System.Drawing.Size(87, 62);
            this.button_help_machines.TabIndex = 44;
            this.button_help_machines.UseVisualStyleBackColor = false;
            // 
            // machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1082, 627);
            this.Controls.Add(this.button_help_machines);
            this.Controls.Add(this.button_quit_machines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_printer);
            this.Controls.Add(this.button_scanner);
            this.Name = "machines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "machines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_scanner;
        private System.Windows.Forms.Button button_printer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_quit_machines;
        private System.Windows.Forms.Button button_help_machines;
    }
}