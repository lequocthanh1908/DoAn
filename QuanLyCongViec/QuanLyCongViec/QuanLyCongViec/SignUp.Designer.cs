namespace QuanLyCongViec
{
    partial class SignUp
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
            btnSignUp = new Button();
            label1 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPass = new TextBox();
            txtComfPass = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(277, 329);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 1;
            label1.Text = "Đăng kí";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(50, 78);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(321, 27);
            txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 118);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 182);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 4;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 48);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 5;
            label4.Text = "Tài khoản";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(50, 143);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(321, 27);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtComfPass
            // 
            txtComfPass.Location = new Point(50, 205);
            txtComfPass.Name = "txtComfPass";
            txtComfPass.Size = new Size(321, 27);
            txtComfPass.TabIndex = 7;
            txtComfPass.UseSystemPasswordChar = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(50, 274);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 28);
            comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 251);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 10;
            label5.Text = "Cho nhân viên";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 381);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(txtComfPass);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPass;
        private TextBox txtComfPass;
        private ComboBox comboBox1;
        private Label label5;
    }
}