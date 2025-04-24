using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static assignment3_4.Coffee;

namespace assignment3_4
{
    public partial class Form1 : Form
    {
        private BindingList<Coffee> coffeeBindingList;
        private ContextMenuStrip contextMenu;
        public Form1()
        {
            InitializeComponent();
            InitializeCoffeeList();
            SetupContextMenu();
            BindData();

        }

        private void InitializeCoffeeList()
        {
            coffeeBindingList = new BindingList<Coffee>
            {
                new Coffee("Caffè Americano", 2.95, false, "Arabica", Roast.Medium, true, "Starbucks"),
                new Coffee("Caffè Latte", 3.65, false, "Arabica", Roast.Medium, true, "Starbucks"),
                new Coffee("Cappuccino", 3.75, false, "Arabica", Roast.Medium, true, "Starbucks"),
                new Coffee("Caramel Macchiato", 4.25, false, "Arabica", Roast.Medium, true, "Starbucks"),
                new Coffee("Decaf Pike Place", 2.95, true, "Arabica", Roast.Medium, true, "Starbucks"),
                new Coffee("Iced Coffee", 2.95, false, "Arabica", Roast.Medium, false, "Starbucks"),
                new Coffee("Iced Americano", 3.25, false, "Arabica", Roast.Medium, false, "Starbucks"),
                new Coffee("Iced Caffè Latte", 3.95, false, "Arabica", Roast.Medium, false, "Starbucks"),
                new Coffee("Iced Caramel Macchiato", 4.45, false, "Arabica", Roast.Medium, false, "Starbucks"),
                new Coffee("Iced Decaf Coffee", 2.95, true, "Arabica", Roast.Medium, false, "Starbucks")
            };
        }

        private void BindData()
        {
            dataGridView1.DataSource = null; // Unbind
            dataGridView1.DataSource = new BindingSource { DataSource = coffeeBindingList };

            // Setting GridView Aesthetics 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Hiding Unnecessary Columns
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;

            // Renaming Columns
            this.dataGridView1.Columns[2].HeaderText = "Roast Lvl";
            this.dataGridView1.Columns[4].HeaderText = "Name";
            this.dataGridView1.Columns[5].HeaderText = "Hot/Cold";
            this.dataGridView1.Columns[0].HeaderText = "Decaf?";

            // Reorganizing Columns
            this.dataGridView1.Columns[7].DisplayIndex = 1;
            this.dataGridView1.Columns[4].DisplayIndex = 2;
            this.dataGridView1.Columns[6].DisplayIndex= 3;
            this.dataGridView1.Columns[0].DisplayIndex = 4;
            this.dataGridView1.Columns[5].DisplayIndex = 8;

            // User Updates
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = true;
        }

        // Adding Add/Remove Row Function
        private void SetupContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Add Row", null, AddRow_Click);
            contextMenu.Items.Add("Delete Row", null, DeleteRow_Click);
            dataGridView1.ContextMenuStrip = contextMenu;
        }
        private void AddRow_Click(object sender, EventArgs e)
        {
            // Default data
            coffeeBindingList.Add(new Coffee("New Coffee", 0.0, false, "Arabica", Coffee.Roast.Medium, true, "Brand"));
            BindData();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0 && index < coffeeBindingList.Count)
                {
                    coffeeBindingList.RemoveAt(index);
                    BindData();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
