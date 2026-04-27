namespace AutoServiceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridClients = new DataGridView();
            btnAddClient = new Button();
            btnSave = new Button();
            lblName = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            dataGridCars = new DataGridView();
            txtModel = new TextBox();
            txtBrand = new TextBox();
            txtPlate = new TextBox();
            btnAddCar = new Button();
            lblBrand = new Label();
            lblModel = new Label();
            lblPlate = new Label();
            dataGridOrders = new DataGridView();
            lblServiceType = new Label();
            cmbServiceType = new ComboBox();
            lblBasePrice = new Label();
            txtPrice = new TextBox();
            txtHours = new TextBox();
            lblHours = new Label();
            btnAddOrder = new Button();
            txtSearch = new TextBox();
            btnShowAll = new Button();
            lblClientGrid = new Label();
            lblCarsGrid = new Label();
            lblOrderGrid = new Label();
            label1 = new Label();
            btnDeleteCar = new Button();
            btnDeleteOrder = new Button();
            btnDeleteClient = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridClients
            // 
            dataGridClients.AllowUserToAddRows = false;
            dataGridClients.BackgroundColor = SystemColors.ControlLightLight;
            dataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClients.GridColor = Color.LightGray;
            dataGridClients.Location = new Point(-1, 79);
            dataGridClients.Name = "dataGridClients";
            dataGridClients.Size = new Size(297, 222);
            dataGridClients.TabIndex = 0;
            dataGridClients.SelectionChanged += dataGridClients_SelectionChanged;
            // 
            // btnAddClient
            // 
            btnAddClient.AccessibleDescription = "";
            btnAddClient.AccessibleName = "";
            btnAddClient.BackColor = Color.SteelBlue;
            btnAddClient.Cursor = Cursors.Hand;
            btnAddClient.FlatStyle = FlatStyle.Popup;
            btnAddClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddClient.ForeColor = Color.White;
            btnAddClient.Location = new Point(24, 495);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(108, 35);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(515, 564);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 35);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save All Data";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(24, 368);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 19);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(24, 427);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 19);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(24, 449);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(206, 25);
            txtPhone.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(24, 390);
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 25);
            txtName.TabIndex = 8;
            // 
            // dataGridCars
            // 
            dataGridCars.AllowUserToAddRows = false;
            dataGridCars.BackgroundColor = SystemColors.ControlLightLight;
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCars.GridColor = Color.LightGray;
            dataGridCars.Location = new Point(-1, 78);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.Size = new Size(392, 222);
            dataGridCars.TabIndex = 9;
            dataGridCars.SelectionChanged += dataGridCars_SelectionChanged;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(24, 389);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(206, 25);
            txtModel.TabIndex = 10;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(24, 334);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(206, 25);
            txtBrand.TabIndex = 11;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(24, 448);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(206, 25);
            txtPlate.TabIndex = 12;
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.SteelBlue;
            btnAddCar.Cursor = Cursors.Hand;
            btnAddCar.FlatStyle = FlatStyle.Popup;
            btnAddCar.Font = new Font("Segoe UI", 10F);
            btnAddCar.ForeColor = Color.White;
            btnAddCar.Location = new Point(24, 494);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(108, 35);
            btnAddCar.TabIndex = 13;
            btnAddCar.Text = "Add Car";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.BackColor = SystemColors.ControlLightLight;
            lblBrand.Font = new Font("Segoe UI", 10F);
            lblBrand.Location = new Point(24, 312);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(45, 19);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.BackColor = SystemColors.ControlLightLight;
            lblModel.Font = new Font("Segoe UI", 10F);
            lblModel.Location = new Point(24, 367);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(48, 19);
            lblModel.TabIndex = 15;
            lblModel.Text = "Model";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.BackColor = SystemColors.ControlLightLight;
            lblPlate.Font = new Font("Segoe UI", 10F);
            lblPlate.ForeColor = SystemColors.InfoText;
            lblPlate.Location = new Point(24, 426);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(93, 19);
            lblPlate.TabIndex = 16;
            lblPlate.Text = "Plate Number";
            // 
            // dataGridOrders
            // 
            dataGridOrders.BackgroundColor = SystemColors.ControlLightLight;
            dataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrders.GridColor = Color.LightGray;
            dataGridOrders.Location = new Point(-1, 77);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.ReadOnly = true;
            dataGridOrders.Size = new Size(442, 222);
            dataGridOrders.TabIndex = 17;
            // 
            // lblServiceType
            // 
            lblServiceType.AutoSize = true;
            lblServiceType.Font = new Font("Segoe UI", 10F);
            lblServiceType.Location = new Point(22, 311);
            lblServiceType.Name = "lblServiceType";
            lblServiceType.Size = new Size(83, 19);
            lblServiceType.TabIndex = 18;
            lblServiceType.Text = "Service Type";
            // 
            // cmbServiceType
            // 
            cmbServiceType.FormattingEnabled = true;
            cmbServiceType.Items.AddRange(new object[] { "Repair", "Maintenance" });
            cmbServiceType.Location = new Point(22, 333);
            cmbServiceType.Name = "cmbServiceType";
            cmbServiceType.Size = new Size(155, 25);
            cmbServiceType.TabIndex = 19;
            // 
            // lblBasePrice
            // 
            lblBasePrice.AutoSize = true;
            lblBasePrice.Font = new Font("Segoe UI", 10F);
            lblBasePrice.Location = new Point(22, 366);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(70, 19);
            lblBasePrice.TabIndex = 20;
            lblBasePrice.Text = "Base Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(22, 388);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(206, 25);
            txtPrice.TabIndex = 21;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(22, 447);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(206, 25);
            txtHours.TabIndex = 22;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Segoe UI", 10F);
            lblHours.Location = new Point(22, 425);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(46, 19);
            lblHours.TabIndex = 23;
            lblHours.Text = "Hours";
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.SteelBlue;
            btnAddOrder.Cursor = Cursors.Hand;
            btnAddOrder.FlatStyle = FlatStyle.Popup;
            btnAddOrder.Font = new Font("Segoe UI", 10F);
            btnAddOrder.ForeColor = Color.White;
            btnAddOrder.Location = new Point(22, 493);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(108, 35);
            btnAddOrder.TabIndex = 24;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(145, 25);
            txtSearch.TabIndex = 25;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.SteelBlue;
            btnShowAll.FlatStyle = FlatStyle.Popup;
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(162, 37);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(82, 25);
            btnShowAll.TabIndex = 27;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblClientGrid
            // 
            lblClientGrid.AutoSize = true;
            lblClientGrid.BackColor = SystemColors.ControlLightLight;
            lblClientGrid.FlatStyle = FlatStyle.Flat;
            lblClientGrid.Font = new Font("Segoe UI", 12F);
            lblClientGrid.Location = new Point(118, 0);
            lblClientGrid.Name = "lblClientGrid";
            lblClientGrid.Size = new Size(57, 21);
            lblClientGrid.TabIndex = 29;
            lblClientGrid.Text = "Clients";
            // 
            // lblCarsGrid
            // 
            lblCarsGrid.AutoSize = true;
            lblCarsGrid.FlatStyle = FlatStyle.Flat;
            lblCarsGrid.Font = new Font("Segoe UI", 12F);
            lblCarsGrid.Location = new Point(148, 0);
            lblCarsGrid.Name = "lblCarsGrid";
            lblCarsGrid.Size = new Size(85, 21);
            lblCarsGrid.TabIndex = 30;
            lblCarsGrid.Text = "Client Cars";
            // 
            // lblOrderGrid
            // 
            lblOrderGrid.AutoSize = true;
            lblOrderGrid.Font = new Font("Segoe UI", 12F);
            lblOrderGrid.Location = new Point(179, 1);
            lblOrderGrid.Name = "lblOrderGrid";
            lblOrderGrid.Size = new Size(86, 21);
            lblOrderGrid.TabIndex = 31;
            lblOrderGrid.Text = "Car Orders";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 32;
            label1.Text = "Find a client";
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.BackColor = Color.SteelBlue;
            btnDeleteCar.Cursor = Cursors.Hand;
            btnDeleteCar.FlatStyle = FlatStyle.Popup;
            btnDeleteCar.Font = new Font("Segoe UI", 10F);
            btnDeleteCar.ForeColor = Color.White;
            btnDeleteCar.Location = new Point(157, 494);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(108, 35);
            btnDeleteCar.TabIndex = 33;
            btnDeleteCar.Text = "Delete Car";
            btnDeleteCar.UseVisualStyleBackColor = false;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.SteelBlue;
            btnDeleteOrder.Cursor = Cursors.Hand;
            btnDeleteOrder.FlatStyle = FlatStyle.Popup;
            btnDeleteOrder.Font = new Font("Segoe UI", 10F);
            btnDeleteOrder.ForeColor = Color.White;
            btnDeleteOrder.Location = new Point(157, 493);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(108, 35);
            btnDeleteOrder.TabIndex = 34;
            btnDeleteOrder.Text = "Delete Order";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.BackColor = Color.SteelBlue;
            btnDeleteClient.Cursor = Cursors.Hand;
            btnDeleteClient.FlatStyle = FlatStyle.Popup;
            btnDeleteClient.Font = new Font("Segoe UI", 10F);
            btnDeleteClient.ForeColor = Color.White;
            btnDeleteClient.Location = new Point(162, 495);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(108, 35);
            btnDeleteClient.TabIndex = 35;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = false;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDeleteClient);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(dataGridClients);
            panel1.Controls.Add(btnShowAll);
            panel1.Controls.Add(lblClientGrid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddClient);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 545);
            panel1.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblCarsGrid);
            panel2.Controls.Add(dataGridCars);
            panel2.Controls.Add(btnDeleteCar);
            panel2.Controls.Add(btnAddCar);
            panel2.Controls.Add(txtPlate);
            panel2.Controls.Add(lblPlate);
            panel2.Controls.Add(txtModel);
            panel2.Controls.Add(lblModel);
            panel2.Controls.Add(txtBrand);
            panel2.Controls.Add(lblBrand);
            panel2.Location = new Point(325, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 545);
            panel2.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dataGridOrders);
            panel3.Controls.Add(btnAddOrder);
            panel3.Controls.Add(btnDeleteOrder);
            panel3.Controls.Add(lblServiceType);
            panel3.Controls.Add(lblOrderGrid);
            panel3.Controls.Add(cmbServiceType);
            panel3.Controls.Add(lblBasePrice);
            panel3.Controls.Add(txtHours);
            panel3.Controls.Add(lblHours);
            panel3.Controls.Add(txtPrice);
            panel3.Location = new Point(732, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 545);
            panel3.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1186, 606);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Auto Service Manager";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridClients;
        private Button btnAddClient;
        private Button btnSave;
        private Label lblName;
        private Label lblPhone;
        private TextBox txtPhone;
        private TextBox txtName;
        private DataGridView dataGridCars;
        private TextBox txtModel;
        private TextBox txtBrand;
        private TextBox txtPlate;
        private Button btnAddCar;
        private Label lblBrand;
        private Label lblModel;
        private Label lblPlate;
        private DataGridView dataGridOrders;
        private Label lblServiceType;
        private ComboBox cmbServiceType;
        private Label lblBasePrice;
        private TextBox txtPrice;
        private TextBox txtHours;
        private Label lblHours;
        private Button btnAddOrder;
        private TextBox txtSearch;
        private Button btnShowAll;
        private Label lblClientGrid;
        private Label lblCarsGrid;
        private Label lblOrderGrid;
        private Label label1;
        private Button btnDeleteCar;
        private Button btnDeleteOrder;
        private Button btnDeleteClient;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
