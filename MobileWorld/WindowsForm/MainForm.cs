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
    public partial class MainForm : Form
    {
        private List<Device> devicesForBill = new List<Device>();
        private List <DeviceBill> itemsBill= new List<DeviceBill>();
       
        public MainForm()
        {
            InitializeComponent();
            panelDevices.AutoScroll= true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          RefreshForm();    
        }
        private void RefreshForm()
        {
            panelCategory.Controls.Clear();
            int x = 10;
            int y = 10;
            int counter = 0;
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            List<Category> categories = new List<Category>();
            categories = context.Categories.ToList();
            List<Device> devices = context.Devices.ToList();
            foreach (var category in categories)
            {
                var categoryItem = new CategoryPanel(category);
                categoryItem.ButtonClick += CategoryPanel_LabelClick;
                categoryItem.Location = new Point(50, 50 + (categories.IndexOf(category) * categoryItem.Height));
                int x1 = (panelCategory.Width - categoryItem.Width) / 2;
                categoryItem.Left = x1;
                panelCategory.Controls.Add(categoryItem);
            }
            foreach (var device in devices)
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
        }
        private void DeviceItem_ButtonClick(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            List<Device> devices = new List<Device>();
            devices = context.Devices.ToList();
            DevicePanel deviceItem = (DevicePanel)sender;
            Device currentDevice = deviceItem.currentDevice;
            devicesForBill.Add(currentDevice);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.Color.White;

            dataGridView1.Rows.Add( currentDevice.DeviceName+
                ".......................................",  currentDevice.DevicePrice);
                    

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

        private void progressBar1_Click(object sender, EventArgs e)
        {
            var employee = new EmployeesForm();
            employee.ShowDialog();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee = new EmployeesForm();
            employee.ShowDialog();
        }

        private void uredjajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var devices = new CategoriesAndDeviceForm();
            devices.ShowDialog();
            RefreshForm();
        }
       private void Naplata()
        {
            
            Bill bill = new Bill();
            int sum = 0;
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            bill.BillEmployee = Properties.Settings.Default.UserId;
            bill.BillDateTime = DateTime.Now;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["DevicePrice"].Value);
            }
            bill.BillTotal = sum;
            dataGridView1.Rows.Clear();
            context.Bills.Add(bill);
            context.SaveChanges();
            List<DeviceBill> itemsBill = new List<DeviceBill>();
            
            foreach (var device in devicesForBill)
            {
                if (context.DeviceBills.Where(db => db.BillID == bill.BillID && db.DeviceID == device.DeviceID).Any())
                {
                    DeviceBill itemBill = context.DeviceBills.First(db => db.BillID == bill.BillID && db.DeviceID == device.DeviceID);
                    itemBill.Quantity += 1;
                }
                else
                {
                    DeviceBill itemBill = new DeviceBill();
                    itemBill.DeviceID = device.DeviceID;
                    itemBill.BillID = bill.BillID;
                    itemBill.Quantity = 1;
                    context.DeviceBills.Add(itemBill);
                }
                context.SaveChanges();
            }


            var billPanel = new OneBillForm(bill);

            billPanel.ShowDialog();
        }
        private void buttonNaplati_Click(object sender, EventArgs e)
        {
            Naplata(); 
        }

        private void buttonDeleteBillITem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void racuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bill = new BillsForm();
            bill.ShowDialog();
        }
    }
}
