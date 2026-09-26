namespace ComLabManager.UI;
    partial class MainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        pnlHeader = new Panel();
        lblPageTitle = new Label();
        lblCurrentUser = new Label();
        btnNavDashboard = new Button();
        btnNavEquipment = new Button();
        btnNavTickets = new Button();
        btnNavSpareParts = new Button();
        btnNavScheduler = new Button();
        btnSignOut = new Button();
        pnlLogo = new Panel();
        pbLogo = new PictureBox();
        label1 = new Label();
        lblMonitor = new Label();
        lblAssets = new Label();
        lblMaintenance = new Label();
        pnlSidebar = new Panel();
        pnlMainContent = new Panel();
        pnlActionToolbar = new Panel();
        txtSearch = new TextBox();
        btnSearch = new Button();
        btnAddEquipment = new Button();
        dgvEquipment = new DataGridView();
        Id = new DataGridViewTextBoxColumn();
        Name = new DataGridViewTextBoxColumn();
        SerialNumber = new DataGridViewTextBoxColumn();
        Category = new DataGridViewTextBoxColumn();
        Status = new DataGridViewTextBoxColumn();
        Location = new DataGridViewTextBoxColumn();
        DateAcquired = new DataGridViewTextBoxColumn();
        pnlHeader.SuspendLayout();
        pnlLogo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
        pnlSidebar.SuspendLayout();
        pnlMainContent.SuspendLayout();
        pnlActionToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.White;
        pnlHeader.Controls.Add(lblPageTitle);
        pnlHeader.Controls.Add(lblCurrentUser);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(220, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(958, 80);
        pnlHeader.TabIndex = 1;
        // 
        // lblPageTitle
        // 
        lblPageTitle.AutoSize = true;
        lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPageTitle.Location = new Point(59, 18);
        lblPageTitle.Name = "lblPageTitle";
        lblPageTitle.Size = new Size(159, 38);
        lblPageTitle.TabIndex = 2;
        lblPageTitle.Text = "Dashboard";
        // 
        // lblCurrentUser
        // 
        lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCurrentUser.AutoSize = true;
        lblCurrentUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCurrentUser.ForeColor = Color.DarkGray;
        lblCurrentUser.Location = new Point(827, 26);
        lblCurrentUser.Name = "lblCurrentUser";
        lblCurrentUser.Size = new Size(0, 28);
        lblCurrentUser.TabIndex = 6;
        // 
        // btnNavDashboard
        // 
        btnNavDashboard.BackColor = Color.FromArgb(30, 41, 59);
        btnNavDashboard.FlatAppearance.BorderSize = 0;
        btnNavDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavDashboard.FlatStyle = FlatStyle.Flat;
        btnNavDashboard.ForeColor = Color.White;
        btnNavDashboard.Location = new Point(0, 122);
        btnNavDashboard.Name = "btnNavDashboard";
        btnNavDashboard.Padding = new Padding(15, 0, 0, 0);
        btnNavDashboard.Size = new Size(220, 45);
        btnNavDashboard.TabIndex = 0;
        btnNavDashboard.Text = "Dashboard";
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnNavDashboard.UseVisualStyleBackColor = false;
        btnNavDashboard.Click += btnDashboard_Click;
        // 
        // btnNavEquipment
        // 
        btnNavEquipment.BackColor = Color.FromArgb(30, 41, 59);
        btnNavEquipment.FlatAppearance.BorderSize = 0;
        btnNavEquipment.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavEquipment.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavEquipment.FlatStyle = FlatStyle.Flat;
        btnNavEquipment.ForeColor = Color.White;
        btnNavEquipment.Location = new Point(0, 232);
        btnNavEquipment.Name = "btnNavEquipment";
        btnNavEquipment.Padding = new Padding(15, 0, 0, 0);
        btnNavEquipment.Size = new Size(220, 45);
        btnNavEquipment.TabIndex = 1;
        btnNavEquipment.Text = "Inventory";
        btnNavEquipment.TextAlign = ContentAlignment.MiddleLeft;
        btnNavEquipment.UseVisualStyleBackColor = false;
        btnNavEquipment.Click += btnNavEquipment_Click;
        // 
        // btnNavTickets
        // 
        btnNavTickets.BackColor = Color.FromArgb(30, 41, 59);
        btnNavTickets.FlatAppearance.BorderSize = 0;
        btnNavTickets.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavTickets.FlatStyle = FlatStyle.Flat;
        btnNavTickets.ForeColor = Color.White;
        btnNavTickets.Location = new Point(0, 335);
        btnNavTickets.Name = "btnNavTickets";
        btnNavTickets.Padding = new Padding(15, 0, 0, 0);
        btnNavTickets.Size = new Size(220, 45);
        btnNavTickets.TabIndex = 2;
        btnNavTickets.Text = "Maintenance ";
        btnNavTickets.TextAlign = ContentAlignment.MiddleLeft;
        btnNavTickets.UseVisualStyleBackColor = false;
        btnNavTickets.Click += btnNavTickets_Click;
        // 
        // btnNavSpareParts
        // 
        btnNavSpareParts.BackColor = Color.FromArgb(30, 41, 59);
        btnNavSpareParts.FlatAppearance.BorderSize = 0;
        btnNavSpareParts.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavSpareParts.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavSpareParts.FlatStyle = FlatStyle.Flat;
        btnNavSpareParts.ForeColor = Color.White;
        btnNavSpareParts.Location = new Point(0, 386);
        btnNavSpareParts.Name = "btnNavSpareParts";
        btnNavSpareParts.Padding = new Padding(15, 0, 0, 0);
        btnNavSpareParts.Size = new Size(220, 45);
        btnNavSpareParts.TabIndex = 3;
        btnNavSpareParts.Text = "Spare Parts";
        btnNavSpareParts.TextAlign = ContentAlignment.MiddleLeft;
        btnNavSpareParts.UseVisualStyleBackColor = false;
        btnNavSpareParts.Click += btnNavSpareParts_Click;
        // 
        // btnNavScheduler
        // 
        btnNavScheduler.BackColor = Color.FromArgb(30, 41, 59);
        btnNavScheduler.FlatAppearance.BorderSize = 0;
        btnNavScheduler.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavScheduler.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavScheduler.FlatStyle = FlatStyle.Flat;
        btnNavScheduler.ForeColor = Color.White;
        btnNavScheduler.Location = new Point(0, 437);
        btnNavScheduler.Name = "btnNavScheduler";
        btnNavScheduler.Padding = new Padding(15, 0, 0, 0);
        btnNavScheduler.Size = new Size(220, 45);
        btnNavScheduler.TabIndex = 4;
        btnNavScheduler.Text = "PM Scheduler";
        btnNavScheduler.TextAlign = ContentAlignment.MiddleLeft;
        btnNavScheduler.UseVisualStyleBackColor = false;
        btnNavScheduler.Click += btnNavScheduler_Click;
        // 
        // btnSignOut
        // 
        btnSignOut.BackColor = Color.FromArgb(30, 41, 59);
        btnSignOut.Dock = DockStyle.Bottom;
        btnSignOut.FlatAppearance.BorderSize = 0;
        btnSignOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
        btnSignOut.FlatAppearance.MouseOverBackColor = Color.Gray;
        btnSignOut.FlatStyle = FlatStyle.Flat;
        btnSignOut.ForeColor = Color.White;
        btnSignOut.Location = new Point(0, 599);
        btnSignOut.Name = "btnSignOut";
        btnSignOut.Padding = new Padding(15, 0, 0, 10);
        btnSignOut.Size = new Size(220, 45);
        btnSignOut.TabIndex = 4;
        btnSignOut.Text = "Sign Out";
        btnSignOut.TextAlign = ContentAlignment.MiddleLeft;
        btnSignOut.UseVisualStyleBackColor = false;
        btnSignOut.Click += btnSignOut_Click;
        // 
        // pnlLogo
        // 
        pnlLogo.BackColor = Color.FromArgb(30, 41, 59);
        pnlLogo.Controls.Add(pbLogo);
        pnlLogo.Controls.Add(label1);
        pnlLogo.Dock = DockStyle.Top;
        pnlLogo.Location = new Point(0, 0);
        pnlLogo.Name = "pnlLogo";
        pnlLogo.Size = new Size(220, 70);
        pnlLogo.TabIndex = 5;
        // 
        // pbLogo
        // 
        pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
        pbLogo.Location = new Point(11, 12);
        pbLogo.Name = "pbLogo";
        pbLogo.Size = new Size(49, 48);
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pbLogo.TabIndex = 7;
        pbLogo.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.FromArgb(148, 163, 184);
        label1.Location = new Point(65, 10);
        label1.Name = "label1";
        label1.Padding = new Padding(0, 15, 5, 10);
        label1.Size = new Size(124, 46);
        label1.TabIndex = 6;
        label1.Text = "LABMANAGER";
        // 
        // lblMonitor
        // 
        lblMonitor.AutoSize = true;
        lblMonitor.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMonitor.ForeColor = Color.FromArgb(148, 163, 184);
        lblMonitor.Location = new Point(6, 73);
        lblMonitor.Name = "lblMonitor";
        lblMonitor.Padding = new Padding(0, 15, 5, 10);
        lblMonitor.Size = new Size(90, 46);
        lblMonitor.TabIndex = 6;
        lblMonitor.Text = "MONITOR";
        // 
        // lblAssets
        // 
        lblAssets.AutoSize = true;
        lblAssets.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblAssets.ForeColor = Color.FromArgb(148, 163, 184);
        lblAssets.Location = new Point(6, 174);
        lblAssets.Name = "lblAssets";
        lblAssets.Padding = new Padding(0, 15, 5, 10);
        lblAssets.Size = new Size(71, 46);
        lblAssets.TabIndex = 6;
        lblAssets.Text = "ASSETS";
        lblAssets.Click += label1_Click;
        // 
        // lblMaintenance
        // 
        lblMaintenance.AutoSize = true;
        lblMaintenance.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMaintenance.ForeColor = Color.FromArgb(148, 163, 184);
        lblMaintenance.Location = new Point(6, 280);
        lblMaintenance.Name = "lblMaintenance";
        lblMaintenance.Padding = new Padding(0, 15, 5, 10);
        lblMaintenance.Size = new Size(133, 46);
        lblMaintenance.TabIndex = 6;
        lblMaintenance.Text = "MAINTENANCE";
        lblMaintenance.Click += label1_Click;
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(30, 41, 59);
        pnlSidebar.Controls.Add(lblMaintenance);
        pnlSidebar.Controls.Add(lblAssets);
        pnlSidebar.Controls.Add(lblMonitor);
        pnlSidebar.Controls.Add(pnlLogo);
        pnlSidebar.Controls.Add(btnSignOut);
        pnlSidebar.Controls.Add(btnNavScheduler);
        pnlSidebar.Controls.Add(btnNavSpareParts);
        pnlSidebar.Controls.Add(btnNavTickets);
        pnlSidebar.Controls.Add(btnNavEquipment);
        pnlSidebar.Controls.Add(btnNavDashboard);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(220, 644);
        pnlSidebar.TabIndex = 1;
        // 
        // pnlMainContent
        // 
        pnlMainContent.Controls.Add(dgvEquipment);
        pnlMainContent.Controls.Add(pnlActionToolbar);
        pnlMainContent.Dock = DockStyle.Fill;
        pnlMainContent.Location = new Point(220, 80);
        pnlMainContent.Name = "pnlMainContent";
        pnlMainContent.Size = new Size(958, 564);
        pnlMainContent.TabIndex = 2;
        // 
        // pnlActionToolbar
        // 
        pnlActionToolbar.Controls.Add(btnAddEquipment);
        pnlActionToolbar.Controls.Add(btnSearch);
        pnlActionToolbar.Controls.Add(txtSearch);
        pnlActionToolbar.Dock = DockStyle.Top;
        pnlActionToolbar.Location = new Point(0, 0);
        pnlActionToolbar.Name = "pnlActionToolbar";
        pnlActionToolbar.Size = new Size(958, 60);
        pnlActionToolbar.TabIndex = 0;
        // 
        // txtSearch
        // 
        txtSearch.BorderStyle = BorderStyle.FixedSingle;
        txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtSearch.Location = new Point(31, 16);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(300, 34);
        txtSearch.TabIndex = 0;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.FromArgb(30, 41, 59);
        btnSearch.FlatAppearance.BorderColor = Color.White;
        btnSearch.FlatAppearance.BorderSize = 0;
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSearch.ForeColor = Color.White;
        btnSearch.Location = new Point(380, 16);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(115, 34);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        // 
        // btnAddEquipment
        // 
        btnAddEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddEquipment.BackColor = Color.FromArgb(25, 135, 84);
        btnAddEquipment.FlatAppearance.BorderSize = 0;
        btnAddEquipment.FlatStyle = FlatStyle.Flat;
        btnAddEquipment.ForeColor = Color.White;
        btnAddEquipment.Location = new Point(711, 15);
        btnAddEquipment.Name = "btnAddEquipment";
        btnAddEquipment.Size = new Size(197, 34);
        btnAddEquipment.TabIndex = 3;
        btnAddEquipment.Text = "+ Add Equipment";
        btnAddEquipment.UseVisualStyleBackColor = false;
        // 
        // dgvEquipment
        // 
        dgvEquipment.AllowUserToAddRows = false;
        dgvEquipment.AllowUserToDeleteRows = false;
        dgvEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEquipment.BackgroundColor = Color.FromArgb(248, 249, 250);
        dgvEquipment.BorderStyle = BorderStyle.None;
        dgvEquipment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { Id, Name, SerialNumber, Category, Status, Location, DateAcquired });
        dgvEquipment.Dock = DockStyle.Fill;
        dgvEquipment.Location = new Point(0, 60);
        dgvEquipment.Name = "dgvEquipment";
        dgvEquipment.ReadOnly = true;
        dgvEquipment.RowHeadersVisible = false;
        dgvEquipment.RowHeadersWidth = 62;
        dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEquipment.Size = new Size(958, 504);
        dgvEquipment.TabIndex = 1;
        // 
        // Id
        // 
        Id.HeaderText = "Id";
        Id.MinimumWidth = 8;
        Id.Name = "Id";
        Id.ReadOnly = true;
        Id.Visible = false;
        // 
        // Name
        // 
        Name.HeaderText = "Equipment Name";
        Name.MinimumWidth = 8;
        Name.Name = "Name";
        Name.ReadOnly = true;
        // 
        // SerialNumber
        // 
        SerialNumber.HeaderText = "Serial Number";
        SerialNumber.MinimumWidth = 8;
        SerialNumber.Name = "SerialNumber";
        SerialNumber.ReadOnly = true;
        // 
        // Category
        // 
        Category.HeaderText = "Category";
        Category.MinimumWidth = 8;
        Category.Name = "Category";
        Category.ReadOnly = true;
        // 
        // Status
        // 
        Status.HeaderText = "Status";
        Status.MinimumWidth = 8;
        Status.Name = "Status";
        Status.ReadOnly = true;
        // 
        // Location
        // 
        Location.HeaderText = "Location";
        Location.MinimumWidth = 8;
        Location.Name = "Location";
        Location.ReadOnly = true;
        // 
        // DateAcquired
        // 
        DateAcquired.HeaderText = "Date Acquired";
        DateAcquired.MinimumWidth = 8;
        DateAcquired.Name = "DateAcquired";
        DateAcquired.ReadOnly = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 249, 250);
        ClientSize = new Size(1178, 644);
        Controls.Add(pnlMainContent);
        Controls.Add(pnlHeader);
        Controls.Add(pnlSidebar);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LabManager-Computer Laboratory System";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlLogo.ResumeLayout(false);
        pnlLogo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
        pnlSidebar.ResumeLayout(false);
        pnlSidebar.PerformLayout();
        pnlMainContent.ResumeLayout(false);
        pnlActionToolbar.ResumeLayout(false);
        pnlActionToolbar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
        ResumeLayout(false);
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion
    private Panel pnlHeader;
    private Label lblPageTitle;
    private Label lblCurrentUser;
    private Button btnNavDashboard;
    private Button btnNavEquipment;
    private Button btnNavTickets;
    private Button btnNavSpareParts;
    private Button btnNavScheduler;
    private Button btnSignOut;
    private Panel pnlLogo;
    private Label label1;
    private Label lblMonitor;
    private Label lblAssets;
    private Label lblMaintenance;
    private Panel pnlSidebar;
    private Panel pnlMainContent;
    private PictureBox pbLogo;
    private Panel pnlActionToolbar;
    private TextBox txtSearch;
    private Button btnAddEquipment;
    private Button btnSearch;
    private DataGridView dgvEquipment;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Name;
    private DataGridViewTextBoxColumn SerialNumber;
    private DataGridViewTextBoxColumn Category;
    private DataGridViewTextBoxColumn Status;
    private DataGridViewTextBoxColumn Location;
    private DataGridViewTextBoxColumn DateAcquired;
}

