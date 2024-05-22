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
    public partial class ListTask : Form
    {
        public int id;
        public DoAnContext _db = new DoAnContext();
        public ListTask(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ListTask_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 120, HorizontalAlignment.Left);

            listView1.Columns.Add("Task Name", 200, HorizontalAlignment.Left);

            listView1.Columns.Add("Start Date", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Còn lại", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Trạng thái", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Project", 100, HorizontalAlignment.Left);
            var data = _db.Tasks.Where(x => x.IdStaff == id).ToList();
            foreach (var project in data)
            {
                ListViewItem item = new ListViewItem(project.Id.ToString());

                item.SubItems.Add(project.NameTask);
                item.SubItems.Add(project.StartDate.ToString());
                DateTime dateTime = (DateTime)project.StartDate;
                DateTime deadline = dateTime.AddDays((double)project.Effort);

                // Get today's date
                DateTime today = DateTime.Now;

                // Calculate the remaining days
                int remainingDays = (deadline - today).Days;
                item.SubItems.Add(remainingDays.ToString());
                item.SubItems.Add(project.Status);

                var pj = _db.Projects.Find(project.IdProject);
                item.SubItems.Add(pj.NameProject);
                listView1.Items.Add(item);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                // Lấy ID từ cột đầu tiên của item đó
                string strid = item.SubItems[0].Text;
                int idTask = Convert.ToInt32(strid);
                DetailTask detail = new DetailTask(idTask);
                detail.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
