using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileWorld
{
    public partial class OneBillForm : Form
    {
        Bill bill;
        List<DeviceBill> deviceBill;
        public OneBillForm(Bill b)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            deviceBill = context.DeviceBills.Where(db => db.BillID == b.BillID).ToList();
            InitializeComponent();
            lblBillID.Text= b.BillID.ToString();
            lblEmployee.Text= b.BillEmployee.ToString();
            
            foreach (var item in deviceBill)
            {
                labelBil.Text += "\n" + item.Device.DeviceName + "        " + item.Device.DevicePrice + "      " + item.Quantity;
                

            }
            labelTotal.Text= b.BillTotal.ToString();
            lblBillDate.Text = b.BillDateTime.ToString();
            bill = b;
         
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblBillID_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {

        }

        private void BillPanel_Load(object sender, EventArgs e)
        {
           
        }

        private void BillPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            labelBil.Text = "";
        }

        private void buttonNaplati_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
         
            foreach(var itemBill in deviceBill)
            {
                context.DeviceBills.Add(itemBill);
                context.SaveChanges();
            }
            
        }
    }
}
