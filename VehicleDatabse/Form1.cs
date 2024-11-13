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
                            if (carsList.Count != 2)
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
                            if (carsList.Count != 3)
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
                            if (vansList.Count != 2)
                            {
                                infoArea.Text = "Van doesn't contain any data";
                                break;
                            }
                            else
                            {
                                van = vansList.ElementAt(0);
                                van.vehicleNumber = vehicleSelect.Items.IndexOf("Van 2");
                                infoArea.Text = "Registration Number: " + van.registration + "\r\nWheels: " + van.wheels + "\r\nWeight (KG): " + van.weight + "\r\nHeight: " + van.height;
                                break;
                            }
                        case "Van 3":
                            if (vansList.Count != 3)
                            {
                                infoArea.Text = "Van doesn't contain any data";
                                break;
                            }
                            else
                            {
                                van = vansList.ElementAt(0);
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
                car.registration = regText.Text;
                car.wheels = wheelsText.Text;
                car.weight = double.Parse(weightText.Text);
                car.passengers = int.Parse(passengersText.Text);
                carsList.Add(car);
                infoArea.Text = "Vehicle Information added to the Cars list";
            }
            else if (carVanAdd.SelectedItem == "Van")
            {
                van.registration = regText.Text;
                van.wheels = wheelsText.Text;
                van.weight = double.Parse(weightText.Text);
                van.height = int.Parse(heightText.Text);
                van.vehicleNumber++;
                vansList.Add(van);
                infoArea.Text = "Vehicle Information added to the Vans list ";

                // add error check for missing datas
            }
            else
            {
                infoArea.Text = "Error adding vehicle";
            }
        }
    }
}