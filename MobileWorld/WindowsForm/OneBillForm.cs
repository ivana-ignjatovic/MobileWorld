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
            InitializeComponent();
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            deviceBill = context.DeviceBills.Where(db => db.BillID == b.BillID).ToList();
            lblBillID.Text = b.BillID.ToString();

            Employee emp = context.Employees.Where(e => e.EmployeeID == b.BillEmployee).FirstOrDefault();
            lblEmployee.Text = emp.EmployeeName.ToString() + " " + emp.EmployeeSurname.ToString();
           
            foreach (var item in deviceBill)
            {
            
                labelBil.Text += "\n" + item.Device.DeviceName + "\n                             " 
                    + item.Device.DevicePrice + "      " + item.Quantity;

            }
            labelBil.Text = labelBil.Text;
            labelTotal.Text = b.BillTotal.ToString();
            lblBillDate.Text = b.BillDateTime.ToString();
            bill = b;
          
        }
        private void Refresh()
        {
            lblBillID.Text = "";
            lblBillDate.Text = "";
            lblEmployee.Text = "";
            labelTotal.Text = "";
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

        private void OneBillForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh();
        }

        private void OneBillForm_ControlRemoved(object sender, ControlEventArgs e)
        {
            Refresh();
        }
    }
}
