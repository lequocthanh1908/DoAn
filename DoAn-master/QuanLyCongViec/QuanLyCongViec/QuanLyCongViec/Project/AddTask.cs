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
    public partial class AddTask : Form
    {
        string path;
        int IdProject;
        DoAnContext _db = new DoAnContext();
        public AddTask(int id)
        {
            InitializeComponent();
            IdProject = id;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Task data = new Models.Task();
                data.NameTask = txtName.Text;
                data.Effort = Convert.ToInt32(txtSoNgay.Text);
                data.Status = "Chờ";
                data.CreateDate = DateTime.Now;
                data.IdProject = IdProject;
                data.Description = c.Text;
                string sourcePath = txtpath.Text;
                string targetPath = Path.Combine(Application.StartupPath, "images");
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }

                string fileName = Path.GetFileName(sourcePath);
                string destFile = Path.Combine(targetPath, fileName);

                File.Copy(sourcePath, destFile, true);
                data.Img = destFile;
                _db.Tasks.Add(data);
                _db.SaveChanges();
                MessageBox.Show("Thêm thành công");
                this.Close();
                DetailProject detail = new DetailProject(this.IdProject);
                detail.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn hình ảnh";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    txtpath.Text = selectedFilePath;
                }
            }

        }

        private void AddTask_Load(object sender, EventArgs e)
        {

        }
    }
}
