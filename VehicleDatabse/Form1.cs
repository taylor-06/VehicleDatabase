namespace VehicleDatabse
{
    public partial class Form1 : Form
    {
        Car car = new Car();
        Van van = new Van();

        List<Car> carsList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            infoArea.ReadOnly = true;
        }

        private void showInfo_btn_Click(object sender, EventArgs e)
        {
            Car car = new Car();

            switch (carVan.Text == "Car")
            {
                case true:
                    switch (vehicleSelect.SelectedItem)
                    {
                        case "Car 1":
                            car = carsList.ElementAt(0);
                            car.vehicleNumber = vehicleSelect.Items.IndexOf("Car 1");
                            infoArea.Text = "Registration Number: " + car.registration + "\r\nWheels: " + car.wheels + "\r\nWeight (KG): " + car.weight + "\r\nPassengers: " + car.passengers;
                            break;
                        case "Car 2":
                            car = carsList.ElementAt(1);
                            car.vehicleNumber = vehicleSelect.Items.IndexOf("Car 2");
                            infoArea.Text = "Registration Number: " + car.registration + "\r\nWheels: " + car.wheels + "\r\nWeight (KG): " + car.weight + "\r\nPassengers: " + car.passengers;
                            break;
                        case "Car 3":
                            car = carsList.ElementAt(2);
                            car.vehicleNumber = vehicleSelect.Items.IndexOf("Car 3");
                            infoArea.Text = "Registration Number: " + car.registration + "\r\nWheels: " + car.wheels + "\r\nWeight (KG): " + car.weight + "\r\nPassengers: " + car.passengers;
                            break;
                        default:
                            infoArea.Text = "Error showing information";
                            break;
                    }
                    break;
                case false:
                    switch (vehicleSelect.SelectedItem)
                    {
                        case "Van 1":
                            infoArea.Text = "Registration Number: " + van.registration + "\r\nWheels: " + van.wheels + "\r\nWeight (KG): " + van.weight + "\r\nHeight: " + van.height;
                            break;
                        case "Van 2":
                            infoArea.Text = "Registration Number: " + van.registration + "\r\nWheels: " + van.wheels + "\r\nWeight (KG): " + van.weight + "\r\nHeight: " + van.height;
                            break;
                        case "Van 3":
                            infoArea.Text = "Registration Number: " + van.registration + "\r\nWheels: " + van.wheels + "\r\nWeight (KG): " + van.weight + "\r\nHeight: " + van.height;
                            break;
                        default:
                            infoArea.Text = "Error showing information";
                            break;
                    }
                    break;
            }

            Console.WriteLine(car.vehicleNumber);
            Console.WriteLine(carsList.Count());
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

            switch (car.vehicleNumber)
            {
                case 1:
                    //vehicleSelect.Items.Equals("Car 1");
                    //carsList.ElementAt(0);

                    //carsList.ElementAt(0) == vehicleSelect.Items.IndexOf("Car 1")

                    if (vehicleSelect.Items.Equals("Car 1")/* && car.vehicleNumber == vehicleSelect.Items.IndexOf("Car 1")*/)
                    {
                        car = carsList.ElementAt(0);
                        Console.WriteLine(car.vehicleNumber);
                        Console.WriteLine(carsList.ElementAt(0));
                    }
                    break;
                case 2:
                    if (vehicleSelect.Items.Equals("Car 2")/* && car.vehicleNumber == vehicleSelect.Items.IndexOf("Car 2")*/)
                    {
                        car = carsList.ElementAt(1);
                        Console.WriteLine(car.vehicleNumber);
                        Console.WriteLine(carsList.ElementAt(0));
                    }
                    break;
                    //vehicleSelect.Items.Equals("Car 2");
                    //carsList.ElementAt(1);
                    // break;
            }
        }
        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicle()
        {
            if (carVanAdd.SelectedItem == "Car")
            {
                car.registration = regText.Text;
                car.wheels = wheelsText.Text;
                car.weight = double.Parse(weightText.Text);
                car.passengers = int.Parse(passengersText.Text);
                car.vehicleNumber++;
                carsList.Add(car);
            }
        }
    }
}