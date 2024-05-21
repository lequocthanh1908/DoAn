using QuanLyCongViec.Models;

namespace QuanLyCongViec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoAnContext db = new DoAnContext();
            var data = db.Users.FirstOrDefault(x => x.UserName == txtUserName.Text);
            if (data != null)
            {
                if (txtPasswork.Text != data.PasswordHash)
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    return;
                }
                int staffid = (data.IdSaffer.HasValue) ? data.IdSaffer.Value : 0;
                Home home = new Home(staffid);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
