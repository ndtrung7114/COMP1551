namespace WindowsFormsApp3
{
    partial class Form_login
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_role = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(206, 177);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(157, 22);
            this.tb_user.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(211, 250);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(152, 22);
            this.tb_password.TabIndex = 1;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_user.Location = new System.Drawing.Point(67, 177);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(50, 25);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "user";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_password.Location = new System.Drawing.Point(67, 256);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(96, 25);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(685, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "welcome to greenwich viet nam";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "admin",
            "student",
            "association"});
            this.cb_role.Location = new System.Drawing.Point(211, 307);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(152, 24);
            this.cb_role.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Cyan;
            this.btn_login.Location = new System.Drawing.Point(236, 353);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(85, 27);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_role.Location = new System.Drawing.Point(67, 315);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(44, 25);
            this.lb_role.TabIndex = 7;
            this.lb_role.Text = "role";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(236, 403);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Remember login account";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Name = "Form_login";
            this.Text = "Form Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

