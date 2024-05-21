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

namespace QuanLyCongViec.MyTask
{
    public partial class DetailTask : Form
    {
        DoAnContext _db = new DoAnContext();
        public int id;
        public DetailTask(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = _db.Tasks.Find(id);
            data.Status = "Đã xong";
            _db.Tasks.Update(data);
            _db.SaveChanges();
            MessageBox.Show("Đã hoàn thành task");
        }

        private void DetailTask_Load(object sender, EventArgs e)
        {
            var data = _db.Tasks.Find(id);
            txtDate.Text = data.StartDate.ToString();
            txtName.Text = data.NameTask;
            txtDes.Text = data.Description;

            listView1.Columns.Add("Id", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Nội dung", 120, HorizontalAlignment.Left);
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comment data=new Comment();
            data.Description=txtComment.Text;
            data.IdTask = id;
            _db.Comments.Add(data);
            _db.SaveChanges();
            LoadData();
        }
        public void LoadData()
        {
            listView1.Items.Clear();
            var data= _db.Comments.Where(x=>x.IdTask == id).OrderByDescending(x=>x.Id).ToList();
            foreach (var item in data)
            {
                ListViewItem item1 = new ListViewItem(item.Id.ToString());

                item1.SubItems.Add(item.Description);
               
                listView1.Items.Add(item1);
            }
        }
    }
}
