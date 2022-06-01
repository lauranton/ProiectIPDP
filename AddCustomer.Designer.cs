
namespace DermaFram
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.closebtn = new Guna.UI.WinForms.GunaImageButton();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.nrtellbl = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNrtel = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.customerIDlbl = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddC = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelC = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteC = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nrtel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddCustomer.Location = new System.Drawing.Point(84, 27);
            this.lblAddCustomer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(221, 37);
            this.lblAddCustomer.TabIndex = 23;
            this.lblAddCustomer.Text = "Add Customer";
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
            this.gunaImageButton1.TabIndex = 29;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
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
            this.closebtn.TabIndex = 30;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(26, 340);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(95, 29);
            this.lblAdresa.TabIndex = 38;
            this.lblAdresa.Text = "Adresa";
            // 
            // nrtellbl
            // 
            this.nrtellbl.AutoSize = true;
            this.nrtellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nrtellbl.Location = new System.Drawing.Point(26, 248);
            this.nrtellbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrtellbl.Name = "nrtellbl";
            this.nrtellbl.Size = new System.Drawing.Size(77, 29);
            this.nrtellbl.TabIndex = 37;
            this.nrtellbl.Text = "Nr tel";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(22, 373);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(334, 58);
            this.txtAdresa.TabIndex = 36;
            // 
            // txtNrtel
            // 
            this.txtNrtel.Location = new System.Drawing.Point(22, 281);
            this.txtNrtel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNrtel.Multiline = true;
            this.txtNrtel.Name = "txtNrtel";
            this.txtNrtel.Size = new System.Drawing.Size(334, 55);
            this.txtNrtel.TabIndex = 35;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCustomerName.Location = new System.Drawing.Point(23, 156);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(201, 29);
            this.lblCustomerName.TabIndex = 34;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(22, 189);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(334, 55);
            this.txtCustName.TabIndex = 33;
            // 
            // customerIDlbl
            // 
            this.customerIDlbl.AutoSize = true;
            this.customerIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customerIDlbl.Location = new System.Drawing.Point(26, 64);
            this.customerIDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerIDlbl.Name = "customerIDlbl";
            this.customerIDlbl.Size = new System.Drawing.Size(150, 29);
            this.customerIDlbl.TabIndex = 32;
            this.customerIDlbl.Text = "CustomerID";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(22, 97);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustID.Multiline = true;
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(334, 55);
            this.txtCustID.TabIndex = 31;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Nrtel,
            this.Adresa});
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.Location = new System.Drawing.Point(379, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(579, 470);
            this.dataGridView2.TabIndex = 39;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // btnAddC
            // 
            this.btnAddC.AutoRoundedCorners = true;
            this.btnAddC.BorderRadius = 27;
            this.btnAddC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnAddC.CheckedState.Parent = this.btnAddC;
            this.btnAddC.CustomImages.Parent = this.btnAddC;
            this.btnAddC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddC.ForeColor = System.Drawing.Color.White;
            this.btnAddC.HoverState.Parent = this.btnAddC;
            this.btnAddC.Location = new System.Drawing.Point(48, 448);
            this.btnAddC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.ShadowDecoration.Parent = this.btnAddC;
            this.btnAddC.Size = new System.Drawing.Size(80, 56);
            this.btnAddC.TabIndex = 43;
            this.btnAddC.Text = "Add";
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnCancelC
            // 
            this.btnCancelC.AutoRoundedCorners = true;
            this.btnCancelC.BorderRadius = 27;
            this.btnCancelC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnCancelC.CheckedState.Parent = this.btnCancelC;
            this.btnCancelC.CustomImages.Parent = this.btnCancelC;
            this.btnCancelC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelC.ForeColor = System.Drawing.Color.White;
            this.btnCancelC.HoverState.Parent = this.btnCancelC;
            this.btnCancelC.Location = new System.Drawing.Point(248, 448);
            this.btnCancelC.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelC.Name = "btnCancelC";
            this.btnCancelC.ShadowDecoration.Parent = this.btnCancelC;
            this.btnCancelC.Size = new System.Drawing.Size(80, 56);
            this.btnCancelC.TabIndex = 41;
            this.btnCancelC.Text = "Cancel";
            this.btnCancelC.Click += new System.EventHandler(this.btnCancelC_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.AutoRoundedCorners = true;
            this.btnDeleteC.BorderRadius = 27;
            this.btnDeleteC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnDeleteC.CheckedState.Parent = this.btnDeleteC;
            this.btnDeleteC.CustomImages.Parent = this.btnDeleteC;
            this.btnDeleteC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteC.ForeColor = System.Drawing.Color.White;
            this.btnDeleteC.HoverState.Parent = this.btnDeleteC;
            this.btnDeleteC.Location = new System.Drawing.Point(144, 448);
            this.btnDeleteC.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.ShadowDecoration.Parent = this.btnDeleteC;
            this.btnDeleteC.Size = new System.Drawing.Size(80, 56);
            this.btnDeleteC.TabIndex = 40;
            this.btnDeleteC.Text = "Delete";
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Nrtel
            // 
            this.Nrtel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nrtel.DataPropertyName = "Nrtel";
            this.Nrtel.HeaderText = "Nrtel";
            this.Nrtel.MinimumWidth = 6;
            this.Nrtel.Name = "Nrtel";
            this.Nrtel.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.MinimumWidth = 6;
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 533);
            this.Controls.Add(this.btnAddC);
            this.Controls.Add(this.btnCancelC);
            this.Controls.Add(this.btnDeleteC);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.nrtellbl);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNrtel);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.customerIDlbl);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.lblAddCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCustomer;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaImageButton closebtn;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label nrtellbl;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNrtel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label customerIDlbl;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2Button btnAddC;
        private Guna.UI2.WinForms.Guna2Button btnCancelC;
        private Guna.UI2.WinForms.Guna2Button btnDeleteC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nrtel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
    }
}