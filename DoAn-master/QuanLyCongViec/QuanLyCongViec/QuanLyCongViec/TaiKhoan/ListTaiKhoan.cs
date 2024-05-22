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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCongViec.TaiKhoan
{
    public partial class ListTaiKhoan : Form
    {
        DoAnContext db = new DoAnContext();
        public int id;
        public ListTaiKhoan(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ListTaiKhoan_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            listView1.Columns.Clear();
            listView1.Columns.Add(" ID", 120, HorizontalAlignment.Left);

            listView1.Columns.Add("Tài khoản", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Nhân viên", 200, HorizontalAlignment.Left);
            Load1();
        }
        public void Load1()
        {
            listView1.Items.Clear();
            var data = db.Users.Where(x => x.Id != id).OrderByDescending(x => x.Id).ToList();
            if (data.Count > 0)
            {
                foreach (var project in data)
                {
                    var pos = db.staff.Find(project.IdSaffer);
                    ListViewItem item = new ListViewItem(project.Id.ToString());

                    item.SubItems.Add(project.UserName);
                    item.SubItems.Add(pos.StaffName);
                    listView1.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(false);
            signUp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                string idstr = selectedItem.SubItems[0].Text;
                int id1 = Convert.ToInt32(idstr);
                var data = db.Users.Find(id1);
                db.Users.Remove(data);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(true);
            signUp.Show();
        }
    }
}
