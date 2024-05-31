using QuanLyCongViec.Models;
using QuanLyCongViec.MyTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private PrintDocument printDocument;

        public DetailProject(int id)
        {
            InitializeComponent();
            this.id = id;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
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
            listView1.Columns.Add("Ngày bắt đầu", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Người thực hiện", 200, HorizontalAlignment.Left);
            var data = _db.Tasks.Where(x => x.IdProject == id).ToList();
            label2.Text = "Tổng số công việc " + data.Count;
            label3.Text = "Công việc đã hoàn thành: " + data.Where(x => x.Status == "Đã xong").Count();
            label4.Text = "Công việc đang làm: " + data.Where(x => x.Status == "Đang thực hiện").Count();
            label5.Text = "Công việc chưa làm: " + data.Where(x => x.Status == "Chờ").Count();

            var a = data.Where(x => x.Status == "Đã xong").Count();
            var b = data.Count();
            if (data.Count > 0)
            {

                label6.Text = "Tiến độ: " + ((a * 100) / b) + "%";
            }
            else
            {
                label6.Text = "Tiến độ: 0%";

            }
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
            this.Close();
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font font = new Font("Arial", 12);

            float x = 20;
            float y = 20;

            float nameTaskWidth = 150;
            float descriptionWidth = 150;
            float startdateWidth = 150;
            float enddateWidth = 150;
            float statusWidth = 150;
            float rowHeight = 40;

            g.DrawString(" Tên task ", font, Brushes.Black, new RectangleF(x, y, nameTaskWidth, rowHeight), new StringFormat());
            x += nameTaskWidth;
            g.DrawString(" Mô tả ", font, Brushes.Black, new RectangleF(x, y, descriptionWidth, rowHeight), new StringFormat());
            x += descriptionWidth;
            g.DrawString(" Trạng thái ", font, Brushes.Black, new RectangleF(x, y, startdateWidth, rowHeight), new StringFormat());
            x += startdateWidth; 
            g.DrawString(" Ngày bắt đầu", font, Brushes.Black, new RectangleF(x, y, startdateWidth, rowHeight), new StringFormat());
            x += enddateWidth;
            g.DrawString(" Ngày kết thúc", font, Brushes.Black, new RectangleF(x, y, statusWidth, rowHeight), new StringFormat());

            var data = _db.Tasks.Where(task => task.IdProject == id).ToList();

            foreach (var task in data)
            {
                var pj = _db.Projects.Find(task.IdProject);
                x = 20;
                y += rowHeight;
                DateTime endate=task.StartDate?? DateTime.Now;
                double date = (double)task.Effort;
                endate = endate.AddDays(date);
                g.DrawString(" " + task.NameTask + " ", font, Brushes.Black, new RectangleF(x, y, nameTaskWidth, rowHeight), new StringFormat { Trimming = StringTrimming.Word, FormatFlags = StringFormatFlags.LineLimit });
                x += nameTaskWidth;
                g.DrawString(" " + task.Description + " ", font, Brushes.Black, new RectangleF(x, y, descriptionWidth, rowHeight), new StringFormat { Trimming = StringTrimming.Word, FormatFlags = StringFormatFlags.LineLimit });
                x += descriptionWidth;
                g.DrawString(" " + task.Status+ " ", font, Brushes.Black, new RectangleF(x, y, startdateWidth, rowHeight), new StringFormat { Trimming = StringTrimming.Word, FormatFlags = StringFormatFlags.LineLimit });
                x += startdateWidth;
                g.DrawString(" " + task.StartDate.ToString() + " ", font, Brushes.Black, new RectangleF(x, y, statusWidth, rowHeight), new StringFormat { Trimming = StringTrimming.Word, FormatFlags = StringFormatFlags.LineLimit });
                x += enddateWidth;
                g.DrawString(" " + endate.ToString() + " ", font, Brushes.Black, new RectangleF(x, y, statusWidth, rowHeight), new StringFormat { Trimming = StringTrimming.Word, FormatFlags = StringFormatFlags.LineLimit });
            }

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
                DetailTask detail = new DetailTask(id);
                detail.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
