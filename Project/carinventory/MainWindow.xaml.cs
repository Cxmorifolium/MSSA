using carinventory.Data;
using carinventory.Model;
using carinventory.Service;
using System.Windows;
using System.Windows.Controls;

namespace carinventory
{
    public partial class MainWindow : Window
    {
        private CarCRUD carCrud;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize database (like your employee example)
            Records.carContext.Database.EnsureCreated();

            carCrud = new CarCRUD();
            LoadAllCars();
        }

        private void LoadAllCars()
        {
            carGrid.ItemsSource = carCrud.GetAllCars();
            txtCarId.Text = carCrud.GetNextId().ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    var car = new Car
                    {
                        VehicleMake = txtMake.Text.Trim(),
                        VehicleModel = txtModel.Text.Trim(),
                        VehicleYear = int.Parse(txtYear.Text),
                        VehiclePrice = float.Parse(txtPrice.Text)
                    };

                    carCrud.AddCar(car);
                    MessageBox.Show("Car added successfully!");
                    LoadAllCars();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCarId.Text) || txtCarId.Text == "0")
                {
                    MessageBox.Show("Please select a car to update.");
                    return;
                }

                if (ValidateInput())
                {
                    var car = new Car
                    {
                        VehicleMake = txtMake.Text.Trim(),
                        VehicleModel = txtModel.Text.Trim(),
                        VehicleYear = int.Parse(txtYear.Text),
                        VehiclePrice = float.Parse(txtPrice.Text)
                    };

                    int carId = int.Parse(txtCarId.Text);
                    carCrud.UpdateCar(carId, car);
                    MessageBox.Show("Car updated successfully!");
                    LoadAllCars();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating car: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCarId.Text) || txtCarId.Text == "0")
                {
                    MessageBox.Show("Please select a car to delete.");
                    return;
                }

                var result = MessageBox.Show($"Are you sure you want to delete this car?",
                    "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    int carId = int.Parse(txtCarId.Text);
                    carCrud.DeleteCar(carId);
                    MessageBox.Show("Car deleted successfully!");
                    LoadAllCars();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting car: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearInputFields();
            carGrid.SelectedItem = null;
        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            // Clear all search boxes
            txtSearchMake.Text = "";
            txtSearchModel.Text = "";
            txtSearchYear.Text = "";
            txtSearchPrice.Text = "";

            // Show all cars
            LoadAllCars();
        }

        private void carGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (carGrid.SelectedItem is Car selectedCar)
            {
                txtCarId.Text = selectedCar.CarId.ToString();
                txtMake.Text = selectedCar.VehicleMake ?? "";
                txtModel.Text = selectedCar.VehicleModel ?? "";
                txtYear.Text = selectedCar.VehicleYear.ToString();
                txtPrice.Text = selectedCar.VehiclePrice.ToString("F2");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                MessageBox.Show("Please enter a vehicle make.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Please enter a vehicle model.");
                return false;
            }

            if (!int.TryParse(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 2)
            {
                MessageBox.Show($"Please enter a valid year between 1900 and {DateTime.Now.Year + 2}.");
                return false;
            }

            if (!float.TryParse(txtPrice.Text, out float price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            txtCarId.Text = carCrud.GetNextId().ToString();
            txtMake.Text = "";
            txtModel.Text = "";
            txtYear.Text = "";
            txtPrice.Text = "";
        }

        // Search methods
        private void txtSearchMake_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearchModel_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearchYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearchPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            try
            {
                var allCars = carCrud.GetAllCars();
                var filteredCars = allCars.AsEnumerable();

                // Filter by Make
                if (!string.IsNullOrEmpty(txtSearchMake.Text))
                {
                    string makeFilter = txtSearchMake.Text.ToLower();
                    filteredCars = filteredCars.Where(c =>
                        c.VehicleMake != null && c.VehicleMake.ToLower().Contains(makeFilter));
                }

                // Filter by Model
                if (!string.IsNullOrEmpty(txtSearchModel.Text))
                {
                    string modelFilter = txtSearchModel.Text.ToLower();
                    filteredCars = filteredCars.Where(c =>
                        c.VehicleModel != null && c.VehicleModel.ToLower().Contains(modelFilter));
                }

                // Filter by Year
                if (!string.IsNullOrEmpty(txtSearchYear.Text))
                {
                    if (int.TryParse(txtSearchYear.Text, out int yearFilter))
                    {
                        filteredCars = filteredCars.Where(c => c.VehicleYear == yearFilter);
                    }
                }

                // Filter by Price within a range
                if (!string.IsNullOrEmpty(txtSearchPrice.Text))
                {
                    if (float.TryParse(txtSearchPrice.Text, out float priceFilter))
                    {
                        // Show cars within $5000 of entered price
                        filteredCars = filteredCars.Where(c =>
                            Math.Abs(c.VehiclePrice - priceFilter) <= 5000);
                    }
                }

                carGrid.ItemsSource = filteredCars.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering: {ex.Message}");
            }
        }
    }
}