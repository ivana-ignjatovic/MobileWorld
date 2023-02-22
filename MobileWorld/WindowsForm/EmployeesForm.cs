using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileWorld
{
    public partial class EmployeesForm : Form
    {
        public string originalValue;
        public EmployeesForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
          
            if(textBoxName.Text == "" || textBoxSurname.Text == "" ||
                comboBoxRole.SelectedItem.ToString()== "" || textBoxPhone.Text == ""
                || textBoxUsername.Text=="" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Morate uneti sva polja!");
            }
            else
            {
                MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
                var employees = context.Employees.ToList();
                var result = employees.Where(x => x.EmployeeUsername == textBoxUsername.Text);
                if (result == null)
                {
                    Employee employee = new Employee();
                    employee.EmployeeName = textBoxName.Text;
                    employee.EmployeeSurname = textBoxSurname.Text;
                    employee.EmployeeRole = comboBoxRole.SelectedItem.ToString();
                    originalValue = employee.EmployeeRole;
                    employee.EmployeePhone = textBoxPhone.Text;
                    employee.EmployeeUsername = textBoxUsername.Text;
                    employee.EmployeePassword = textBoxPassword.Text;
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    MessageBox.Show("Uspesno ste uneli radnika!");
                    ClearTextBox();


                }
                else
                {
                    MessageBox.Show("Vec postoji korisnik sa istim korisnickim imenom!");
                    ClearTextBox();
                }

            }
           
        }
        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxPhone.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxRole.Items.Clear();
            RefreshData();
        }

        private void RefreshData()
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            dataGridView1.DataSource = context.Employees.ToList();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            int idSelect = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString());
            Employee employee = context.Employees.Where(em => em.EmployeeID == idSelect).FirstOrDefault();
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                RefreshData();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBEContext context = new MOBILESTOREDBEContext();
            int idSelect = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString());
            Employee employee = context.Employees.Where(em => em.EmployeeID == idSelect).FirstOrDefault();
            if (employee != null)
            {
                employee.EmployeeName = dataGridView1.SelectedRows[0].Cells["EmployeeName"].Value.ToString();
                employee.EmployeeSurname = dataGridView1.SelectedRows[0].Cells["EmployeeSurname"].Value.ToString();
                employee.EmployeePhone = dataGridView1.SelectedRows[0].Cells["EmployeePhone"].Value.ToString();
                employee.EmployeeRole = dataGridView1.SelectedRows[0].Cells["EmployeeRole"].Value.ToString();
                //context.Employees.Remove(employee);
                context.SaveChanges();
                RefreshData();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
              if (dataGridView1.Columns[e.ColumnIndex].Name == "EmployeeRole")
            {
                string cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!comboBoxRole.Items.Contains(cellValue))
                {
                    MessageBox.Show("Dozvoljene vrijednosti su: " + string.Join(", ", comboBoxRole.Items.Cast<string>()));
                    dataGridView1.SelectedRows[0].Cells["EmployeeRole"].Value = "";
                    dataGridView1.CancelEdit();
                }
            }
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
