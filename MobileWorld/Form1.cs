using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileWorld
{
    public partial class Form1 : Form
    {

        [DllImport("User32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_NCPAINT = 0x85;
            if (m.Msg == WM_NCPAINT)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if ((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.FillRectangle(Brushes.Red, new Rectangle(0, 0, 4800, 23));
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
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
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
            //dataGridView1.DataSource = context.Employees.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
            List<Device> devices = new List<Device>();
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
            devices = context.Devices.ToList();
            foreach (var device in devices)
            {


                var deviceItem = new DeviceItem();
                deviceItem.label1.Text = device.DeviceName;
                deviceItem.label2.Text = device.DevicePrice;
               panelDevices.Controls.Add(deviceItem);
                //this.Controls.Add(deviceItem);
            }


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
    }
}
