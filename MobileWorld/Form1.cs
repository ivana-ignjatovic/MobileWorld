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

        private void button1_Click(object sender, EventArgs e)
        {
            
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            Employee employee = new Employee();
            employee.EmployeeName = "Ivana";
            employee.EmployeeSurname = "Ignjatovic";
            employee.EmployeePhone = "0605511358";
            employee.EmployeeRole = "Administrator";
            context.Employees.Add(employee);
            context.SaveChanges();
            RefreshData();
        }
        private void RefreshData()
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            //dataGridView1.DataSource = context.Employees.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
            List<Device> devices = new List<Device>();
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            devices = context.Devices.ToList();
            int x = 10;
            int y = 10;
            int counter = 0;
            foreach (var device in devices)
            {
                
                var deviceItem = new DeviceItem(device);
                deviceItem.Click += DeviceItem_Click;
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
            List<Category> categories = new List<Category>();
            categories=context.Categories.ToList();
            foreach(var category in categories)
            {
                var categoryItem = new CategoryPanel();
                categoryItem.Location = new Point(10, 10 + (categories.IndexOf(category) * categoryItem.Height));
                categoryItem.labelCategory.Text = category.CategoryName;
                panelCategory.Controls.Add(categoryItem);
            }


        }
        private void DeviceItem_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            List<Device> devices = new List<Device>();
            devices = context.Devices.ToList();
            Console.WriteLine("Usao");
            DeviceItem deviceItem = (DeviceItem)sender;
            Device currentDevice = deviceItem.currentDevice;
            //dataGridView1.
           // for(int i = 0; i < 4; i++)
            //{
                devicesForBill.Add(currentDevice);
            //}
            dataGridView1.Rows.Add(currentDevice.DeviceID,currentDevice.DeviceName);
            //dataGridView1.DataSource = devicesForBill;
            Console.WriteLine("Usao " + devicesForBill.Count());
            

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //MOBILESTOREDBContext context = new MOBILESTOREDBContext();


            // Device device = new Device();
            // device.DeviceName = "Samsung A53";
            // device.DevicePrice = "22000";
            //  device.DeviceCategory = 1;
            //  device.DeviceCharact = "Opis";
            //  context.Devices.Add(device);
            // context.SaveChanges();
          
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
