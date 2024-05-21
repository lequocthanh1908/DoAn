namespace QuanLyCongViec.Project
{
    partial class AddTask
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
            label1 = new Label();
            button1 = new Button();
            txtDes = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSoNgay = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            txtpath = new TextBox();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 41);
            label1.TabIndex = 0;
            label1.Text = "Thêm Task";
            // 
            // button1
            // 
            button1.Location = new Point(571, 308);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(387, 101);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(278, 172);
            txtDes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 78);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên Task";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 78);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "Mô tả";
            label3.Click += label3_Click;
            // 
            // txtSoNgay
            // 
            txtSoNgay.Location = new Point(44, 184);
            txtSoNgay.Name = "txtSoNgay";
            txtSoNgay.Size = new Size(246, 27);
            txtSoNgay.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(44, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 27);
            txtName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 151);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 9;
            label5.Text = "Số ngày thực hiện";
            // 
            // txtpath
            // 
            txtpath.Location = new Point(44, 261);
            txtpath.Name = "txtpath";
            txtpath.Size = new Size(185, 27);
            txtpath.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(235, 261);
            button2.Name = "button2";
            button2.Size = new Size(55, 29);
            button2.TabIndex = 11;
            button2.Text = "file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 223);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 12;
            label4.Text = "Hình ảnh";
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 367);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(txtpath);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(txtSoNgay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDes);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "AddTask";
            Text = "AddTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtDes;
        private Label label2;
        private Label label3;
        private TextBox txtSoNgay;
        private TextBox txtName;
        private Label label5;
        private TextBox txtpath;
        private Button button2;
        private Label label4;
    }
}