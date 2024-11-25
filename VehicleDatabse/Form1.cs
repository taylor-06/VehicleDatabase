using System.Linq;

namespace VehicleDatabse
{
    public partial class Form1 : Form
    {
        List<Car> carsList = new List<Car>();
        List<Van> vansList = new List<Van>();

        public Form1()
        {
            InitializeComponent();
            infoArea.ReadOnly = true;
        }

        private void showInfo_btn_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            Van van = new Van();

            switch (carVan.Text == "Car")
            {
                case true:
                    switch (vehicleSelect.SelectedItem)
                    {
                        case "Car 1":
                            if (carsList.Count == 0)
                            {
                                infoArea.Text = "Car doesn't contain any data";
                                break;
                            }
                            else
                            {
                                car = carsList.ElementAt(0);
                                infoArea.Text = "Registration Number: " + car.registration + "\r\nWheels: " + car.wheels + "\r\nWeight (KG): " + car.weight + "\r\nPassengers: " + car.passengers;
                                break;
                            }

                        case "Car 2":
                            if (carsList.Count < 2)
                            {
                                infoArea.Text = "Car doesn't contain any data";
                                break;
                            }
                            else
                            {
                                car = carsList.ElementAt(1);
                                infoArea.Text = "Registration Number: " + car.registration + "\r\nWheels: " + car.wheels + "\r\nWeight (KG): " + car.weight + "\r\nPassengers: " + car.passengers;
                                break;
                            }

                        case "Car 3":
                            if (carsList.Count < 3)
                            {
                                infoArea.Text = "Car doesn't contain any data";
                                break;
                            }
                            else
                            {
                                car = carsList.ElementAt(2);
                                infoArea.Text = "Registration Number: " + car.registration + "\r\nWheels: " + car.wheels + "\r\nWeight (KG): " + car.weight + "\r\nPassengers: " + car.passengers;
                                break;
                            }

                        default:
                            infoArea.Text = "Error showing information";
                            break;
                    }
                    break;
                case false:
                    switch (vehicleSelect.SelectedItem)
                    {
                        case "Van 1":
                            if (vansList.Count == 0)
                            {
                                infoArea.Text = "Van doesn't contain any data";
                                break;
                            }
                            else
                            {
                                van = vansList.ElementAt(0);
                                van.vehicleNumber = vehicleSelect.Items.IndexOf("Van 1");
                                infoArea.Text = "Registration Number: " + van.registration + "\r\nWheels: " + van.wheels + "\r\nWeight (KG): " + van.weight + "\r\nHeight: " + van.height;
                                break;
                            }

                        case "Van 2":
                            if (vansList.Count < 2)
                            {
                                infoArea.Text = "Van doesn't contain any data";
                                break;
                            }
                            else
                            {
                                van = vansList.ElementAt(1);
                                van.vehicleNumber = vehicleSelect.Items.IndexOf("Van 2");
                                infoArea.Text = "Registration Number: " + van.registration + "\r\nWheels: " + van.wheels + "\r\nWeight (KG): " + van.weight + "\r\nHeight: " + van.height;
                                break;
                            }
                        case "Van 3":
                            if (vansList.Count < 3)
                            {
                                infoArea.Text = "Van doesn't contain any data";
                                break;
                            }
                            else
                            {
                                van = vansList.ElementAt(1);
                                van.vehicleNumber = vehicleSelect.Items.IndexOf("Van 3");
                                infoArea.Text = "Registration Number: " + van.registration + "\r\nWheels: " + van.wheels + "\r\nWeight (KG): " + van.weight + "\r\nHeight: " + van.height;
                                break;
                            }
                        default:
                            infoArea.Text = "Error showing information";
                            break;
                    }
                    break;
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {

            if (carVan.Text == "Car")
            {
                vehicleSelect.Items.Clear();

                vehicleSelect.Items.Add("Car 1");
                vehicleSelect.Items.Add("Car 2");
                vehicleSelect.Items.Add("Car 3");
            }
            else if (carVan.Text == "Van")
            {
                vehicleSelect.Items.Clear();

                vehicleSelect.Items.Add("Van 1");
                vehicleSelect.Items.Add("Van 2");
                vehicleSelect.Items.Add("Van 3");
            }
            else
            {
                infoArea.Text = "Error showing vehicles.";
            }
        }
        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            if (carVanAdd.SelectedItem == "Car" && carsList.Count >= 3 || carVanAdd.SelectedItem == "Van" && vansList.Count >= 3)
            {
                infoArea.Text = "The database is full of this vehicle type and therefore couldn't be added.";
                Console.WriteLine("database of vehicles is full, couldnt add vehicle");
            }
            else
            {
                AddVehicle();
                Console.WriteLine("added a vehicle to the database");
            }

        }

        private void AddVehicle()
        {
            Car car = new Car();
            Van van = new Van();

            if (carVanAdd.SelectedItem == "Car")
            {
                if (string.IsNullOrEmpty(regText.Text) || string.IsNullOrEmpty(wheelsText.Text) || string.IsNullOrEmpty(weightText.Text) || string.IsNullOrEmpty(passengersText.Text))
                {
                    infoArea.Text = "Please enter all the required information";
                    return;
                }
                else
                {
                    carsList.Add(car);
                    car.registration = regText.Text;
                    car.wheels = wheelsText.Text;
                    car.weight = double.Parse(weightText.Text);
                    car.passengers = int.Parse(passengersText.Text);
                    infoArea.Text = "Vehicle Information added to the Cars list";
                }
            }
            else if (carVanAdd.SelectedItem == "Van")
            {
                if (string.IsNullOrEmpty(regText.Text) || string.IsNullOrEmpty(wheelsText.Text) || string.IsNullOrEmpty(weightText.Text) || string.IsNullOrEmpty(passengersText.Text))
                {
                    infoArea.Text = "Please enter all the required information";
                    return;
                }
                else
                {
                    vansList.Add(van);
                    van.registration = regText.Text;
                    van.wheels = wheelsText.Text;
                    van.weight = double.Parse(weightText.Text);
                    van.height = double.Parse(heightText.Text);
                    van.vehicleNumber++;
                    infoArea.Text = "Vehicle Information added to the Vans list ";
                }
            }
            else
            {
                infoArea.Text = "Error adding vehicle";
            }
        }

        private void editVehicleBtn_Click(object sender, EventArgs e)
        {
            if (carVanEditRemove.Text == "Car")
            {
                switch (vehicleSelectEditRemove.SelectedItem)
                {
                    case "Car 1":
                        carsList.ElementAt(0).registration = regEditRemove.Text;
                        carsList.ElementAt(0).wheels = wheelsEditRemove.Text;
                        carsList.ElementAt(0).weight = Convert.ToDouble(weightEditRemove.Text);
                        carsList.ElementAt(0).passengers = Convert.ToInt32(passengersEditRemove.Text);
                        infoArea.Text = vehicleSelectEditRemove.SelectedItem.ToString() + " has been edited";
                        break;
                    case "Car 2":
                        carsList.ElementAt(1).registration = regEditRemove.Text;
                        carsList.ElementAt(1).wheels = wheelsEditRemove.Text;
                        carsList.ElementAt(1).weight = Convert.ToDouble(weightEditRemove.Text);
                        carsList.ElementAt(1).passengers = Convert.ToInt32(passengersEditRemove.Text);
                        infoArea.Text = vehicleSelectEditRemove.SelectedItem.ToString() + " has been edited";
                        break;
                    case "Car 3":
                        carsList.ElementAt(2).registration = regEditRemove.Text;
                        carsList.ElementAt(2).wheels = wheelsEditRemove.Text;
                        carsList.ElementAt(2).weight = Convert.ToDouble(weightEditRemove.Text);
                        carsList.ElementAt(2).passengers = Convert.ToInt32(passengersEditRemove.Text);
                        infoArea.Text = vehicleSelectEditRemove.SelectedItem.ToString() + " has been edited";
                        break;
                }
            }
            else if (carVanEditRemove.Text == "Van")
            {
                switch (vehicleSelectEditRemove.SelectedItem)
                {
                    case "Van 1":
                        vansList.ElementAt(0).registration = regEditRemove.Text;
                        vansList.ElementAt(0).wheels = wheelsEditRemove.Text;
                        vansList.ElementAt(0).weight = Convert.ToDouble(weightEditRemove.Text);
                        vansList.ElementAt(0).height = Convert.ToDouble(heightEditRemove.Text);
                        infoArea.Text = vehicleSelectEditRemove.SelectedItem.ToString() + " has been edited";
                        break;
                    case "Van 2":
                        vansList.ElementAt(1).registration = regEditRemove.Text;
                        vansList.ElementAt(1).wheels = wheelsEditRemove.Text;
                        vansList.ElementAt(1).weight = Convert.ToDouble(weightEditRemove.Text);
                        vansList.ElementAt(1).height = Convert.ToDouble(heightEditRemove.Text);
                        infoArea.Text = vehicleSelectEditRemove.SelectedItem.ToString() + " has been edited";
                        break;
                    case "Van 3":
                        vansList.ElementAt(2).registration = regEditRemove.Text;
                        vansList.ElementAt(2).wheels = wheelsEditRemove.Text;
                        vansList.ElementAt(2).weight = Convert.ToDouble(weightEditRemove.Text);
                        vansList.ElementAt(2).height = Convert.ToDouble(heightEditRemove.Text);
                        infoArea.Text = vehicleSelectEditRemove.SelectedItem.ToString() + " has been edited";
                        break;
                }
            }
        }

        private void removeVehicle_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            Van van = new Van();

            if (vehicleSelectEditRemove.Text == "")
            {
                infoArea.Text = "Select a vehicle to remove.";
                return;
            }
            else
            {
                switch (carVanEditRemove.Text == "Car")
                {
                    case true:
                        switch (vehicleSelectEditRemove.SelectedItem)
                        {
                            case "Car 1":
                                car = carsList.ElementAt(0);
                                carsList.Remove(carsList.ElementAt(0));
                                regEditRemove.Text = string.Empty;
                                wheelsEditRemove.Text = string.Empty;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                infoArea.Text = "Removed a car from the database";
                                break;
                            case "Car 2":
                                car = carsList.ElementAt(1);
                                carsList.Remove(carsList.ElementAt(1));
                                regEditRemove.Text = string.Empty;
                                wheelsEditRemove.Text = string.Empty;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                infoArea.Text = "Removed a car from the database";
                                break;
                            case "Car 3":
                                car = carsList.ElementAt(2);
                                carsList.Remove(carsList.ElementAt(2));
                                regEditRemove.Text = string.Empty;
                                wheelsEditRemove.Text = string.Empty;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                infoArea.Text = "Removed a car from the database";
                                break;
                        }
                        break;
                    case false:
                        switch (vehicleSelectEditRemove.SelectedItem)
                        {
                            case "Van 1":
                                van = vansList.ElementAt(0);
                                vansList.Remove(vansList.ElementAt(0));
                                regEditRemove.Text = string.Empty;
                                wheelsEditRemove.Text = string.Empty;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                infoArea.Text = "Removed a car from the database";
                                break;
                            case "Van 2":
                                van = vansList.ElementAt(1);
                                vansList.Remove(vansList.ElementAt(1));
                                regEditRemove.Text = string.Empty;
                                wheelsEditRemove.Text = string.Empty;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                infoArea.Text = "Removed a car from the database";
                                break;
                            case "Van 3":
                                van = vansList.ElementAt(2);
                                vansList.Remove(vansList.ElementAt(2));
                                regEditRemove.Text = string.Empty;
                                wheelsEditRemove.Text = string.Empty;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                infoArea.Text = "Removed a car from the database";
                                break;
                        }
                        break;
                }
            }
        }

        private void editRemoveSelectBtn_Click(object sender, EventArgs e)
        {

            if (carVanEditRemove.Text == "Car")
            {
                vehicleSelectEditRemove.Items.Clear();

                vehicleSelectEditRemove.Items.Add("Car 1");
                vehicleSelectEditRemove.Items.Add("Car 2");
                vehicleSelectEditRemove.Items.Add("Car 3");
            }
            else if (carVanEditRemove.Text == "Van")
            {
                vehicleSelectEditRemove.Items.Clear();

                vehicleSelectEditRemove.Items.Add("Van 1");
                vehicleSelectEditRemove.Items.Add("Van 2");
                vehicleSelectEditRemove.Items.Add("Van 3");
            }
            else
            {
                infoArea.Text = "Error showing vehicles.";
            }
        }

        private void infoEditRemoveBtn_Click(object sender, EventArgs e)
        {

            switch (carVanEditRemove.Text == "Car")
            {
                case true:
                    switch (vehicleSelectEditRemove.SelectedItem)
                    {
                        case "Car 1":
                            if (carsList.Count == 0)
                            {
                                infoArea.Text = "Car doesnt contain any data. Try adding data to this vehicle first instead";
                                regEditRemove.Text = null;
                                wheelsEditRemove.Text = null;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                break;
                            }
                            else
                            {
                                regEditRemove.Text = carsList.ElementAt(0).registration;
                                wheelsEditRemove.Text = carsList.ElementAt(0).wheels;
                                weightEditRemove.Text = carsList.ElementAt(0).weight.ToString();
                                passengersEditRemove.Text = carsList.ElementAt(0).passengers.ToString();
                                break;
                            }

                        case "Car 2":
                            if (carsList.Count != 2)
                            {
                                infoArea.Text = "Car doesnt contain any data. Try adding data to this vehicle first instead";
                                regEditRemove.Text = null;
                                wheelsEditRemove.Text = null;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                break;
                            }
                            else
                            {
                                regEditRemove.Text = carsList.ElementAt(1).registration;
                                wheelsEditRemove.Text = carsList.ElementAt(1).wheels;
                                weightEditRemove.Text = carsList.ElementAt(1).weight.ToString();
                                passengersEditRemove.Text = carsList.ElementAt(1).passengers.ToString();
                                break;
                            }

                        case "Car 3":
                            if (carsList.Count != 3)
                            {
                                infoArea.Text = "Car doesnt contain any data. Try adding data to this vehicle first instead";
                                regEditRemove.Text = null;
                                wheelsEditRemove.Text = null;
                                weightEditRemove.Text = null;
                                passengersEditRemove.Text = null;
                                break;
                            }
                            else
                            {
                                regEditRemove.Text = carsList.ElementAt(2).registration;
                                wheelsEditRemove.Text = carsList.ElementAt(2).wheels;
                                weightEditRemove.Text = carsList.ElementAt(2).weight.ToString();
                                passengersEditRemove.Text = carsList.ElementAt(2).passengers.ToString();
                                break;
                            }

                    }
                    break;
                case false:
                    switch (vehicleSelectEditRemove.SelectedItem)
                    {
                        case "Van 1":
                            if (vansList.Count == 0)
                            {
                                infoArea.Text = "Van doesnt contain any data. Try adding data to this vehicle first instead";
                                regEditRemove.Text = null;
                                wheelsEditRemove.Text = null;
                                weightEditRemove.Text = null;
                                heightEditRemove.Text = null;
                                break;
                            }
                            else
                            {
                                regEditRemove.Text = vansList.ElementAt(0).registration;
                                wheelsEditRemove.Text = vansList.ElementAt(0).wheels;
                                weightEditRemove.Text = vansList.ElementAt(0).weight.ToString();
                                heightEditRemove.Text = vansList.ElementAt(0).height.ToString();
                                break;
                            }

                        case "Van 2":
                            if (vansList.Count != 2)
                            {
                                infoArea.Text = "Van doesnt contain any data. Try adding data to this vehicle first instead";
                                regEditRemove.Text = null;
                                wheelsEditRemove.Text = null;
                                weightEditRemove.Text = null;
                                heightEditRemove.Text = null;
                                break;
                            }
                            else
                            {
                                regEditRemove.Text = vansList.ElementAt(1).registration;
                                wheelsEditRemove.Text = vansList.ElementAt(1).wheels;
                                weightEditRemove.Text = vansList.ElementAt(1).weight.ToString();
                                heightEditRemove.Text = vansList.ElementAt(1).height.ToString();
                                break;
                            }

                        case "Van 3":
                            if (vansList.Count != 3)
                            {
                                infoArea.Text = "Van doesnt contain any data. Try adding data to this vehicle first instead";
                                regEditRemove.Text = null;
                                wheelsEditRemove.Text = null;
                                weightEditRemove.Text = null;
                                heightEditRemove.Text = null;
                                break;
                            }
                            else
                            {
                                regEditRemove.Text = vansList.ElementAt(2).registration;
                                wheelsEditRemove.Text = vansList.ElementAt(2).wheels;
                                weightEditRemove.Text = vansList.ElementAt(2).weight.ToString();
                                heightEditRemove.Text = vansList.ElementAt(2).height.ToString();
                                break;
                            }
                    }
                    break;
            }
        }
    }
}