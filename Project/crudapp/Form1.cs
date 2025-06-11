using crudapp.models;
using crudapp.Service;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace crudapp
{
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empGrid.DataSource = crud.GetAllEmployees();
            empGrid.Columns["Department"].Visible = false;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;

            foreach (var item in crud.GetAllDepartment())
            {
                cbxDepartment.Items.Add(item.DepartmentName);
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtId.Text = (crud.GetMaxId() + 1).ToString();
            txtId.ReadOnly = true;
            txtName.Clear();
            txtSalary.Clear();
            btnSubmit.Enabled = true;
            cbxDepartment.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtName.Text))
            {
                if (cbxDepartment.SelectedIndex != -1)
                {
                    var newemp = new Employee
                    {
                        EmployeeId = int.Parse(txtId.Text),
                        Name = txtName.Text,
                        Salary = double.Parse(txtSalary.Text),
                        DepartmentId = cbxDepartment.SelectedIndex + 1
                    };

                    crud.AddEmployee(newemp);
                    MessageBox.Show("Employee added successfully!");

                }

            }
            btnSubmit.Enabled = false;
            empGrid.DataSource = crud.GetAllEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = empGrid.CurrentRow.Cells[0].Value;
            crud.DeleteEmployee((int)id);
            MessageBox.Show("Employee deleted successfully");
            empGrid.DataSource = crud.GetAllEmployees();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = empGrid.CurrentRow.Cells[0].Value;
            var emp = crud.FindEmployee((int)id);
            txtId.Text = emp.EmployeeId.ToString();
            txtId.ReadOnly = true;
            txtName.Text = emp.Name;
            txtSalary.Text = emp.Salary.ToString();
            cbxDepartment.SelectedIndex = emp.DepartmentId - 1;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var emptoupdate = crud.FindEmployee(id);
            emptoupdate.Name = txtName.Text;
            emptoupdate.Salary = double.Parse(txtSalary.Text);
            emptoupdate.DepartmentId = cbxDepartment.SelectedIndex + 1;
            crud.UpdateEmployee(id, emptoupdate);
            MessageBox.Show("Employee updated successfully!");
            btnUpdate.Enabled = false;
            empGrid.DataSource = crud.GetAllEmployees;
        }
    }
}
