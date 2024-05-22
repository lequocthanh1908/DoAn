namespace QuanLyCongViec.TaiKhoan
{
    partial class ListTaiKhoan
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
            button2 = new Button();
            listView1 = new ListView();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(484, 34);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 0;
            button1.Text = "Thêm tài khoản";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 34);
            button2.Name = "button2";
            button2.Size = new Size(136, 29);
            button2.TabIndex = 2;
            button2.Text = "Xóa tài khoản";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 94);
            listView1.Name = "listView1";
            listView1.Size = new Size(610, 295);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button3
            // 
            button3.Location = new Point(81, 34);
            button3.Name = "button3";
            button3.Size = new Size(198, 29);
            button3.TabIndex = 4;
            button3.Text = "Thêm tài khoản cho PM";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ListTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 401);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ListTaiKhoan";
            Text = "ListTaiKhoan";
            Load += ListTaiKhoan_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListView listView1;
        private Button button3;
    }
}