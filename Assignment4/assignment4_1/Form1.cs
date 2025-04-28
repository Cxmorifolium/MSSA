using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_1
{
    public partial class Form1 : Form
    {
        private AddressBook addressBook = new AddressBook();
        private BindingList<Person> bindingList;

        public Form1()
        {
            InitializeComponent();

            addressBook = new AddressBook();
            addressBook.LoadFromFile();

            // Build the binding list from AddressBook
            bindingList = new BindingList<Person>(addressBook.GetAllPeople().ToList());
            addressGrid.DataSource = bindingList;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Clear and re-sync AddressBook in case on grid edits
            addressBook.ClearPeople();

            foreach (var person in bindingList)
            {
                addressBook.AddPerson(person.FirstName, person.LastName, person.MobilePhone, person.WorkPhone, person.Address);
            }

            // Save to file
            addressBook.SaveToFile();
            MessageBox.Show("Address book saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addressBook.AddPerson(txtFirstName.Text, txtLastName.Text, txtMobilePhone.Text, txtWorkPhone.Text, txtAddress.Text);

            // Refresh the binding list
            bindingList = new BindingList<Person>(addressBook.GetAllPeople().ToList());
            addressGrid.DataSource = bindingList;

            // Save to file immediately 
            addressBook.SaveToFile();

            // Clear input boxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMobilePhone.Clear();
            txtWorkPhone.Clear();
            txtAddress.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filter the data dynamically
            var filteredPeople = addressBook.GetAllPeople()
                .Where(p => p.FirstName.ToLower().Contains(searchTerm)
                         || p.LastName.ToLower().Contains(searchTerm)
                         || p.MobilePhone.ToLower().Contains(searchTerm)
                         || p.WorkPhone.ToLower().Contains(searchTerm)
                         || p.Address.ToLower().Contains(searchTerm))
                .ToList();

            // Show only matching people
            BindingList<Person> searchResult = new BindingList<Person>(filteredPeople);
            addressGrid.DataSource = searchResult;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reload list
            bindingList = new BindingList<Person>(addressBook.GetAllPeople().ToList());

            // Reset the data source of the DataGridView
            addressGrid.DataSource = bindingList;

            // Clear any search/input fields
            txtSearch.Clear();
        }

    }
}
