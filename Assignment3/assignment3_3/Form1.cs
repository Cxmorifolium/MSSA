using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static assignment3_3.Student;

namespace assignment3_3
{
    public partial class Form1 : Form
    {
        // Coudln't get it to load in the basic path string format cus it loads from bin
        private string FilePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName,
        "student.json");

        public Form1()
        {
            InitializeComponent();
            // //Debugging filepath
            //MessageBox.Show($"File path: {FilePath}");
            cmbMonthOfAdmission.DataSource = Enum.GetValues(typeof(Months)); // drop down menu for month of admin
            
            // Wiring click/key input
            DataGridViewStudents.KeyDown += DataGridViewStudents_KeyDown; // Press del key to delete for ex
            DataGridViewStudents.MouseDown += DataGridViewStudents_MouseDown; // When clicking outside of current row
            DataGridViewStudents.Leave += DataGridViewStudents_Leave; // When clicking out of the grid
            DataGridViewStudents.StandardTab = false; // Allow Tab to move between cells
            DataGridViewStudents.MultiSelect = false; // Single cell to cell navigation
            DataGridViewStudents.KeyPress += DataGridViewStudents_KeyPress; // Actually tabbing

            // Hard-Coded because designer wasn't wiring for whateve reason
            DataGridViewStudents.CellDoubleClick += DataGridViewStudents_CellDoubleClick;
            DataGridViewStudents.CellEndEdit += DataGridViewStudents_CellEndEdit;
            DataGridViewStudents.CellValueChanged += DataGridViewStudents_CellValueChanged;

            this.MouseClick += Form1_MouseClick;
            this.Load += Form1_Load;

        }

        private List<Student> LoadStudentsFromJson()
        {
            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Student data file not found.");
                return new List<Student>();
            }

            var jsonData = File.ReadAllText(FilePath);
            var students = JsonConvert.DeserializeObject<List<Student>>(jsonData); // convert .json data to usable object
            return students ?? new List<Student>();
        }

        private BindingList<Student> studentList;

        private void Form1_Load(object sender, EventArgs e) 
        {
            // Binding .JSON to Grid
            studentList = new BindingList<Student>(LoadStudentsFromJson());
            DataGridViewStudents.DataSource = studentList; // Load existing student data into datagrid

            // Adjust view here (these aren't in designer)
            DataGridViewStudents.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewStudents.ClearSelection();
            DataGridViewStudents.ReadOnly = true;
        }

        // Save back to Json
        private void SaveStudentsToJson()
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(studentList.ToList(), Formatting.Indented);
                File.WriteAllText(FilePath, jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving student data: {ex.Message}");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newStudent = new Student
                {
                    StudentId = int.Parse(txtStudentId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    MonthOfAdmission = (Months)cmbMonthOfAdmission.SelectedItem,
                    Grade = txtGrade.Text
                };

                // Add to the list
                studentList.Add(newStudent);

                // Save to JSON file
                SaveStudentsToJson();

                // Clear after entry
                txtStudentId.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtGrade.Clear();
                cmbMonthOfAdmission.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}");
            }
        }

        private void DataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Temporarily allow editing
                DataGridViewStudents.ReadOnly = false;
                DataGridViewStudents.BeginEdit(true);
            }

        }

        // To tab edit
        private void DataGridViewStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if currently on a cell that could be edited
            if (DataGridViewStudents.CurrentCell != null)
            {
                // If Tab or Enter is pressed, go into edit mode
                if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
                {
                    DataGridViewStudents.ReadOnly = false;
                    DataGridViewStudents.BeginEdit(true);
                }
            }
        }

        private void DataGridViewStudents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Lock it back to read-only
            DataGridViewStudents.ReadOnly = true;
        }

        private void DataGridViewStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewStudents.EndEdit();
                SaveStudentsToJson();
            }
        }

        // Click any row below to clear selection
        private void DataGridViewStudents_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DataGridViewStudents.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                DataGridViewStudents.ClearSelection();
            }
        }

        // When clicking to a different input it deselect
        private void DataGridViewStudents_Leave(object sender, EventArgs e)
        {
            DataGridViewStudents.ClearSelection();
        }

        // When clicking elsewhere aside from datagrid, deselect
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!DataGridViewStudents.Bounds.Contains(e.Location))
            {
                DataGridViewStudents.ClearSelection();
            }
        }


        // Setting key input to delete rows
        private void DataGridViewStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if (DataGridViewStudents.CurrentRow != null && !DataGridViewStudents.CurrentRow.IsNewRow)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Student selectedStudent = (Student)DataGridViewStudents.CurrentRow.DataBoundItem;
                        studentList.Remove(selectedStudent);

                        // Refresh DataGridView
                        DataGridViewStudents.DataSource = null;
                        DataGridViewStudents.DataSource = studentList;

                        SaveStudentsToJson();
                    }

                    e.Handled = true;
                }
            }
        }

    }
}
