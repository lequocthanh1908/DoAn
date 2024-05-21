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

namespace QuanLyCongViec.NhanVien
{
    public partial class ListNhanVien : Form
    {
        DoAnContext db = new DoAnContext();
        public ListNhanVien()
        {
            InitializeComponent();
        }

        private void ListNhanVien_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            listView1.Columns.Clear();
            listView1.Columns.Add(" ID", 120, HorizontalAlignment.Left);

            listView1.Columns.Add("Tên nhân viên", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Gmail", 200, HorizontalAlignment.Left);

            listView1.Columns.Add("Chức vụ", 100, HorizontalAlignment.Left);
            Load1();
        }
        public void Load1()
        {
            listView1.Items.Clear();
            var data = db.staff.OrderByDescending(x => x.Id).ToList();
            if (data.Count > 0)
            {
                foreach (var project in data)
                {
                    var pos = db.Positions.Find(project.IdPosition);
                    ListViewItem item = new ListViewItem(project.Id.ToString());

                    item.SubItems.Add(project.StaffName);
                    item.SubItems.Add(project.Gmail);
                    item.SubItems.Add(pos.PositionName);
                    listView1.Items.Add(item);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddNhanVien addNhanVien = new AddNhanVien();
            addNhanVien.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                int id = Convert.ToInt32(selectedItem.Text);
                var data=db.staff.Find(id);
                db.staff.Remove(data);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
                Load1();
            }
            else
            {
                MessageBox.Show("Không có mục nào được chọn.");
            }
        }
    }
}
