
namespace DermaFram
{
    partial class AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priceperunitlbl = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.btnAddM = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelM = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteM = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.expireDatelbl = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtExpireDate = new System.Windows.Forms.TextBox();
            this.lblManufacturingDate = new System.Windows.Forms.Label();
            this.txtManufacturingDate = new System.Windows.Forms.TextBox();
            this.medicinelbl = new System.Windows.Forms.Label();
            this.txtMediName = new System.Windows.Forms.TextBox();
            this.lblAddMedicine = new System.Windows.Forms.Label();
            this.closebtn = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.ManufacturingDate,
            this.ExpireDate,
            this.Quantity,
            this.PricePerUnit});
            this.dataGridView1.Location = new System.Drawing.Point(389, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 454);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // MedicineID
            // 
            this.MedicineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineID.DataPropertyName = "MedicineID";
            this.MedicineID.HeaderText = "Medicine ID";
            this.MedicineID.MinimumWidth = 6;
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            this.MedicineID.Visible = false;
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            // 
            // ManufacturingDate
            // 
            this.ManufacturingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufacturingDate.DataPropertyName = "ManufacturingDate";
            this.ManufacturingDate.HeaderText = "Manufacturing Date";
            this.ManufacturingDate.MinimumWidth = 6;
            this.ManufacturingDate.Name = "ManufacturingDate";
            this.ManufacturingDate.ReadOnly = true;
            // 
            // ExpireDate
            // 
            this.ExpireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpireDate.DataPropertyName = "ExpireDate";
            this.ExpireDate.HeaderText = "Expire Date";
            this.ExpireDate.MinimumWidth = 6;
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PricePerUnit.DataPropertyName = "PricePerUnit";
            this.PricePerUnit.HeaderText = "Price PerUnit";
            this.PricePerUnit.MinimumWidth = 6;
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            // 
            // Priceperunitlbl
            // 
            this.Priceperunitlbl.AutoSize = true;
            this.Priceperunitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Priceperunitlbl.Location = new System.Drawing.Point(26, 384);
            this.Priceperunitlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Priceperunitlbl.Name = "Priceperunitlbl";
            this.Priceperunitlbl.Size = new System.Drawing.Size(175, 29);
            this.Priceperunitlbl.TabIndex = 75;
            this.Priceperunitlbl.Text = "Price Per Unit";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Location = new System.Drawing.Point(22, 417);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtPricePerUnit.Multiline = true;
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(334, 39);
            this.txtPricePerUnit.TabIndex = 74;
            // 
            // btnAddM
            // 
            this.btnAddM.AutoRoundedCorners = true;
            this.btnAddM.BorderRadius = 19;
            this.btnAddM.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnAddM.CheckedState.Parent = this.btnAddM;
            this.btnAddM.CustomImages.Parent = this.btnAddM;
            this.btnAddM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddM.ForeColor = System.Drawing.Color.White;
            this.btnAddM.HoverState.Parent = this.btnAddM;
            this.btnAddM.Location = new System.Drawing.Point(39, 479);
            this.btnAddM.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.ShadowDecoration.Parent = this.btnAddM;
            this.btnAddM.Size = new System.Drawing.Size(80, 40);
            this.btnAddM.TabIndex = 73;
            this.btnAddM.Text = "Add";
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // btnCancelM
            // 
            this.btnCancelM.AutoRoundedCorners = true;
            this.btnCancelM.BorderRadius = 19;
            this.btnCancelM.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnCancelM.CheckedState.Parent = this.btnCancelM;
            this.btnCancelM.CustomImages.Parent = this.btnCancelM;
            this.btnCancelM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelM.ForeColor = System.Drawing.Color.White;
            this.btnCancelM.HoverState.Parent = this.btnCancelM;
            this.btnCancelM.Location = new System.Drawing.Point(239, 479);
            this.btnCancelM.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelM.Name = "btnCancelM";
            this.btnCancelM.ShadowDecoration.Parent = this.btnCancelM;
            this.btnCancelM.Size = new System.Drawing.Size(80, 40);
            this.btnCancelM.TabIndex = 72;
            this.btnCancelM.Text = "Cancel";
            this.btnCancelM.Click += new System.EventHandler(this.btnCancelM_Click);
            // 
            // btnDeleteM
            // 
            this.btnDeleteM.AutoRoundedCorners = true;
            this.btnDeleteM.BorderRadius = 19;
            this.btnDeleteM.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnDeleteM.CheckedState.Parent = this.btnDeleteM;
            this.btnDeleteM.CustomImages.Parent = this.btnDeleteM;
            this.btnDeleteM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteM.ForeColor = System.Drawing.Color.White;
            this.btnDeleteM.HoverState.Parent = this.btnDeleteM;
            this.btnDeleteM.Location = new System.Drawing.Point(135, 479);
            this.btnDeleteM.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteM.Name = "btnDeleteM";
            this.btnDeleteM.ShadowDecoration.Parent = this.btnDeleteM;
            this.btnDeleteM.Size = new System.Drawing.Size(80, 40);
            this.btnDeleteM.TabIndex = 71;
            this.btnDeleteM.Text = "Delete";
            this.btnDeleteM.Click += new System.EventHandler(this.btnDeleteM_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuantity.Location = new System.Drawing.Point(26, 306);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(108, 29);
            this.lblQuantity.TabIndex = 70;
            this.lblQuantity.Text = "Quantity";
            // 
            // expireDatelbl
            // 
            this.expireDatelbl.AutoSize = true;
            this.expireDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expireDatelbl.Location = new System.Drawing.Point(26, 232);
            this.expireDatelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expireDatelbl.Name = "expireDatelbl";
            this.expireDatelbl.Size = new System.Drawing.Size(149, 29);
            this.expireDatelbl.TabIndex = 69;
            this.expireDatelbl.Text = "Expire Date";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(22, 339);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(334, 39);
            this.txtQuantity.TabIndex = 68;
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.Location = new System.Drawing.Point(22, 265);
            this.txtExpireDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpireDate.Multiline = true;
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.Size = new System.Drawing.Size(334, 36);
            this.txtExpireDate.TabIndex = 67;
            // 
            // lblManufacturingDate
            // 
            this.lblManufacturingDate.AutoSize = true;
            this.lblManufacturingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManufacturingDate.Location = new System.Drawing.Point(23, 157);
            this.lblManufacturingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturingDate.Name = "lblManufacturingDate";
            this.lblManufacturingDate.Size = new System.Drawing.Size(230, 29);
            this.lblManufacturingDate.TabIndex = 66;
            this.lblManufacturingDate.Text = "ManufacturingDate";
            // 
            // txtManufacturingDate
            // 
            this.txtManufacturingDate.Location = new System.Drawing.Point(22, 190);
            this.txtManufacturingDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtManufacturingDate.Multiline = true;
            this.txtManufacturingDate.Name = "txtManufacturingDate";
            this.txtManufacturingDate.Size = new System.Drawing.Size(334, 34);
            this.txtManufacturingDate.TabIndex = 65;
            // 
            // medicinelbl
            // 
            this.medicinelbl.AutoSize = true;
            this.medicinelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.medicinelbl.Location = new System.Drawing.Point(26, 79);
            this.medicinelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medicinelbl.Name = "medicinelbl";
            this.medicinelbl.Size = new System.Drawing.Size(196, 29);
            this.medicinelbl.TabIndex = 64;
            this.medicinelbl.Text = "Medicine Name";
            // 
            // txtMediName
            // 
            this.txtMediName.Location = new System.Drawing.Point(22, 112);
            this.txtMediName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMediName.Multiline = true;
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.Size = new System.Drawing.Size(334, 35);
            this.txtMediName.TabIndex = 63;
            // 
            // lblAddMedicine
            // 
            this.lblAddMedicine.AutoSize = true;
            this.lblAddMedicine.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddMedicine.Location = new System.Drawing.Point(84, 42);
            this.lblAddMedicine.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAddMedicine.Name = "lblAddMedicine";
            this.lblAddMedicine.Size = new System.Drawing.Size(212, 37);
            this.lblAddMedicine.TabIndex = 62;
            this.lblAddMedicine.Text = "Add Medicine";
            // 
            // closebtn
            // 
            this.closebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImageSize = new System.Drawing.Size(64, 64);
            this.closebtn.Location = new System.Drawing.Point(951, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.OnHoverImage = null;
            this.closebtn.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.closebtn.Size = new System.Drawing.Size(32, 29);
            this.closebtn.TabIndex = 61;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(54, 48);
            this.gunaImageButton1.TabIndex = 60;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Priceperunitlbl);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.btnCancelM);
            this.Controls.Add(this.btnDeleteM);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.expireDatelbl);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtExpireDate);
            this.Controls.Add(this.lblManufacturingDate);
            this.Controls.Add(this.txtManufacturingDate);
            this.Controls.Add(this.medicinelbl);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.lblAddMedicine);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.gunaImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMedicine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.Label Priceperunitlbl;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private Guna.UI2.WinForms.Guna2Button btnAddM;
        private Guna.UI2.WinForms.Guna2Button btnCancelM;
        private Guna.UI2.WinForms.Guna2Button btnDeleteM;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label expireDatelbl;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtExpireDate;
        private System.Windows.Forms.Label lblManufacturingDate;
        private System.Windows.Forms.TextBox txtManufacturingDate;
        private System.Windows.Forms.Label medicinelbl;
        private System.Windows.Forms.TextBox txtMediName;
        private System.Windows.Forms.Label lblAddMedicine;
        private Guna.UI.WinForms.GunaImageButton closebtn;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}