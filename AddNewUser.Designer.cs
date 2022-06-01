
namespace DermaFram
{
    partial class AddNewUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.ipdpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtnewuseName = new System.Windows.Forms.TextBox();
            this.newuserName = new System.Windows.Forms.Label();
            this.HireDatelabel = new System.Windows.Forms.Label();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtnewuserPassword = new System.Windows.Forms.TextBox();
            this.NewUserDelete = new Guna.UI2.WinForms.Guna2Button();
            this.NewUserCancel = new Guna.UI2.WinForms.Guna2Button();
            this.NewUserupdate = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newuserUsernamelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closebtn = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ipdpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // txtnewuseName
            // 
            this.txtnewuseName.Location = new System.Drawing.Point(42, 108);
            this.txtnewuseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewuseName.Multiline = true;
            this.txtnewuseName.Name = "txtnewuseName";
            this.txtnewuseName.Size = new System.Drawing.Size(386, 55);
            this.txtnewuseName.TabIndex = 10;
            // 
            // newuserName
            // 
            this.newuserName.AutoSize = true;
            this.newuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newuserName.Location = new System.Drawing.Point(46, 75);
            this.newuserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newuserName.Name = "newuserName";
            this.newuserName.Size = new System.Drawing.Size(82, 29);
            this.newuserName.TabIndex = 12;
            this.newuserName.Text = "Nume";
            this.newuserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // HireDatelabel
            // 
            this.HireDatelabel.AutoSize = true;
            this.HireDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HireDatelabel.Location = new System.Drawing.Point(43, 167);
            this.HireDatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HireDatelabel.Name = "HireDatelabel";
            this.HireDatelabel.Size = new System.Drawing.Size(123, 29);
            this.HireDatelabel.TabIndex = 14;
            this.HireDatelabel.Text = "Hire Date";
            this.HireDatelabel.Click += new System.EventHandler(this.HireDate_Click);
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(42, 200);
            this.txtHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtHireDate.Multiline = true;
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(386, 55);
            this.txtHireDate.TabIndex = 13;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(42, 292);
            this.txtNewUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewUsername.Multiline = true;
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(386, 55);
            this.txtNewUsername.TabIndex = 15;
            // 
            // txtnewuserPassword
            // 
            this.txtnewuserPassword.Location = new System.Drawing.Point(42, 384);
            this.txtnewuserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewuserPassword.Multiline = true;
            this.txtnewuserPassword.Name = "txtnewuserPassword";
            this.txtnewuserPassword.Size = new System.Drawing.Size(386, 58);
            this.txtnewuserPassword.TabIndex = 17;
            // 
            // NewUserDelete
            // 
            this.NewUserDelete.AutoRoundedCorners = true;
            this.NewUserDelete.BorderRadius = 27;
            this.NewUserDelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.NewUserDelete.CheckedState.Parent = this.NewUserDelete;
            this.NewUserDelete.CustomImages.Parent = this.NewUserDelete;
            this.NewUserDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewUserDelete.ForeColor = System.Drawing.Color.White;
            this.NewUserDelete.HoverState.Parent = this.NewUserDelete;
            this.NewUserDelete.Location = new System.Drawing.Point(142, 469);
            this.NewUserDelete.Margin = new System.Windows.Forms.Padding(4);
            this.NewUserDelete.Name = "NewUserDelete";
            this.NewUserDelete.ShadowDecoration.Parent = this.NewUserDelete;
            this.NewUserDelete.Size = new System.Drawing.Size(80, 56);
            this.NewUserDelete.TabIndex = 19;
            this.NewUserDelete.Text = "Delete";
            this.NewUserDelete.Click += new System.EventHandler(this.NewUserDelete_Click);
            // 
            // NewUserCancel
            // 
            this.NewUserCancel.AutoRoundedCorners = true;
            this.NewUserCancel.BorderRadius = 27;
            this.NewUserCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.NewUserCancel.CheckedState.Parent = this.NewUserCancel;
            this.NewUserCancel.CustomImages.Parent = this.NewUserCancel;
            this.NewUserCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewUserCancel.ForeColor = System.Drawing.Color.White;
            this.NewUserCancel.HoverState.Parent = this.NewUserCancel;
            this.NewUserCancel.Location = new System.Drawing.Point(246, 469);
            this.NewUserCancel.Margin = new System.Windows.Forms.Padding(4);
            this.NewUserCancel.Name = "NewUserCancel";
            this.NewUserCancel.ShadowDecoration.Parent = this.NewUserCancel;
            this.NewUserCancel.Size = new System.Drawing.Size(80, 56);
            this.NewUserCancel.TabIndex = 20;
            this.NewUserCancel.Text = "Cancel";
            this.NewUserCancel.Click += new System.EventHandler(this.NewUserCancel_Click);
            // 
            // NewUserupdate
            // 
            this.NewUserupdate.AutoRoundedCorners = true;
            this.NewUserupdate.BorderRadius = 27;
            this.NewUserupdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.NewUserupdate.CheckedState.Parent = this.NewUserupdate;
            this.NewUserupdate.CustomImages.Parent = this.NewUserupdate;
            this.NewUserupdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewUserupdate.ForeColor = System.Drawing.Color.White;
            this.NewUserupdate.HoverState.Parent = this.NewUserupdate;
            this.NewUserupdate.Location = new System.Drawing.Point(348, 469);
            this.NewUserupdate.Margin = new System.Windows.Forms.Padding(4);
            this.NewUserupdate.Name = "NewUserupdate";
            this.NewUserupdate.ShadowDecoration.Parent = this.NewUserupdate;
            this.NewUserupdate.Size = new System.Drawing.Size(80, 56);
            this.NewUserupdate.TabIndex = 21;
            this.NewUserupdate.Text = "Edit";
            this.NewUserupdate.Click += new System.EventHandler(this.NewUserupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add New User";
            // 
            // newuserUsernamelbl
            // 
            this.newuserUsernamelbl.AutoSize = true;
            this.newuserUsernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newuserUsernamelbl.Location = new System.Drawing.Point(46, 259);
            this.newuserUsernamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newuserUsernamelbl.Name = "newuserUsernamelbl";
            this.newuserUsernamelbl.Size = new System.Drawing.Size(128, 29);
            this.newuserUsernamelbl.TabIndex = 23;
            this.newuserUsernamelbl.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "password";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.AutoRoundedCorners = true;
            this.btnAddNewUser.BorderRadius = 27;
            this.btnAddNewUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnAddNewUser.CheckedState.Parent = this.btnAddNewUser;
            this.btnAddNewUser.CustomImages.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.HoverState.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Location = new System.Drawing.Point(46, 469);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.ShadowDecoration.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Size = new System.Drawing.Size(80, 56);
            this.btnAddNewUser.TabIndex = 25;
            this.btnAddNewUser.Text = "Add";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.Name,
            this.username,
            this.password,
            this.hireDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvUser.Location = new System.Drawing.Point(489, 42);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(473, 504);
            this.dgvUser.TabIndex = 26;
            this.dgvUser.DoubleClick += new System.EventHandler(this.dgvUser_DoubleClick);
            // 
            // userID
            // 
            this.userID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userID.DataPropertyName = "userID";
            this.userID.HeaderText = "userID";
            this.userID.MinimumWidth = 6;
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "NameUser";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // hireDate
            // 
            this.hireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hireDate.DataPropertyName = "hireDate";
            this.hireDate.HeaderText = "hireDate";
            this.hireDate.MinimumWidth = 6;
            this.hireDate.Name = "hireDate";
            this.hireDate.ReadOnly = true;
            // 
            // closebtn
            // 
            this.closebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImageSize = new System.Drawing.Size(64, 64);
            this.closebtn.Location = new System.Drawing.Point(968, -1);
            this.closebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.OnHoverImage = null;
            this.closebtn.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.closebtn.Size = new System.Drawing.Size(32, 29);
            this.closebtn.TabIndex = 27;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(0, -1);
            this.gunaImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(54, 48);
            this.gunaImageButton1.TabIndex = 28;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newuserUsernamelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewUserupdate);
            this.Controls.Add(this.NewUserCancel);
            this.Controls.Add(this.NewUserDelete);
            this.Controls.Add(this.txtnewuserPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.HireDatelabel);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.newuserName);
            this.Controls.Add(this.txtnewuseName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "AddNewUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipdpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnewuseName;
        private System.Windows.Forms.Label newuserName;
        private System.Windows.Forms.Label HireDatelabel;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtnewuserPassword;
        private Guna.UI2.WinForms.Guna2Button NewUserDelete;
        private Guna.UI2.WinForms.Guna2Button NewUserCancel;
        private Guna.UI2.WinForms.Guna2Button NewUserupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newuserUsernamelbl;
        private System.Windows.Forms.Label label2;
      //  private DermaDataSet dermaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
      //  private DermaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource ipdpDataSetBindingSource;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDate;
        private Guna.UI.WinForms.GunaImageButton closebtn;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}