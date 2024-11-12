namespace VehicleDatabse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            carVan = new ComboBox();
            label1 = new Label();
            infoArea = new TextBox();
            showInfo_btn = new Button();
            selectA = new Label();
            vehicleSelect = new ComboBox();
            selectBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            carVanAdd = new ComboBox();
            label4 = new Label();
            regText = new TextBox();
            wheelsText = new TextBox();
            label5 = new Label();
            weightText = new TextBox();
            label6 = new Label();
            passengersText = new TextBox();
            label7 = new Label();
            heightText = new TextBox();
            label8 = new Label();
            addVehicleBtn = new Button();
            SuspendLayout();
            // 
            // carVan
            // 
            carVan.DropDownStyle = ComboBoxStyle.DropDownList;
            carVan.FormattingEnabled = true;
            carVan.Items.AddRange(new object[] { "Car", "Van" });
            carVan.Location = new Point(106, 63);
            carVan.Name = "carVan";
            carVan.Size = new Size(121, 23);
            carVan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 45);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Car or Van?";
            // 
            // infoArea
            // 
            infoArea.Location = new Point(55, 240);
            infoArea.Multiline = true;
            infoArea.Name = "infoArea";
            infoArea.Size = new Size(219, 163);
            infoArea.TabIndex = 2;
            // 
            // showInfo_btn
            // 
            showInfo_btn.Location = new Point(106, 187);
            showInfo_btn.Name = "showInfo_btn";
            showInfo_btn.Size = new Size(121, 37);
            showInfo_btn.TabIndex = 3;
            showInfo_btn.Text = "Show Information";
            showInfo_btn.UseVisualStyleBackColor = true;
            showInfo_btn.Click += showInfo_btn_Click;
            // 
            // selectA
            // 
            selectA.AutoSize = true;
            selectA.Location = new Point(124, 140);
            selectA.Name = "selectA";
            selectA.Size = new Size(87, 15);
            selectA.TabIndex = 5;
            selectA.Text = "Select a Vehicle";
            // 
            // vehicleSelect
            // 
            vehicleSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleSelect.FormattingEnabled = true;
            vehicleSelect.Location = new Point(106, 158);
            vehicleSelect.MaxDropDownItems = 3;
            vehicleSelect.Name = "vehicleSelect";
            vehicleSelect.Size = new Size(121, 23);
            vehicleSelect.TabIndex = 4;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(123, 92);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(93, 29);
            selectBtn.TabIndex = 6;
            selectBtn.Text = "Select";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 40);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 7;
            label2.Text = "Add New Vehicles:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 68);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Car or Van?";
            // 
            // carVanAdd
            // 
            carVanAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            carVanAdd.FormattingEnabled = true;
            carVanAdd.Items.AddRange(new object[] { "Car", "Van" });
            carVanAdd.Location = new Point(431, 65);
            carVanAdd.Name = "carVanAdd";
            carVanAdd.Size = new Size(121, 23);
            carVanAdd.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 96);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 11;
            label4.Text = "Registration Number";
            // 
            // regText
            // 
            regText.Location = new Point(482, 93);
            regText.Multiline = true;
            regText.Name = "regText";
            regText.Size = new Size(121, 23);
            regText.TabIndex = 12;
            // 
            // wheelsText
            // 
            wheelsText.Location = new Point(457, 122);
            wheelsText.Multiline = true;
            wheelsText.Name = "wheelsText";
            wheelsText.Size = new Size(121, 23);
            wheelsText.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 125);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 13;
            label5.Text = "Wheels Number";
            // 
            // weightText
            // 
            weightText.Location = new Point(435, 153);
            weightText.Multiline = true;
            weightText.Name = "weightText";
            weightText.Size = new Size(121, 23);
            weightText.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(359, 156);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 15;
            label6.Text = "Weight (KG)";
            // 
            // passengersText
            // 
            passengersText.Location = new Point(464, 182);
            passengersText.Multiline = true;
            passengersText.Name = "passengersText";
            passengersText.Size = new Size(121, 23);
            passengersText.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(359, 185);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 17;
            label7.Text = "Passengers (Cars)";
            // 
            // heightText
            // 
            heightText.Location = new Point(443, 211);
            heightText.Multiline = true;
            heightText.Name = "heightText";
            heightText.Size = new Size(121, 23);
            heightText.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(359, 214);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 19;
            label8.Text = "Height (Vans)";
            // 
            // addVehicleBtn
            // 
            addVehicleBtn.Location = new Point(359, 240);
            addVehicleBtn.Name = "addVehicleBtn";
            addVehicleBtn.Size = new Size(121, 37);
            addVehicleBtn.TabIndex = 21;
            addVehicleBtn.Text = "Add Vehicle";
            addVehicleBtn.UseVisualStyleBackColor = true;
            addVehicleBtn.Click += addVehicleBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(addVehicleBtn);
            Controls.Add(heightText);
            Controls.Add(label8);
            Controls.Add(passengersText);
            Controls.Add(label7);
            Controls.Add(weightText);
            Controls.Add(label6);
            Controls.Add(wheelsText);
            Controls.Add(label5);
            Controls.Add(regText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(carVanAdd);
            Controls.Add(label2);
            Controls.Add(selectBtn);
            Controls.Add(selectA);
            Controls.Add(vehicleSelect);
            Controls.Add(showInfo_btn);
            Controls.Add(infoArea);
            Controls.Add(label1);
            Controls.Add(carVan);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox carVan;
        private Label label1;
        private TextBox infoArea;
        private Button showInfo_btn;
        private Label selectA;
        private ComboBox vehicleSelect;
        private Button selectBtn;
        private Label label2;
        private Label label3;
        private ComboBox carVanAdd;
        private Label label4;
        private TextBox regText;
        private TextBox wheelsText;
        private Label label5;
        private TextBox weightText;
        private Label label6;
        private TextBox passengersText;
        private Label label7;
        private TextBox heightText;
        private Label label8;
        private Button addVehicleBtn;
    }
}