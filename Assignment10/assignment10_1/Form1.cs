using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment10_1
{
    public partial class Form1 : Form
    {
        private BindingList<Student> students = new BindingList<Student>();
        private Serialization serialization = new Serialization();

        // File paths
        private string jsonFilePath = @"C:\Users\lemon\OneDrive\Documents\CsharpProjects\MSSA\Assignment10\assignment10_1\students.json";
        private string xmlFilePath = @"C:\Users\lemon\OneDrive\Documents\CsharpProjects\MSSA\Assignment10\assignment10_1\students.xml";

        public Form1()
        {
            InitializeComponent();
            ConfigureDataGrid();
            InitializeStudentData();
        }

        private void ConfigureDataGrid()
        {
            // Configure DataGridView properties
            studentGrid.AutoGenerateColumns = true;
            studentGrid.AllowUserToAddRows = false;
            studentGrid.AllowUserToDeleteRows = true;
            studentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentGrid.MultiSelect = false;
        }

        private void InitializeStudentData()
        {
            // Initialize with default data
            students.Add(new Student("John Doe", 20, "Computer Science", 1001));
            students.Add(new Student("Jane Smith", 22, "Mathematics", 1002));
            students.Add(new Student("Bob Johnson", 19, "Physics", 1003));

            // Bind to DataGridView
            studentGrid.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Student newStudent = new Student(
                    txtName.Text.Trim(),
                    int.Parse(txtAge.Text.Trim()),
                    txtMajor.Text.Trim(),
                    int.Parse(txtStudentID.Text.Trim())
                );

                students.Add(newStudent);

                // Clear input fields
                ClearInputFields();

                MessageBox.Show("Student added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Convert BindingList to List for serialization
            var studentList = students.ToList();

            // Save to both JSON and XML formats
            serialization.SerializeToJson(studentList, jsonFilePath);
            serialization.SerializeToXml(studentList, xmlFilePath);

            MessageBox.Show($"Students saved to both formats!\nJSON: {jsonFilePath}\nXML: {xmlFilePath}",
                "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            var loadedStudents = serialization.DeserializeFromJson(jsonFilePath);
            students.Clear();
            foreach (var student in loadedStudents)
            {
                students.Add(student);
            }
            MessageBox.Show("Students loaded from JSON!", "JSON Load",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            var loadedStudents = serialization.DeserializeFromXml(xmlFilePath);
            students.Clear();
            foreach (var student in loadedStudents)
            {
                students.Add(student);
            }
            MessageBox.Show("Students loaded from XML!", "XML Load",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            students.Clear();
            MessageBox.Show("All students cleared!", "Clear",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a student name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text) || !int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age (positive number).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMajor.Text))
            {
                MessageBox.Show("Please enter a major.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMajor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || !int.TryParse(txtStudentID.Text, out int studentID) || studentID <= 0)
            {
                MessageBox.Show("Please enter a valid Student ID (positive number).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return false;
            }

            // Check for duplicate Student ID
            if (students.Any(s => s.StudentID == int.Parse(txtStudentID.Text)))
            {
                MessageBox.Show("Student ID already exists. Please enter a unique ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            txtName.Clear();
            txtAge.Clear();
            txtMajor.Clear();
            txtStudentID.Clear();
            txtName.Focus();
        }
    }
}