namespace QuanLyCongViec
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
            txtUserName = new TextBox();
            txtPasswork = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(49, 84);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(337, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtPasswork
            // 
            txtPasswork.Location = new Point(47, 141);
            txtPasswork.Name = "txtPasswork";
            txtPasswork.Size = new Size(337, 27);
            txtPasswork.TabIndex = 2;
            txtPasswork.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 3;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 114);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 54);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Tài khoản";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(255, 179);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 299);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPasswork);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPasswork;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
    }
}
