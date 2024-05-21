namespace QuanLyCongViec.Project
{
    partial class AddProject
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
            txtNameProject = new TextBox();
            cbb_namePM = new ComboBox();
            dTP_StartDate = new DateTimePicker();
            DTP_Enddate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_Add = new Button();
            SuspendLayout();
            // 
            // txtNameProject
            // 
            txtNameProject.Location = new Point(78, 75);
            txtNameProject.Name = "txtNameProject";
            txtNameProject.Size = new Size(233, 27);
            txtNameProject.TabIndex = 0;
            // 
            // cbb_namePM
            // 
            cbb_namePM.FormattingEnabled = true;
            cbb_namePM.Location = new Point(78, 166);
            cbb_namePM.Name = "cbb_namePM";
            cbb_namePM.Size = new Size(233, 28);
            cbb_namePM.TabIndex = 1;
            // 
            // dTP_StartDate
            // 
            dTP_StartDate.Location = new Point(396, 75);
            dTP_StartDate.Name = "dTP_StartDate";
            dTP_StartDate.Size = new Size(250, 27);
            dTP_StartDate.TabIndex = 2;
            // 
            // DTP_Enddate
            // 
            DTP_Enddate.Location = new Point(396, 164);
            DTP_Enddate.Name = "DTP_Enddate";
            DTP_Enddate.Size = new Size(250, 27);
            DTP_Enddate.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 39);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 131);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên PM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 39);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 6;
            label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 131);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày kết thúc";
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(487, 222);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(159, 29);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Ok";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // AddProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 263);
            Controls.Add(btn_Add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DTP_Enddate);
            Controls.Add(dTP_StartDate);
            Controls.Add(cbb_namePM);
            Controls.Add(txtNameProject);
            Name = "AddProject";
            Text = "AddProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameProject;
        private ComboBox cbb_namePM;
        private DateTimePicker dTP_StartDate;
        private DateTimePicker DTP_Enddate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Add;
    }
}