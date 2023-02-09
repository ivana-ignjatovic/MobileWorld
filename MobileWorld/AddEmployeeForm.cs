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
    public partial class AddEmployeeForm : Form
    {
        public string originalValue;
        public AddEmployeeForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeName = textBoxName.Text;
            employee.EmployeeSurname = textBoxSurname.Text;
            employee.EmployeeRole = comboBoxRole.SelectedItem.ToString();
            originalValue = employee.EmployeeRole;
            employee.EmployeePhone = textBoxPhone.Text;
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
            context.Employees.Add(employee);
            context.SaveChanges();
            RefreshData();
        }

        private void RefreshData()
        {
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
            dataGridView1.DataSource = context.Employees.ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
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
            MOBILESTOREDBContext context = new MOBILESTOREDBContext();
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

                // Provjeri da li je vrijednost ćelije u combo box-u
                if (!comboBoxRole.Items.Contains(cellValue))
                {
                    MessageBox.Show("Dozvoljene vrijednosti su: " + string.Join(", ", comboBoxRole.Items.Cast<string>()));
                    dataGridView1.SelectedRows[0].Cells["EmployeeRole"].Value = "";
                    dataGridView1.CancelEdit();
                }
            }
        }
    }
}
