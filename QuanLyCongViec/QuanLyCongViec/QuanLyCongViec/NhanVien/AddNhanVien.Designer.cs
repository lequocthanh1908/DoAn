namespace QuanLyCongViec.NhanVien
{
    partial class AddNhanVien
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
            button1 = new Button();
            label1 = new Label();
            txtName = new TextBox();
            cbbPos = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            txtAdress = new Label();
            label3 = new Label();
            txtSDT = new Label();
            txtGmail = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(271, 274);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 20);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Thêm nhân viên";
            // 
            // txtName
            // 
            txtName.Location = new Point(35, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // cbbPos
            // 
            cbbPos.FormattingEnabled = true;
            cbbPos.Location = new Point(271, 96);
            cbbPos.Name = "cbbPos";
            cbbPos.Size = new Size(151, 28);
            cbbPos.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(35, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(35, 236);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // txtAdress
            // 
            txtAdress.AutoSize = true;
            txtAdress.Location = new Point(271, 145);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(55, 20);
            txtAdress.TabIndex = 7;
            txtAdress.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 64);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 8;
            label3.Text = "Chức vụ";
            // 
            // txtSDT
            // 
            txtSDT.AutoSize = true;
            txtSDT.Location = new Point(35, 213);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(97, 20);
            txtSDT.TabIndex = 9;
            txtSDT.Text = "Số điện thoại";
            // 
            // txtGmail
            // 
            txtGmail.AutoSize = true;
            txtGmail.Location = new Point(35, 145);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(48, 20);
            txtGmail.TabIndex = 10;
            txtGmail.Text = "Gmail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 64);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 11;
            label6.Text = "Tên nhân viên";
            // 
            // AddNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 313);
            Controls.Add(label6);
            Controls.Add(txtGmail);
            Controls.Add(txtSDT);
            Controls.Add(label3);
            Controls.Add(txtAdress);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(cbbPos);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddNhanVien";
            Text = "AddNhanVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtName;
        private ComboBox cbbPos;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label txtAdress;
        private Label label3;
        private Label txtSDT;
        private Label txtGmail;
        private Label label6;
    }
}