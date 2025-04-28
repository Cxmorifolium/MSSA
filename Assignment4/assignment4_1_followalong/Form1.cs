using assignment4_1_followalong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_1_followalong
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Person> contacts;
        private BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();

            contacts = new Dictionary<string, Person>();

            var person1 = new Person()
            {
                FirstName = "Key",
                LastName = "Lime",
                MobilePhone = "+1-123-456-2343",
                WorkPhone = "+1-123-234-2323",
                Address = "Somewhere, Tropical, USA"
            };

            var person2 = new Person()
            {
                FirstName = "Buddha",
                LastName = "Finger",
                MobilePhone = "+1-123-456-2342",
                WorkPhone = "+1-123-234-2321",
                Address = "Somewhere, Tropical, USA"
            };

            var person3 = new Person()
            {
                FirstName = "Texas",
                LastName = "Grapefruit",
                MobilePhone = "+1-123-456-2342",
                WorkPhone = "+1-123-234-2321",
                Address = "Somewhere, Texas, USA"
            };

            var person4 = new Person()
            {
                FirstName = "Meyers",
                LastName = "Lemon",
                MobilePhone = "+1-123-456-2342",
                WorkPhone = "+1-123-234-2321",
                Address = "Somewhere, Hardy Enough to Grow this POS Fruit, USA"
            };

            contacts.Add(person1.GetFullName(), person1);
            contacts.Add(person2.GetFullName(), person2);
            contacts.Add(person3.GetFullName(), person3);
            contacts.Add(person4.GetFullName(), person4);

            bindingSource = new BindingSource();
            bindingSource.DataSource = contacts.Values.ToList();
            dataGridView1.DataSource = bindingSource;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string fullName = firstName + " " + lastName;

            if (contacts.TryGetValue(fullName, out Person person))
            {
                // Found the person, show only this person
                bindingSource.DataSource = new List<Person> { person };
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset
            bindingSource.DataSource = contacts.Values.ToList();

            // Clear search box
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

    }
}
