namespace QuanLyCongViec.Project
{
    partial class DetailProject
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(29, 165);
            listView1.Name = "listView1";
            listView1.Size = new Size(734, 260);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(635, 61);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 1;
            button1.Text = "thêm task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(574, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 41);
            label1.TabIndex = 3;
            label1.Text = "Danh sách task";
            // 
            // button2
            // 
            button2.Location = new Point(635, 110);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 4;
            button2.Text = "Lọc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(385, 61);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 5;
            button3.Text = "Xóa task";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(510, 61);
            button4.Name = "button4";
            button4.Size = new Size(119, 29);
            button4.TabIndex = 6;
            button4.Text = "Xem task";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DetailProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "DetailProject";
            Text = "DetailProject";
            Load += DetailProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}