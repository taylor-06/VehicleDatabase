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
            SuspendLayout();
            // 
            // carVan
            // 
            carVan.DropDownStyle = ComboBoxStyle.DropDownList;
            carVan.FormattingEnabled = true;
            carVan.Items.AddRange(new object[] { "Car", "Van" });
            carVan.Location = new Point(49, 68);
            carVan.Name = "carVan";
            carVan.Size = new Size(121, 23);
            carVan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 50);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Car or Van?";
            // 
            // infoArea
            // 
            infoArea.Location = new Point(49, 259);
            infoArea.Multiline = true;
            infoArea.Name = "infoArea";
            infoArea.Size = new Size(219, 165);
            infoArea.TabIndex = 2;
            // 
            // showInfo_btn
            // 
            showInfo_btn.Location = new Point(49, 198);
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
            selectA.Location = new Point(49, 130);
            selectA.Name = "selectA";
            selectA.Size = new Size(87, 15);
            selectA.TabIndex = 5;
            selectA.Text = "Select a Vehicle";
            // 
            // vehicleSelect
            // 
            vehicleSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleSelect.FormattingEnabled = true;
            vehicleSelect.Location = new Point(49, 148);
            vehicleSelect.Name = "vehicleSelect";
            vehicleSelect.Size = new Size(121, 23);
            vehicleSelect.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(selectA);
            Controls.Add(vehicleSelect);
            Controls.Add(showInfo_btn);
            Controls.Add(infoArea);
            Controls.Add(label1);
            Controls.Add(carVan);
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
    }
}