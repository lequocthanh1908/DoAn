using QuanLyCongViec.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec.LogWork
{
    public partial class LogWork : Form
    {
        public int id;
        DoAnContext _db = new DoAnContext();
        public LogWork(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Visible = true;
                dateTimePicker2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                dateTimePicker2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Task = _db.Tasks.FirstOrDefault(x => x.NameTask == comboBox1.SelectedItem.ToString());
            if (!checkBox1.Checked)
            {
                var data = new Models.LogWork();
                data.Date = dateTimePicker1.Value;
                data.IdStaff = id;
                data.IdTask = Task.Id;
                _db.LogWorks.Add(data);
                _db.SaveChanges();
            }
            else
            {
                DateTime startDate = dateTimePicker1.Value.Date;
                DateTime endDate = dateTimePicker2.Value.Date;

                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    var data = new Models.LogWork();
                    data.Date = date;
                    data.IdStaff = id;
                    data.IdTask = Task.Id;
                    _db.LogWorks.Add(data);
                    _db.SaveChanges();
                }

            }

            MessageBox.Show("Log work thành công");
        }

        private void LogWork_Load(object sender, EventArgs e)
        {
            var data = _db.Tasks.Where(x => x.IdStaff == id).ToList();
            foreach (var task in data)
            {
                comboBox1.Items.Add(task.NameTask);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetailLogWork data=new DetailLogWork(id);
            data.Show();
        }
    }
}
