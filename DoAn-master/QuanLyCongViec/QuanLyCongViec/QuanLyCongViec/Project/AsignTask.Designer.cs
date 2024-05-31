namespace QuanLyCongViec.Project
{
    partial class AsignTask
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
            comboBox1 = new ComboBox();
            txtTaskName = new Label();
            txtEfff = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(262, 150);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 0;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên nhân viên";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 28);
            comboBox1.TabIndex = 2;
            // 
            // txtTaskName
            // 
            txtTaskName.AutoSize = true;
            txtTaskName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaskName.Location = new Point(97, 9);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(189, 38);
            txtTaskName.TabIndex = 3;
            txtTaskName.Text = "Tên nhân viên";
            // 
            // txtEfff
            // 
            txtEfff.Location = new Point(223, 93);
            txtEfff.Name = "txtEfff";
            txtEfff.Size = new Size(165, 27);
            txtEfff.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 49);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 5;
            label2.Text = "Số ngày thực hiện";
            // 
            // AsignTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 197);
            Controls.Add(label2);
            Controls.Add(txtEfff);
            Controls.Add(txtTaskName);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AsignTask";
            Text = "AsignTask";
            Load += AsignTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Label txtTaskName;
        private TextBox txtEfff;
        private Label label2;
    }
}