namespace VehicleDatabse
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void showInfo_btn_Click(object sender, EventArgs e)
        {
            if (carVan.Text == "Car")
            {
                vehicleSelect.Hide();
            }
            else if (carVan.Text == "Van")
            {

            }
            else
            {
                infoArea.Text = "Error";
            }
        }
    }
}