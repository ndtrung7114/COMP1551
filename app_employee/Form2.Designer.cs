namespace app_employee
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.show_text = new System.Windows.Forms.RichTextBox();
            this.show = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.write_file = new System.Windows.Forms.Button();
            this.read_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 251);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // show_text
            // 
            this.show_text.Location = new System.Drawing.Point(257, 79);
            this.show_text.Name = "show_text";
            this.show_text.Size = new System.Drawing.Size(200, 252);
            this.show_text.TabIndex = 20;
            this.show_text.Text = "";
            this.show_text.TextChanged += new System.EventHandler(this.show_text_TextChanged);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.show.Location = new System.Drawing.Point(205, 346);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 22;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(500, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 251);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // write_file
            // 
            this.write_file.Location = new System.Drawing.Point(454, 345);
            this.write_file.Name = "write_file";
            this.write_file.Size = new System.Drawing.Size(75, 23);
            this.write_file.TabIndex = 24;
            this.write_file.Text = "Write file";
            this.write_file.UseVisualStyleBackColor = true;
            this.write_file.Click += new System.EventHandler(this.write_file_Click);
            // 
            // read_file
            // 
            this.read_file.Location = new System.Drawing.Point(558, 345);
            this.read_file.Name = "read_file";
            this.read_file.Size = new System.Drawing.Size(75, 23);
            this.read_file.TabIndex = 25;
            this.read_file.Text = "Read file";
            this.read_file.UseVisualStyleBackColor = true;
            this.read_file.Click += new System.EventHandler(this.read_file_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.read_file);
            this.Controls.Add(this.write_file);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.show_text);
            this.Controls.Add(this.show);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox show_text;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button write_file;
        private System.Windows.Forms.Button read_file;
    }
}