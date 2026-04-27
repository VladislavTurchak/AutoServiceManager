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
            dataGridClients = new DataGridView();
            btnAddClient = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnRefresh = new Button();
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
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridClients
            // 
            dataGridClients.AllowUserToAddRows = false;
            dataGridClients.BackgroundColor = SystemColors.ControlLightLight;
            dataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClients.GridColor = Color.LightGray;
            dataGridClients.Location = new Point(0, 0);
            dataGridClients.Name = "dataGridClients";
            dataGridClients.ReadOnly = true;
            dataGridClients.Size = new Size(269, 200);
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
            btnAddClient.Location = new Point(10, 269);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(82, 31);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(98, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Font = new Font("Segoe UI", 10F);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(10, 305);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 31);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(98, 305);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 31);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(161, 210);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 19);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(161, 238);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 19);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(10, 235);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(145, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(10, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(145, 23);
            txtName.TabIndex = 8;
            // 
            // dataGridCars
            // 
            dataGridCars.AllowUserToAddRows = false;
            dataGridCars.BackgroundColor = SystemColors.ControlLightLight;
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCars.GridColor = Color.LightGray;
            dataGridCars.Location = new Point(268, 0);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.ReadOnly = true;
            dataGridCars.Size = new Size(334, 200);
            dataGridCars.TabIndex = 9;
            dataGridCars.SelectionChanged += dataGridCars_SelectionChanged;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(274, 235);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(145, 23);
            txtModel.TabIndex = 10;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(274, 206);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(145, 23);
            txtBrand.TabIndex = 11;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(274, 264);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(145, 23);
            txtPlate.TabIndex = 12;
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.SteelBlue;
            btnAddCar.Cursor = Cursors.Hand;
            btnAddCar.FlatStyle = FlatStyle.Popup;
            btnAddCar.Font = new Font("Segoe UI", 10F);
            btnAddCar.ForeColor = Color.White;
            btnAddCar.Location = new Point(274, 293);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(82, 31);
            btnAddCar.TabIndex = 13;
            btnAddCar.Text = "Add Car";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 10F);
            lblBrand.Location = new Point(425, 211);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(45, 19);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 10F);
            lblModel.Location = new Point(425, 238);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(48, 19);
            lblModel.TabIndex = 15;
            lblModel.Text = "Model";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Font = new Font("Segoe UI", 10F);
            lblPlate.ForeColor = SystemColors.InfoText;
            lblPlate.Location = new Point(425, 267);
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
            dataGridOrders.Location = new Point(600, 0);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.ReadOnly = true;
            dataGridOrders.Size = new Size(441, 200);
            dataGridOrders.TabIndex = 17;
            // 
            // lblServiceType
            // 
            lblServiceType.AutoSize = true;
            lblServiceType.Font = new Font("Segoe UI", 10F);
            lblServiceType.Location = new Point(736, 207);
            lblServiceType.Name = "lblServiceType";
            lblServiceType.Size = new Size(83, 19);
            lblServiceType.TabIndex = 18;
            lblServiceType.Text = "Service Type";
            // 
            // cmbServiceType
            // 
            cmbServiceType.FormattingEnabled = true;
            cmbServiceType.Items.AddRange(new object[] { "Repair", "Maintenance" });
            cmbServiceType.Location = new Point(609, 206);
            cmbServiceType.Name = "cmbServiceType";
            cmbServiceType.Size = new Size(121, 23);
            cmbServiceType.TabIndex = 19;
            // 
            // lblBasePrice
            // 
            lblBasePrice.AutoSize = true;
            lblBasePrice.Font = new Font("Segoe UI", 10F);
            lblBasePrice.Location = new Point(760, 238);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(70, 19);
            lblBasePrice.TabIndex = 20;
            lblBasePrice.Text = "Base Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(609, 235);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(145, 23);
            txtPrice.TabIndex = 21;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(609, 264);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(145, 23);
            txtHours.TabIndex = 22;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Segoe UI", 10F);
            lblHours.Location = new Point(760, 267);
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
            btnAddOrder.Location = new Point(609, 293);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(85, 31);
            btnAddOrder.TabIndex = 24;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(10, 363);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(145, 23);
            txtSearch.TabIndex = 25;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.SteelBlue;
            btnShowAll.FlatStyle = FlatStyle.Popup;
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(10, 392);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(82, 27);
            btnShowAll.TabIndex = 27;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(161, 367);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(28, 19);
            lblSearch.TabIndex = 28;
            lblSearch.Text = "🔍";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1042, 469);
            Controls.Add(lblSearch);
            Controls.Add(btnShowAll);
            Controls.Add(txtSearch);
            Controls.Add(btnAddOrder);
            Controls.Add(lblHours);
            Controls.Add(txtHours);
            Controls.Add(txtPrice);
            Controls.Add(lblBasePrice);
            Controls.Add(cmbServiceType);
            Controls.Add(lblServiceType);
            Controls.Add(dataGridOrders);
            Controls.Add(lblPlate);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(btnAddCar);
            Controls.Add(txtPlate);
            Controls.Add(txtBrand);
            Controls.Add(txtModel);
            Controls.Add(dataGridCars);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(btnRefresh);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnAddClient);
            Controls.Add(dataGridClients);
            Name = "Form1";
            Text = "Auto Service Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridClients;
        private Button btnAddClient;
        private Button btnSave;
        private Button btnLoad;
        private Button btnRefresh;
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
        private Label lblSearch;
    }
}
