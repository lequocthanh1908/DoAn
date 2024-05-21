namespace QuanLyCongViec
{
    partial class Home
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
            btnListTask = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 54);
            label1.TabIndex = 0;
            label1.Text = "Trang chủ";
            // 
            // btnListTask
            // 
            btnListTask.Location = new Point(54, 87);
            btnListTask.Name = "btnListTask";
            btnListTask.Size = new Size(151, 58);
            btnListTask.TabIndex = 1;
            btnListTask.Text = "Danh sách công việc";
            btnListTask.UseVisualStyleBackColor = true;
            btnListTask.Click += btnListTask_Click;
            // 
            // button2
            // 
            button2.Location = new Point(295, 318);
            button2.Name = "button2";
            button2.Size = new Size(151, 58);
            button2.TabIndex = 2;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(295, 87);
            button3.Name = "button3";
            button3.Size = new Size(151, 58);
            button3.TabIndex = 3;
            button3.Text = "Log work list";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(54, 208);
            button5.Name = "button5";
            button5.Size = new Size(151, 58);
            button5.TabIndex = 5;
            button5.Text = "List Project";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(295, 208);
            button1.Name = "button1";
            button1.Size = new Size(151, 58);
            button1.TabIndex = 6;
            button1.Text = "Nhân viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(54, 318);
            button4.Name = "button4";
            button4.Size = new Size(151, 58);
            button4.TabIndex = 7;
            button4.Text = "Tài khoản";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 437);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnListTask);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnListTask;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button4;
    }
}