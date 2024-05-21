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

namespace QuanLyCongViec
{
    public partial class SignUp : Form
    {
        public bool createAdmin;
        DoAnContext db = new DoAnContext();
        public SignUp(bool createAdmin)
        {
            InitializeComponent();
            this.createAdmin = createAdmin;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtComfPass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            if (txtPass.Text.Length == 0 || txtComfPass.Text.Length == 0 || txtUserName.Text.Length == 0)
            {
                return;
            }
            User da = new User();
            da.UserName = txtUserName.Text;
            da.PasswordHash = txtPass.Text;
            if (createAdmin)
            {
                da.IsAdmin = true;
            }
            else 
            { 
                da.IsAdmin = false;
            }
            da.IdSaffer=db.staff.FirstOrDefault(x=>x.StaffName==comboBox1.SelectedItem.ToString()).Id;
            db.Users.Add(da);
            db.SaveChanges();
            MessageBox.Show("Tạo tài khoản thành công");
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            var data = new List<staff>();
            if (createAdmin)
            {
                data=db.staff.Where(x=>x.IdPosition==1).ToList();
            }
            else
            {
                data = db.staff.Where(x => x.IdPosition == 2).ToList();
            }

            var user=db.Users.ToList();
            List<staff> staffs = new List<staff>();
            foreach (var item in data)
            {
                bool check=false;
                foreach (var item1 in user)
                {
                    if(item.Id ==item1.IdSaffer)
                    {
                        check=true;
                    }    
                }
                if (!check)
                {
                    comboBox1.Items.Add(item.StaffName);
                }
            }
        }
    }
}
