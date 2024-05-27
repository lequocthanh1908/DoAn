using QuanLyCongViec.Models;
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

namespace QuanLyCongViec.MyTask
{
    public partial class ListTask : Form
    {
        public int id;
        public DoAnContext _db = new DoAnContext();
        private PrintDocument printDocument;
        public ListTask(int id)
        {
            InitializeComponent();
            this.id = id;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
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
            txttongso.Text = "Tổng số công việc: " + data.Count.ToString();
            txtcvhoanthanh.Text = "Công việc đã hoàn thành: " + data.Where(x => x.Status == "Đã xong").Count();
            txtcvchuathoanthanh.Text = "Công việc chưa hoàn thành: " + data.Where(x => x.Status == "Đang thực hiện").Count();

            var a = data.Where(x => x.Status == "Đã xong").Count();
            var b = data.Count();
            if (data.Count > 0)
            {

                txttilehoanthanh.Text = "Tỉ lệ hoàn thành: " + ((a * 100) / b) + "%";
            }
            else
            {
                txttilehoanthanh.Text = "Tỉ lệ hoàn thành: 0%";

            }

            loaddata(data);
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
        private void loaddata(List<Models.Task> data)
        {
            listView1.Items.Clear();
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
        private void button1_Click(object sender, EventArgs e)
        {
            var data = _db.Tasks.Where(x => x.Status == "Đang thực hiện").ToList();
            loaddata(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = e.MarginBounds.Top;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            string line = null;
            Font printFont = new Font("Arial", 12);
            SolidBrush myBrush = new SolidBrush(Color.Black);

            float lineHeight = printFont.GetHeight(e.Graphics) + 20;
            var data = _db.Tasks.Where(x => x.IdStaff == id).ToList();
            var title = _db.staff.FirstOrDefault(x => x.Id == data[0].IdStaff);
            e.Graphics.DrawString("Tên nhân viên"+title.StaffName, printFont, myBrush, leftMargin, yPos, new StringFormat());
            yPos += lineHeight;
            foreach (var task in data)
            {
                var pj = _db.Projects.Find(task.IdProject);
                line = $"Tên task: {task.NameTask}                Mô tả:{task.Description}                 Project: {pj.NameProject}                 Trạng thái:{task.Status}";

                string[] lines = SplitStringToFit(line, printFont, e.MarginBounds.Width, e.Graphics);

                foreach (var subLine in lines)
                {
                    e.Graphics.DrawString(subLine, printFont, myBrush, leftMargin, yPos, new StringFormat());
                    yPos += lineHeight; 
                }

                count++;
            }
        }
        private string[] SplitStringToFit(string text, Font font, int maxWidth, Graphics g)
        {
            List<string> lines = new List<string>();
            StringBuilder currentLine = new StringBuilder();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (g.MeasureString(currentLine + word, font).Width > maxWidth)
                {
                    lines.Add(currentLine.ToString());
                    currentLine.Clear();
                }
                currentLine.Append(word + " ");
            }

            if (currentLine.Length > 0)
            {
                lines.Add(currentLine.ToString());
            }

            return lines.ToArray();
        }
    }
}
