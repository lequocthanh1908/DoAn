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

namespace QuanLyCongViec.Project
{
    public partial class AddProject : Form
    {
        public int id;
        DoAnContext db=new DoAnContext();
        public AddProject(int id)
        {
            InitializeComponent();
            var data = db.staff.Where(x => x.IdPosition == 1).ToList();

            for (int i = 0; i < data.Count; i++)
            {
                cbb_namePM.Items.Add(data[i].StaffName);
            }
            this.id = id;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            QuanLyCongViec.Models.Project project=new Models.Project();
            project.NameProject=txtNameProject.Text;
            project.NamePm=cbb_namePM.Text;
            project.StartDate=dTP_StartDate.Value;
            project.EndDate=DTP_Enddate.Value;
            db.Projects.Add(project);
            db.SaveChanges();
            MessageBox.Show("Thêm project thành công");
            this.Close();
            ListProject listProject = new ListProject(id);
            listProject.Show();
        }
    }
}
