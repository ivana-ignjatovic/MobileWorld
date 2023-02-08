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
    public partial class Form1 : Form
    {
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
            dataGridView1.DataSource = context.Employees.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
