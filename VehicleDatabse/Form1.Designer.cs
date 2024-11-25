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
            editVehicleBtn = new Button();
            heightEditRemove = new TextBox();
            label9 = new Label();
            passengersEditRemove = new TextBox();
            label10 = new Label();
            weightEditRemove = new TextBox();
            label11 = new Label();
            wheelsEditRemove = new TextBox();
            label12 = new Label();
            regEditRemove = new TextBox();
            label13 = new Label();
            label14 = new Label();
            carVanEditRemove = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            vehicleSelectEditRemove = new ComboBox();
            removeVehicle = new Button();
            editRemoveSelectBtn = new Button();
            infoEditRemoveBtn = new Button();
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
            // editVehicleBtn
            // 
            editVehicleBtn.Location = new Point(673, 334);
            editVehicleBtn.Name = "editVehicleBtn";
            editVehicleBtn.Size = new Size(121, 37);
            editVehicleBtn.TabIndex = 35;
            editVehicleBtn.Text = "Edit Vehicle";
            editVehicleBtn.UseVisualStyleBackColor = true;
            editVehicleBtn.Click += editVehicleBtn_Click;
            // 
            // heightEditRemove
            // 
            heightEditRemove.Location = new Point(757, 305);
            heightEditRemove.Multiline = true;
            heightEditRemove.Name = "heightEditRemove";
            heightEditRemove.Size = new Size(121, 23);
            heightEditRemove.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(673, 308);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 33;
            label9.Text = "Height (Vans)";
            // 
            // passengersEditRemove
            // 
            passengersEditRemove.Location = new Point(778, 276);
            passengersEditRemove.Multiline = true;
            passengersEditRemove.Name = "passengersEditRemove";
            passengersEditRemove.Size = new Size(121, 23);
            passengersEditRemove.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(673, 279);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 31;
            label10.Text = "Passengers (Cars)";
            // 
            // weightEditRemove
            // 
            weightEditRemove.Location = new Point(749, 247);
            weightEditRemove.Multiline = true;
            weightEditRemove.Name = "weightEditRemove";
            weightEditRemove.Size = new Size(121, 23);
            weightEditRemove.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(673, 250);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 29;
            label11.Text = "Weight (KG)";
            // 
            // wheelsEditRemove
            // 
            wheelsEditRemove.Location = new Point(771, 216);
            wheelsEditRemove.Multiline = true;
            wheelsEditRemove.Name = "wheelsEditRemove";
            wheelsEditRemove.Size = new Size(121, 23);
            wheelsEditRemove.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(673, 219);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 27;
            label12.Text = "Wheels Number";
            // 
            // regEditRemove
            // 
            regEditRemove.Location = new Point(796, 187);
            regEditRemove.Multiline = true;
            regEditRemove.Name = "regEditRemove";
            regEditRemove.Size = new Size(121, 23);
            regEditRemove.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(673, 190);
            label13.Name = "label13";
            label13.Size = new Size(117, 15);
            label13.TabIndex = 25;
            label13.Text = "Registration Number";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(673, 68);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 24;
            label14.Text = "Car or Van?";
            // 
            // carVanEditRemove
            // 
            carVanEditRemove.DropDownStyle = ComboBoxStyle.DropDownList;
            carVanEditRemove.FormattingEnabled = true;
            carVanEditRemove.Items.AddRange(new object[] { "Car", "Van" });
            carVanEditRemove.Location = new Point(745, 65);
            carVanEditRemove.Name = "carVanEditRemove";
            carVanEditRemove.Size = new Size(121, 23);
            carVanEditRemove.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(673, 40);
            label15.Name = "label15";
            label15.Size = new Size(135, 15);
            label15.TabIndex = 22;
            label15.Text = "Edit or Remove Vehicles:\r\n";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(678, 129);
            label16.Name = "label16";
            label16.Size = new Size(87, 15);
            label16.TabIndex = 37;
            label16.Text = "Select a Vehicle";
            // 
            // vehicleSelectEditRemove
            // 
            vehicleSelectEditRemove.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleSelectEditRemove.FormattingEnabled = true;
            vehicleSelectEditRemove.Location = new Point(771, 126);
            vehicleSelectEditRemove.MaxDropDownItems = 3;
            vehicleSelectEditRemove.Name = "vehicleSelectEditRemove";
            vehicleSelectEditRemove.Size = new Size(121, 23);
            vehicleSelectEditRemove.TabIndex = 36;
            // 
            // removeVehicle
            // 
            removeVehicle.Location = new Point(800, 334);
            removeVehicle.Name = "removeVehicle";
            removeVehicle.Size = new Size(121, 37);
            removeVehicle.TabIndex = 38;
            removeVehicle.Text = "Remove Vehicle";
            removeVehicle.UseVisualStyleBackColor = true;
            removeVehicle.Click += removeVehicle_Click;
            // 
            // editRemoveSelectBtn
            // 
            editRemoveSelectBtn.Location = new Point(718, 94);
            editRemoveSelectBtn.Name = "editRemoveSelectBtn";
            editRemoveSelectBtn.Size = new Size(121, 22);
            editRemoveSelectBtn.TabIndex = 39;
            editRemoveSelectBtn.Text = "Select";
            editRemoveSelectBtn.UseVisualStyleBackColor = true;
            editRemoveSelectBtn.Click += editRemoveSelectBtn_Click;
            // 
            // infoEditRemoveBtn
            // 
            infoEditRemoveBtn.Location = new Point(718, 154);
            infoEditRemoveBtn.Name = "infoEditRemoveBtn";
            infoEditRemoveBtn.Size = new Size(121, 22);
            infoEditRemoveBtn.TabIndex = 40;
            infoEditRemoveBtn.Text = "Show Information";
            infoEditRemoveBtn.UseVisualStyleBackColor = true;
            infoEditRemoveBtn.Click += infoEditRemoveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 450);
            Controls.Add(infoEditRemoveBtn);
            Controls.Add(editRemoveSelectBtn);
            Controls.Add(removeVehicle);
            Controls.Add(label16);
            Controls.Add(vehicleSelectEditRemove);
            Controls.Add(editVehicleBtn);
            Controls.Add(heightEditRemove);
            Controls.Add(label9);
            Controls.Add(passengersEditRemove);
            Controls.Add(label10);
            Controls.Add(weightEditRemove);
            Controls.Add(label11);
            Controls.Add(wheelsEditRemove);
            Controls.Add(label12);
            Controls.Add(regEditRemove);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(carVanEditRemove);
            Controls.Add(label15);
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
            Text = "Vehicle Database";
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
        private Button editVehicleBtn;
        private TextBox heightEditRemove;
        private Label label9;
        private TextBox passengersEditRemove;
        private Label label10;
        private TextBox weightEditRemove;
        private Label label11;
        private TextBox wheelsEditRemove;
        private Label label12;
        private TextBox regEditRemove;
        private Label label13;
        private Label label14;
        private ComboBox carVanEditRemove;
        private Label label15;
        private Label label16;
        private ComboBox vehicleSelectEditRemove;
        private Button removeVehicle;
        private Button editRemoveSelectBtn;
        private Button infoEditRemoveBtn;
    }
}