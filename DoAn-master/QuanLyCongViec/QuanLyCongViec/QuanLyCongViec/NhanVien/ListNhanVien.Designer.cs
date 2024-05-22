namespace QuanLyCongViec.NhanVien
{
    partial class ListNhanVien
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
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 310);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(634, 26);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 1;
            button1.Text = "Thêm nhân viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(487, 26);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 2;
            button2.Text = "Xóa nhân viên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(336, 26);
            button3.Name = "button3";
            button3.Size = new Size(118, 29);
            button3.TabIndex = 3;
            button3.Text = "Xem log work";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ListNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "ListNhanVien";
            Text = "ListNhanVien";
            Load += ListNhanVien_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}