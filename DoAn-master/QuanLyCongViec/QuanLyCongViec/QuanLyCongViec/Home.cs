﻿using QuanLyCongViec.Models;
using QuanLyCongViec.MyTask;
using QuanLyCongViec.NhanVien;
using QuanLyCongViec.TaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class Home : Form
    {
        public int id;
        DoAnContext db = new DoAnContext();
        public Home(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnListTask_Click(object sender, EventArgs e)
        {
            ListTask dialog = new ListTask(id);
            dialog.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListProject listProject = new ListProject(id);
            listProject.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogWork.LogWork data = new LogWork.LogWork(id);
            data.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListNhanVien nhanVien = new ListNhanVien();
            nhanVien.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListTaiKhoan listTaiKhoan = new ListTaiKhoan(id);
            listTaiKhoan.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var data = db.Users.FirstOrDefault(x => x.IdSaffer == id);
            if (data.IsAdmin == null)
            {
                btnListTask.Visible = false;
                button3.Visible = false;
                button1.Location = new System.Drawing.Point(button1.Location.X,button1.Location.Y-80);
                button2.Location = new System.Drawing.Point(button2.Location.X, button2.Location.Y - 80);
                button4.Location = new System.Drawing.Point(button4.Location.X, button4.Location.Y - 80);
                button5.Location = new System.Drawing.Point(button5.Location.X, button5.Location.Y - 80);
                return; }
            bool check = data.IsAdmin ?? false;
            if (!check)
            {

                button5.Visible = false;
            }
            button4.Visible = false;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}