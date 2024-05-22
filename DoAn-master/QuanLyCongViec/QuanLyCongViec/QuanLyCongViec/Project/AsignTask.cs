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
    public partial class AsignTask : Form
    {
        int id;
        public DoAnContext _db = new DoAnContext();
        public AsignTask(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = _db.Tasks.Find(id);
            if (data != null) {
                var staff=_db.staff.FirstOrDefault(x=>x.StaffName==comboBox1.SelectedItem.ToString());
                data.IdStaff =staff.Id;
                data.StartDate=DateTime.Now;
                data.Status = "Đang thực hiện";
                _db.Tasks.Update(data);
                _db.SaveChanges();
                MessageBox.Show("Giao việc thành công");
                this.Close();
            }
        }

        private void AsignTask_Load(object sender, EventArgs e)
        {
            var datacbb= _db.staff.Where(s=>s.IdPositionNavigation.PositionName == "Dev").ToList();
            foreach (var staff in datacbb) { 
             comboBox1.Items.Add(staff.StaffName);
            }
        }
    }
}
