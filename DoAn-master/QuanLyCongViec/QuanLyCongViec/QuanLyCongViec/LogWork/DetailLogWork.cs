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

namespace QuanLyCongViec.LogWork
{
    public partial class DetailLogWork : Form
    {
        public int id;
        DoAnContext db = new DoAnContext();
        public DetailLogWork(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void DetailLogWork_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Ngày", 250); // Wider to accommodate both title and description
            listView1.Columns.Add("Task làm", 250);

            LoadDataTable(null, null);
        }
        public void LoadDataTable(DateTime? startdate, DateTime? todate)
        {
            var data = new List<Models.LogWork>();
           
            listView1.Items.Clear();
            if (startdate != null || todate != null)
            {
                data = db.LogWorks.Where(x => x.IdStaff == id).Where(x => x.Date >= startdate && x.Date <= todate).OrderByDescending(x => x.Id).Take(7).ToList();
            }
            else
            {
                data = db.LogWorks.Where(x => x.IdStaff == id).OrderByDescending(x => x.Id).ToList();
            }

            foreach (var item in data)
            {
                var datatess = db.Tasks.Find(item.IdTask);
                ListViewItem itemlis = new ListViewItem(item.Date.ToString());
                itemlis.SubItems.Add(datatess.NameTask);
                listView1.Items.Add(itemlis);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataTable(dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
