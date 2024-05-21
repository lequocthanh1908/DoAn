namespace QuanLyCongViec.MyTask
{
    partial class DetailTask
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
            txtDes = new TextBox();
            txtComment = new TextBox();
            txtDate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(640, 290);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 21);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên công việc";
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 27);
            txtName.TabIndex = 2;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(40, 135);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(273, 115);
            txtDes.TabIndex = 3;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(40, 292);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(572, 27);
            txtComment.TabIndex = 5;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(461, 54);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(273, 27);
            txtDate.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 269);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Bình luận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 101);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "Mô tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 21);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày hết hạn";
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(40, 343);
            listView1.Name = "listView1";
            listView1.Size = new Size(694, 167);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button2
            // 
            button2.Location = new Point(640, 134);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Hoàn thành task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DetailTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDate);
            Controls.Add(txtComment);
            Controls.Add(txtDes);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "DetailTask";
            Text = "DetailTask";
            Load += DetailTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtDes;
        private TextBox txtComment;
        private TextBox txtDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView listView1;
        private Button button2;
    }
}