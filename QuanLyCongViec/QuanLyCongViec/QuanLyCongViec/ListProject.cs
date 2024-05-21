using QuanLyCongViec.Models;
using QuanLyCongViec.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCongViec
{
    public partial class ListProject : Form
    {
        DoAnContext _db = new DoAnContext();
        public int id;
        public ListProject(int id)
        {
            InitializeComponent();
            this.id = id;
        }



        private void ListProject_Load(object sender, EventArgs e)
        {
            var data= new List<Models.Project>();
            var pm = _db.staff.Find(id);
            if (id == 1)
            {
                data = _db.Projects.ToList();
            }
            else {
                data = _db.Projects.Where(x=>x.NamePm==pm.StaffName).ToList();
            }

            listView1.Items.Clear();
            listView1.View = View.Details;

            listView1.Columns.Clear();
            listView1.Columns.Add("Project ID", 120, HorizontalAlignment.Left);

            listView1.Columns.Add("Project Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("PM Name", 200, HorizontalAlignment.Left);

            listView1.Columns.Add("Start Date", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("End Date", 100, HorizontalAlignment.Left);
            if (data.Count > 0)
            {
                foreach (var project in data)
                {
                    ListViewItem item = new ListViewItem(project.Id.ToString());

                    item.SubItems.Add(project.NameProject);
                    item.SubItems.Add(project.NamePm);
                    item.SubItems.Add(project.StartDate.ToString());
                    item.SubItems.Add(project.EndDate.ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject(id);
            addProject.Show();
            this.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                // Lấy ID từ cột đầu tiên của item đó
                string strid = item.SubItems[0].Text;
                int id=Convert.ToInt32(strid);
                DetailProject detailProject = new DetailProject(id);
                detailProject.Show();
            }
        }
    }
}
