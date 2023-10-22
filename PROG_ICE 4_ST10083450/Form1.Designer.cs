namespace PROG_ICE_4_ST10083450
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(304, 117);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(200, 23);
            tbxUsername.TabIndex = 0;
            tbxUsername.TextChanged += textBox1_TextChanged;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(304, 177);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(200, 23);
            tbxPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(354, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(98, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 120);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 180);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
    }
}