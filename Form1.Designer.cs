namespace VehicleApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpVehicleInformation = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.grpForCars = new System.Windows.Forms.GroupBox();
            this.grpForBikes = new System.Windows.Forms.GroupBox();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblTireSize = new System.Windows.Forms.Label();
            this.lblTerrain = new System.Windows.Forms.Label();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.cboTerrain = new System.Windows.Forms.ComboBox();
            this.nrudPasengers = new System.Windows.Forms.NumericUpDown();
            this.nrudTireSize = new System.Windows.Forms.NumericUpDown();
            this.grpTypeOfVehicle = new System.Windows.Forms.GroupBox();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.rbtnBicycle = new System.Windows.Forms.RadioButton();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.btnCalcInterest = new System.Windows.Forms.Button();
            this.grpVehicleInformation.SuspendLayout();
            this.grpForCars.SuspendLayout();
            this.grpForBikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPasengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).BeginInit();
            this.grpTypeOfVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVehicleInformation
            // 
            this.grpVehicleInformation.Controls.Add(this.grpTypeOfVehicle);
            this.grpVehicleInformation.Controls.Add(this.grpForBikes);
            this.grpVehicleInformation.Controls.Add(this.grpForCars);
            this.grpVehicleInformation.Controls.Add(this.txtStore);
            this.grpVehicleInformation.Controls.Add(this.txtWarranty);
            this.grpVehicleInformation.Controls.Add(this.txtPrice);
            this.grpVehicleInformation.Controls.Add(this.txtBrand);
            this.grpVehicleInformation.Controls.Add(this.txtName);
            this.grpVehicleInformation.Controls.Add(this.lblStore);
            this.grpVehicleInformation.Controls.Add(this.lblWarranty);
            this.grpVehicleInformation.Controls.Add(this.lblPrice);
            this.grpVehicleInformation.Controls.Add(this.lblBrand);
            this.grpVehicleInformation.Controls.Add(this.lblName);
            this.grpVehicleInformation.Location = new System.Drawing.Point(12, 92);
            this.grpVehicleInformation.Name = "grpVehicleInformation";
            this.grpVehicleInformation.Size = new System.Drawing.Size(776, 342);
            this.grpVehicleInformation.TabIndex = 0;
            this.grpVehicleInformation.TabStop = false;
            this.grpVehicleInformation.Text = "Vehicle Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(16, 81);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 131);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Location = new System.Drawing.Point(16, 181);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(50, 13);
            this.lblWarranty.TabIndex = 4;
            this.lblWarranty.Text = "Warranty";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(19, 236);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(32, 13);
            this.lblStore.TabIndex = 5;
            this.lblStore.Text = "Store";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(81, 81);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(81, 131);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(81, 181);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(100, 20);
            this.txtWarranty.TabIndex = 9;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(81, 236);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(100, 20);
            this.txtStore.TabIndex = 10;
            // 
            // grpForCars
            // 
            this.grpForCars.Controls.Add(this.nrudPasengers);
            this.grpForCars.Controls.Add(this.cboFuel);
            this.grpForCars.Controls.Add(this.lblFuel);
            this.grpForCars.Controls.Add(this.lblPassengers);
            this.grpForCars.Location = new System.Drawing.Point(262, 33);
            this.grpForCars.Name = "grpForCars";
            this.grpForCars.Size = new System.Drawing.Size(200, 100);
            this.grpForCars.TabIndex = 11;
            this.grpForCars.TabStop = false;
            this.grpForCars.Text = "For Cars";
            // 
            // grpForBikes
            // 
            this.grpForBikes.Controls.Add(this.nrudTireSize);
            this.grpForBikes.Controls.Add(this.cboTerrain);
            this.grpForBikes.Controls.Add(this.lblTerrain);
            this.grpForBikes.Controls.Add(this.lblTireSize);
            this.grpForBikes.Location = new System.Drawing.Point(262, 156);
            this.grpForBikes.Name = "grpForBikes";
            this.grpForBikes.Size = new System.Drawing.Size(200, 100);
            this.grpForBikes.TabIndex = 12;
            this.grpForBikes.TabStop = false;
            this.grpForBikes.Text = "For Bikes";
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Location = new System.Drawing.Point(7, 20);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(62, 13);
            this.lblPassengers.TabIndex = 0;
            this.lblPassengers.Text = "Passengers";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(7, 60);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(27, 13);
            this.lblFuel.TabIndex = 1;
            this.lblFuel.Text = "Fuel";
            // 
            // lblTireSize
            // 
            this.lblTireSize.AutoSize = true;
            this.lblTireSize.Location = new System.Drawing.Point(7, 20);
            this.lblTireSize.Name = "lblTireSize";
            this.lblTireSize.Size = new System.Drawing.Size(48, 13);
            this.lblTireSize.TabIndex = 0;
            this.lblTireSize.Text = "Tire Size";
            // 
            // lblTerrain
            // 
            this.lblTerrain.AutoSize = true;
            this.lblTerrain.Location = new System.Drawing.Point(10, 61);
            this.lblTerrain.Name = "lblTerrain";
            this.lblTerrain.Size = new System.Drawing.Size(40, 13);
            this.lblTerrain.TabIndex = 1;
            this.lblTerrain.Text = "Terrain";
            // 
            // cboFuel
            // 
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Items.AddRange(new object[] {
            "Gas",
            "Diesel",
            "Electric",
            "Hybrid"});
            this.cboFuel.Location = new System.Drawing.Point(73, 60);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(121, 21);
            this.cboFuel.TabIndex = 2;
            // 
            // cboTerrain
            // 
            this.cboTerrain.FormattingEnabled = true;
            this.cboTerrain.Items.AddRange(new object[] {
            "Paved",
            "Unpaved"});
            this.cboTerrain.Location = new System.Drawing.Point(73, 61);
            this.cboTerrain.Name = "cboTerrain";
            this.cboTerrain.Size = new System.Drawing.Size(121, 21);
            this.cboTerrain.TabIndex = 2;
            // 
            // nrudPasengers
            // 
            this.nrudPasengers.Location = new System.Drawing.Point(73, 20);
            this.nrudPasengers.Name = "nrudPasengers";
            this.nrudPasengers.Size = new System.Drawing.Size(120, 20);
            this.nrudPasengers.TabIndex = 3;
            // 
            // nrudTireSize
            // 
            this.nrudTireSize.Location = new System.Drawing.Point(73, 20);
            this.nrudTireSize.Name = "nrudTireSize";
            this.nrudTireSize.Size = new System.Drawing.Size(120, 20);
            this.nrudTireSize.TabIndex = 3;
            // 
            // grpTypeOfVehicle
            // 
            this.grpTypeOfVehicle.Controls.Add(this.rbtnBicycle);
            this.grpTypeOfVehicle.Controls.Add(this.rbtnCar);
            this.grpTypeOfVehicle.Location = new System.Drawing.Point(537, 33);
            this.grpTypeOfVehicle.Name = "grpTypeOfVehicle";
            this.grpTypeOfVehicle.Size = new System.Drawing.Size(200, 100);
            this.grpTypeOfVehicle.TabIndex = 13;
            this.grpTypeOfVehicle.TabStop = false;
            this.grpTypeOfVehicle.Text = "Type of Vehicle";
            // 
            // rbtnCar
            // 
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.Location = new System.Drawing.Point(27, 20);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(41, 17);
            this.rbtnCar.TabIndex = 0;
            this.rbtnCar.TabStop = true;
            this.rbtnCar.Text = "Car";
            this.rbtnCar.UseVisualStyleBackColor = true;
            this.rbtnCar.CheckedChanged += new System.EventHandler(this.rbtnCar_CheckedChanged);
            // 
            // rbtnBicycle
            // 
            this.rbtnBicycle.AutoSize = true;
            this.rbtnBicycle.Location = new System.Drawing.Point(27, 60);
            this.rbtnBicycle.Name = "rbtnBicycle";
            this.rbtnBicycle.Size = new System.Drawing.Size(59, 17);
            this.rbtnBicycle.TabIndex = 1;
            this.rbtnBicycle.TabStop = true;
            this.rbtnBicycle.Text = "Bicycle";
            this.rbtnBicycle.UseVisualStyleBackColor = true;
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(586, 463);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(202, 47);
            this.btnCreateVehicle.TabIndex = 1;
            this.btnCreateVehicle.Text = "Create Vehicle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.Click += new System.EventHandler(this.btnCreateVehicle_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(426, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(125, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search By Vehicle Name";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(586, 25);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtNameSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(707, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Location = new System.Drawing.Point(21, 463);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(202, 47);
            this.btnMakeSale.TabIndex = 5;
            this.btnMakeSale.Text = "MakeSale";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
            // 
            // btnCalcInterest
            // 
            this.btnCalcInterest.Location = new System.Drawing.Point(229, 463);
            this.btnCalcInterest.Name = "btnCalcInterest";
            this.btnCalcInterest.Size = new System.Drawing.Size(202, 47);
            this.btnCalcInterest.TabIndex = 6;
            this.btnCalcInterest.Text = "Calculate Interest";
            this.btnCalcInterest.UseVisualStyleBackColor = true;
            this.btnCalcInterest.Click += new System.EventHandler(this.btnCalcInterest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.btnCalcInterest);
            this.Controls.Add(this.btnMakeSale);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.grpVehicleInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpVehicleInformation.ResumeLayout(false);
            this.grpVehicleInformation.PerformLayout();
            this.grpForCars.ResumeLayout(false);
            this.grpForCars.PerformLayout();
            this.grpForBikes.ResumeLayout(false);
            this.grpForBikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPasengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).EndInit();
            this.grpTypeOfVehicle.ResumeLayout(false);
            this.grpTypeOfVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVehicleInformation;
        private System.Windows.Forms.GroupBox grpTypeOfVehicle;
        private System.Windows.Forms.RadioButton rbtnBicycle;
        private System.Windows.Forms.RadioButton rbtnCar;
        private System.Windows.Forms.GroupBox grpForBikes;
        private System.Windows.Forms.NumericUpDown nrudTireSize;
        private System.Windows.Forms.ComboBox cboTerrain;
        private System.Windows.Forms.Label lblTerrain;
        private System.Windows.Forms.Label lblTireSize;
        private System.Windows.Forms.GroupBox grpForCars;
        private System.Windows.Forms.NumericUpDown nrudPasengers;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMakeSale;
        private System.Windows.Forms.Button btnCalcInterest;
    }
}

