using QuanLyCongViec.Models;
using QuanLyCongViec.MyTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec.Project
{
    public partial class DetailProject : Form
    {
        private int id;
        DoAnContext _db = new DoAnContext();
        public DetailProject(int id)
        {
            InitializeComponent();
            this.id = id;

        }

        private void DetailProject_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Chờ");
            comboBox1.Items.Add("Đang thực hiện");
            comboBox1.Items.Add("Đã xong");
            listView1.View = View.Details;

            listView1.Columns.Clear();
            listView1.Columns.Add("Id", 120, HorizontalAlignment.Left);

            listView1.Columns.Add("Task", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Trạng thái", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ngày tạo", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Người thực hiện", 200, HorizontalAlignment.Left);
            var data = _db.Tasks.Where(x => x.IdProject == id).ToList();
            Loaddata(data);
        }
        public void Loaddata(List<Models.Task> data)
        {
             listView1.Items.Clear();
            if (data.Count > 0)
            {

                foreach (var project in data)
                {
                    ListViewItem item = new ListViewItem(project.Id.ToString());

                    item.SubItems.Add(project.NameTask);
                    item.SubItems.Add(project.Status);
                    item.SubItems.Add(project.StartDate.ToString());
                    if (project.IdStaff.HasValue)
                    {
                        var staff = _db.staff.Find(project.IdStaff.Value);
                        item.SubItems.Add(staff.StaffName);

                    }
                    listView1.Items.Add(item);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddTask data = new AddTask(id);
            data.Show();
            this.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);
            string strid = item.SubItems[0].Text;
            int id = Convert.ToInt32(strid);

            AsignTask task = new AsignTask(id);
            task.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem;
            string selectedText = selectedItem.ToString();
            var data = _db.Tasks.Where(x => x.IdProject == id && x.Status == selectedText).ToList();
            Loaddata(data);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                int id = Convert.ToInt32(selectedItem.Text);
                var data = _db.Tasks.Find(id);
                var lgo = _db.LogWorks.Where(x => x.IdTask == data.Id).ToList();
                var cmt = _db.Comments.Where(x => x.IdTask == data.Id).ToList();
                foreach (var item in lgo)
                {
                    _db.LogWorks.Remove(item);
                    _db.SaveChanges();
                }
                foreach (var item in cmt)
                {
                    _db.Comments.Remove(item);
                    _db.SaveChanges();
                }
                _db.Tasks.Remove(data);
                _db.SaveChanges();
                MessageBox.Show("Xóa thành công");
                var data1 = _db.Tasks.Where(x => x.IdProject == this.id).ToList();
                Loaddata(data1);
            }
            else
            {
                MessageBox.Show("Không có mục nào được chọn.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                int id = Convert.ToInt32(selectedItem.Text);
                DetailTask detail =new DetailTask(id);
                detail.Show();
            }
        }
    }
}
