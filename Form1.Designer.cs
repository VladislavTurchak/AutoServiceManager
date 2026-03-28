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
            ((System.ComponentModel.ISupportInitialize)dataGridClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            SuspendLayout();
            // 
            // dataGridClients
            // 
            dataGridClients.BackgroundColor = SystemColors.ActiveCaption;
            dataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClients.Dock = DockStyle.Top;
            dataGridClients.Location = new Point(0, 0);
            dataGridClients.Name = "dataGridClients";
            dataGridClients.Size = new Size(703, 200);
            dataGridClients.TabIndex = 0;
            dataGridClients.CellContentClick += dataGridClients_CellContentClick;
            // 
            // btnAddClient
            // 
            btnAddClient.AccessibleDescription = "";
            btnAddClient.AccessibleName = "";
            btnAddClient.Cursor = Cursors.Hand;
            btnAddClient.Location = new Point(10, 276);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(75, 23);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(91, 276);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Location = new Point(10, 305);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Location = new Point(91, 305);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 213);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(10, 241);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(57, 238);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(145, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(57, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(145, 23);
            txtName.TabIndex = 8;
            // 
            // dataGridCars
            // 
            dataGridCars.BackgroundColor = SystemColors.ActiveCaption;
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCars.Location = new Point(344, 0);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.Size = new Size(359, 200);
            dataGridCars.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(344, 238);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(145, 23);
            txtModel.TabIndex = 10;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(344, 209);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(145, 23);
            txtBrand.TabIndex = 11;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(344, 267);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(145, 23);
            txtPlate.TabIndex = 12;
            // 
            // btnAddCar
            // 
            btnAddCar.Cursor = Cursors.Hand;
            btnAddCar.Location = new Point(344, 296);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(75, 23);
            btnAddCar.TabIndex = 13;
            btnAddCar.Text = "Add Car";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(495, 214);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(38, 15);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(495, 241);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 15;
            lblModel.Text = "Model";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.ForeColor = SystemColors.InfoText;
            lblPlate.Location = new Point(495, 270);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(80, 15);
            lblPlate.TabIndex = 16;
            lblPlate.Text = "Plate Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(703, 469);
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
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
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
    }
}
