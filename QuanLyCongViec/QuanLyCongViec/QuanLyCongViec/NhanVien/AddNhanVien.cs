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

namespace QuanLyCongViec.NhanVien
{
    public partial class AddNhanVien : Form
    {
        DoAnContext db=new DoAnContext();
        public AddNhanVien()
        {
            InitializeComponent();
            var data=db.Positions.ToList();
            for (int i = 0; i < data.Count; i++)
            {
                cbbPos.Items.Add(data[i].PositionName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staff data= new staff();
            data.StaffName=txtName.Text;
            data.Gmail=txtGmail.Text;
            data.NumberPhone=txtSDT.Text;
            data.AddressStaff=txtAdress.Text;

            var tsts=db.Positions.FirstOrDefault(x=>x.PositionName==cbbPos.Text);
            data.IdPosition =tsts.Id;
            db.staff.Add(data);
            db.SaveChanges();
            MessageBox.Show("Thêm thành công");
            this.Close();
            ListNhanVien form=new ListNhanVien();
            form.Show();
        }
    }
}
