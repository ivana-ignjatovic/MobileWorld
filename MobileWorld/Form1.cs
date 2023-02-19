using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MobileWorld
{
    public partial class Form1 : Form
    {
        private List<Device> devicesForBill = new List<Device>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            List<Category> categories = new List<Category>();
            categories=context.Categories.ToList();
            foreach(var category in categories)
            {
                var categoryItem = new CategoryPanel(category);
                categoryItem.ButtonClick += CategoryPanel_LabelClick;
                categoryItem.Location = new Point(50, 50 + (categories.IndexOf(category) * categoryItem.Height));
                int x = (panelCategory.Width - categoryItem.Width) / 2;
                categoryItem.Left = x;
                

                panelCategory.Controls.Add(categoryItem);
            }
        }
        private void DeviceItem_ButtonClick(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            List<Device> devices = new List<Device>();
            devices = context.Devices.ToList();
            DevicePanel deviceItem = (DevicePanel)sender;
            Device currentDevice = deviceItem.currentDevice;

            // devicesForBill.Add(currentDevice);

            

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.Color.White;

            dataGridView1.Rows.Add(currentDevice.DeviceName+ ".......................................", "............." + currentDevice.DevicePrice+"RSD");
                    
                
         





            //dataGridView1.DataSource = devicesForBill;
            Console.WriteLine("Usao " + devicesForBill.Count());
            

        }
        private void CategoryPanel_LabelClick(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            CategoryPanel categoryPanel = (CategoryPanel)sender;
            
            panelDevices.Controls.Clear();
            Category currentCategory = categoryPanel.currentCategory;
            List<Device> devices = new List<Device>();
            devices = context.Devices.ToList();
          
            int x = 10;
            int y = 10;
            int counter = 0;
            foreach (var device in devices)
            {
                if (currentCategory.CategoryID == device.DeviceCategory)
                {
                var deviceItem = new DevicePanel(device);
                deviceItem.ButtonClick += DeviceItem_ButtonClick;
                deviceItem.Location = new Point(x, y);
                panelDevices.Controls.Add(deviceItem);

                x += deviceItem.Width + 10;
                counter++;
                if (counter % 2 == 0)
                {
                    x = 10;
                    y += deviceItem.Height + 10;
                }
                }
                else
                {
                    Console.WriteLine("Nema uredjaja za datu kategoriju");
              }  
         

            }

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void progressBar1_Click(object sender, EventArgs e)
        {
            var employee = new AddEmployeeForm();
            employee.ShowDialog();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee = new AddEmployeeForm();
            employee.ShowDialog();
        }

        private void uredjajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var devices = new Devices();
            devices.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panelDevices_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
