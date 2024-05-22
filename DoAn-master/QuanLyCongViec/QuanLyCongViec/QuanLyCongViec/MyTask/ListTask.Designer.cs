namespace QuanLyCongViec.MyTask
{
    partial class ListTask
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(26, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(519, 343);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemActivate += ListTask_Load;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 38);
            label1.TabIndex = 1;
            label1.Text = "Danh sách công việc";
            // 
            // button1
            // 
            button1.Location = new Point(586, 64);
            button1.Name = "button1";
            button1.Size = new Size(179, 29);
            button1.TabIndex = 2;
            button1.Text = "Công việc chưa làm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(586, 122);
            button2.Name = "button2";
            button2.Size = new Size(179, 29);
            button2.TabIndex = 3;
            button2.Text = "Công việc đến hạn";
            button2.UseVisualStyleBackColor = true;
            // 
            // ListTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "ListTask";
            Text = "ListTask";
            Load += ListTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}