using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileWorld
{
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
        }

        private void Devices_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
            dataGridView1.DataSource = context.Categories.ToList();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
            int idSelect = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CategoryID"].Value.ToString());
            Category category = context.Categories.Where(c=> c.CategoryID == idSelect).FirstOrDefault();
            if (category != null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
                RefreshData();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
            int idSelect = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CategoryID"].Value.ToString());
            Category category = context.Categories.Where(c => c.CategoryID == idSelect).FirstOrDefault();
            if (category != null)
            {
                category.CategoryName = dataGridView1.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                category.CategoryDescription = dataGridView1.SelectedRows[0].Cells["CategoryDescription"].Value.ToString();
        
                context.SaveChanges();
                RefreshData();
            }
        }
    }
}
