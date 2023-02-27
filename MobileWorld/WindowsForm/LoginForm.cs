using System;
using System.CodeDom;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool validate = false;
            string username = textBoxUsern.Text;
            string password = textBoxPass.Text;
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            List<Employee> employees = context.Employees.ToList();
           
            foreach (Employee employee in employees)
            {
                if(employee.EmployeeUsername.Equals(username)&& employee.EmployeePassword.Equals(password))
                { 
                    
                    validate= true;
                    MainForm main = new MainForm();
                    this.Hide();
                    Properties.Settings.Default.UserId = employee.EmployeeID;
                    main.ShowDialog();
                }
                else
                {
                    validate = false;
                } 
                if (validate == true)
                {
                return;
                 
                }
            }
            
            if (validate == false)
            {
                MessageBox.Show("Uneli ste pogresne podatke za prijavu!");
                textBoxUsern.Text = "";
                textBoxPass.Text = "";
            }
        }
    }
}
