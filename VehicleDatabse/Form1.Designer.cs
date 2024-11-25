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
            this.carVan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoArea = new System.Windows.Forms.TextBox();
            this.showInfo_btn = new System.Windows.Forms.Button();
            this.selectA = new System.Windows.Forms.Label();
            this.vehicleSelect = new System.Windows.Forms.ComboBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carVanAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regText = new System.Windows.Forms.TextBox();
            this.wheelsText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passengersText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.editVehicleBtn = new System.Windows.Forms.Button();
            this.heightEditRemove = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.passengersEditRemove = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.weightEditRemove = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.wheelsEditRemove = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.regEditRemove = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.carVanEditRemove = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.vehicleSelectEditRemove = new System.Windows.Forms.ComboBox();
            this.removeVehicle = new System.Windows.Forms.Button();
            this.editRemoveSelectBtn = new System.Windows.Forms.Button();
            this.infoEditRemoveBtn = new System.Windows.Forms.Button();
            // 
            // carVan
            // 
            this.carVan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carVan.FormattingEnabled = true;
            this.carVan.Items.AddRange(new object[] {
            "Car",
            "Van"});
            this.carVan.Location = new System.Drawing.Point(106, 63);
            this.carVan.Name = "carVan";
            this.carVan.Size = new System.Drawing.Size(121, 23);
            this.carVan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car or Van?";
            // 
            // infoArea
            // 
            this.infoArea.Location = new System.Drawing.Point(55, 240);
            this.infoArea.Multiline = true;
            this.infoArea.Name = "infoArea";
            this.infoArea.Size = new System.Drawing.Size(219, 163);
            this.infoArea.TabIndex = 2;
            // 
            // showInfo_btn
            // 
            this.showInfo_btn.Location = new System.Drawing.Point(106, 187);
            this.showInfo_btn.Name = "showInfo_btn";
            this.showInfo_btn.Size = new System.Drawing.Size(121, 37);
            this.showInfo_btn.TabIndex = 3;
            this.showInfo_btn.Text = "Show Information";
            this.showInfo_btn.UseVisualStyleBackColor = true;
            // 
            // selectA
            // 
            this.selectA.AutoSize = true;
            this.selectA.Location = new System.Drawing.Point(124, 140);
            this.selectA.Name = "selectA";
            this.selectA.Size = new System.Drawing.Size(87, 15);
            this.selectA.TabIndex = 5;
            this.selectA.Text = "Select a Vehicle";
            // 
            // vehicleSelect
            // 
            this.vehicleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleSelect.FormattingEnabled = true;
            this.vehicleSelect.Location = new System.Drawing.Point(106, 158);
            this.vehicleSelect.MaxDropDownItems = 3;
            this.vehicleSelect.Name = "vehicleSelect";
            this.vehicleSelect.Size = new System.Drawing.Size(121, 23);
            this.vehicleSelect.TabIndex = 4;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(123, 92);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(93, 29);
            this.selectBtn.TabIndex = 6;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add New Vehicles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Car or Van?";
            // 
            // carVanAdd
            // 
            this.carVanAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carVanAdd.FormattingEnabled = true;
            this.carVanAdd.Items.AddRange(new object[] {
            "Car",
            "Van"});
            this.carVanAdd.Location = new System.Drawing.Point(431, 65);
            this.carVanAdd.Name = "carVanAdd";
            this.carVanAdd.Size = new System.Drawing.Size(121, 23);
            this.carVanAdd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Registration Number";
            // 
            // regText
            // 
            this.regText.Location = new System.Drawing.Point(482, 93);
            this.regText.Multiline = true;
            this.regText.Name = "regText";
            this.regText.Size = new System.Drawing.Size(121, 23);
            this.regText.TabIndex = 12;
            // 
            // wheelsText
            // 
            this.wheelsText.Location = new System.Drawing.Point(457, 122);
            this.wheelsText.Multiline = true;
            this.wheelsText.Name = "wheelsText";
            this.wheelsText.Size = new System.Drawing.Size(121, 23);
            this.wheelsText.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wheels Number";
            // 
            // weightText
            // 
            this.weightText.Location = new System.Drawing.Point(435, 153);
            this.weightText.Multiline = true;
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(121, 23);
            this.weightText.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Weight (KG)";
            // 
            // passengersText
            // 
            this.passengersText.Location = new System.Drawing.Point(464, 182);
            this.passengersText.Multiline = true;
            this.passengersText.Name = "passengersText";
            this.passengersText.Size = new System.Drawing.Size(121, 23);
            this.passengersText.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Passengers (Cars)";
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(443, 211);
            this.heightText.Multiline = true;
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(121, 23);
            this.heightText.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Height (Vans)";
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Location = new System.Drawing.Point(359, 240);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(121, 37);
            this.addVehicleBtn.TabIndex = 21;
            this.addVehicleBtn.Text = "Add Vehicle";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            // 
            // editVehicleBtn
            // 
            this.editVehicleBtn.Location = new System.Drawing.Point(673, 334);
            this.editVehicleBtn.Name = "editVehicleBtn";
            this.editVehicleBtn.Size = new System.Drawing.Size(121, 37);
            this.editVehicleBtn.TabIndex = 35;
            this.editVehicleBtn.Text = "Edit Vehicle";
            this.editVehicleBtn.UseVisualStyleBackColor = true;
            // 
            // heightEditRemove
            // 
            this.heightEditRemove.Location = new System.Drawing.Point(757, 305);
            this.heightEditRemove.Multiline = true;
            this.heightEditRemove.Name = "heightEditRemove";
            this.heightEditRemove.Size = new System.Drawing.Size(121, 23);
            this.heightEditRemove.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Height (Vans)";
            // 
            // passengersEditRemove
            // 
            this.passengersEditRemove.Location = new System.Drawing.Point(778, 276);
            this.passengersEditRemove.Multiline = true;
            this.passengersEditRemove.Name = "passengersEditRemove";
            this.passengersEditRemove.Size = new System.Drawing.Size(121, 23);
            this.passengersEditRemove.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(673, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Passengers (Cars)";
            // 
            // weightEditRemove
            // 
            this.weightEditRemove.Location = new System.Drawing.Point(749, 247);
            this.weightEditRemove.Multiline = true;
            this.weightEditRemove.Name = "weightEditRemove";
            this.weightEditRemove.Size = new System.Drawing.Size(121, 23);
            this.weightEditRemove.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(673, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Weight (KG)";
            // 
            // wheelsEditRemove
            // 
            this.wheelsEditRemove.Location = new System.Drawing.Point(771, 216);
            this.wheelsEditRemove.Multiline = true;
            this.wheelsEditRemove.Name = "wheelsEditRemove";
            this.wheelsEditRemove.Size = new System.Drawing.Size(121, 23);
            this.wheelsEditRemove.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(673, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Wheels Number";
            // 
            // regEditRemove
            // 
            this.regEditRemove.Location = new System.Drawing.Point(796, 187);
            this.regEditRemove.Multiline = true;
            this.regEditRemove.Name = "regEditRemove";
            this.regEditRemove.Size = new System.Drawing.Size(121, 23);
            this.regEditRemove.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(673, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Registration Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(673, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Car or Van?";
            // 
            // carVanEditRemove
            // 
            this.carVanEditRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carVanEditRemove.FormattingEnabled = true;
            this.carVanEditRemove.Items.AddRange(new object[] {
            "Car",
            "Van"});
            this.carVanEditRemove.Location = new System.Drawing.Point(745, 65);
            this.carVanEditRemove.Name = "carVanEditRemove";
            this.carVanEditRemove.Size = new System.Drawing.Size(121, 23);
            this.carVanEditRemove.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(673, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "Edit or Remove Vehicles:\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(678, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "Select a Vehicle";
            // 
            // vehicleSelectEditRemove
            // 
            this.vehicleSelectEditRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleSelectEditRemove.FormattingEnabled = true;
            this.vehicleSelectEditRemove.Location = new System.Drawing.Point(771, 126);
            this.vehicleSelectEditRemove.MaxDropDownItems = 3;
            this.vehicleSelectEditRemove.Name = "vehicleSelectEditRemove";
            this.vehicleSelectEditRemove.Size = new System.Drawing.Size(121, 23);
            this.vehicleSelectEditRemove.TabIndex = 36;
            // 
            // removeVehicle
            // 
            this.removeVehicle.Location = new System.Drawing.Point(800, 334);
            this.removeVehicle.Name = "removeVehicle";
            this.removeVehicle.Size = new System.Drawing.Size(121, 37);
            this.removeVehicle.TabIndex = 38;
            this.removeVehicle.Text = "Remove Vehicle";
            this.removeVehicle.UseVisualStyleBackColor = true;
            // 
            // editRemoveSelectBtn
            // 
            this.editRemoveSelectBtn.Location = new System.Drawing.Point(718, 94);
            this.editRemoveSelectBtn.Name = "editRemoveSelectBtn";
            this.editRemoveSelectBtn.Size = new System.Drawing.Size(121, 22);
            this.editRemoveSelectBtn.TabIndex = 39;
            this.editRemoveSelectBtn.Text = "Select";
            this.editRemoveSelectBtn.UseVisualStyleBackColor = true;
            // 
            // infoEditRemoveBtn
            // 
            this.infoEditRemoveBtn.Location = new System.Drawing.Point(718, 154);
            this.infoEditRemoveBtn.Name = "infoEditRemoveBtn";
            this.infoEditRemoveBtn.Size = new System.Drawing.Size(121, 22);
            this.infoEditRemoveBtn.TabIndex = 40;
            this.infoEditRemoveBtn.Text = "Show Information";
            this.infoEditRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.infoEditRemoveBtn);
            this.Controls.Add(this.editRemoveSelectBtn);
            this.Controls.Add(this.removeVehicle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.vehicleSelectEditRemove);
            this.Controls.Add(this.editVehicleBtn);
            this.Controls.Add(this.heightEditRemove);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passengersEditRemove);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.weightEditRemove);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.wheelsEditRemove);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.regEditRemove);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.carVanEditRemove);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.addVehicleBtn);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passengersText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wheelsText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carVanAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.selectA);
            this.Controls.Add(this.vehicleSelect);
            this.Controls.Add(this.showInfo_btn);
            this.Controls.Add(this.infoArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carVan);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Vehicle Database";
            this.ResumeLayout(false);
            this.PerformLayout();

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