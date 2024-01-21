namespace Student_Registry
{
    partial class loginform
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
            loginbtn = new Button();
            email = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(306, 247);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(112, 34);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Log In";
            loginbtn.UseMnemonic = false;
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // email
            // 
            email.Location = new Point(266, 103);
            email.Name = "email";
            email.Size = new Size(219, 31);
            email.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(266, 179);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(219, 31);
            password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 75);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 151);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(loginbtn);
            Name = "loginform";
            Text = "Log In";
            Load += loginform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private TextBox email;
        private TextBox password;
        private Label label1;
        private Label label2;
    }
}
