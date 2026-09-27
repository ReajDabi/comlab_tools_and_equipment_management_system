namespace ComLabManager.UI
{
    partial class EquipmentForm
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
            pnlHeader = new Panel();
            lblAddEditEquipment = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            lblName = new Label();
            txtSerialNumber = new TextBox();
            lblSerialNumber = new Label();
            lblCategory = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtLocation = new TextBox();
            lblLocation = new Label();
            dtpDateAcquired = new DateTimePicker();
            lblDateAcquired = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            pnlFooter = new Panel();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblAddEditEquipment);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(428, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblAddEditEquipment
            // 
            lblAddEditEquipment.AutoSize = true;
            lblAddEditEquipment.BackColor = Color.Transparent;
            lblAddEditEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddEditEquipment.ForeColor = Color.White;
            lblAddEditEquipment.Location = new Point(92, 11);
            lblAddEditEquipment.Name = "lblAddEditEquipment";
            lblAddEditEquipment.Size = new Size(247, 32);
            lblAddEditEquipment.TabIndex = 0;
            lblAddEditEquipment.Text = "Add/Edit Equipment";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(81, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 31);
            txtName.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "System Unit", "Monitor", "Peripheral", "Networking" });
            cmbCategory.Location = new Point(81, 229);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(273, 33);
            cmbCategory.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(73, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 25);
            lblName.TabIndex = 4;
            lblName.Text = "Equipment Name";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.BorderStyle = BorderStyle.FixedSingle;
            txtSerialNumber.Location = new Point(81, 166);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(274, 31);
            txtSerialNumber.TabIndex = 2;
            // 
            // lblSerialNumber
            // 
            lblSerialNumber.AutoSize = true;
            lblSerialNumber.Location = new Point(73, 137);
            lblSerialNumber.Name = "lblSerialNumber";
            lblSerialNumber.Size = new Size(124, 25);
            lblSerialNumber.TabIndex = 4;
            lblSerialNumber.Text = "Serial Number";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(73, 201);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 25);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Under Repair", "Decommissioned" });
            cmbStatus.Location = new Point(82, 290);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(273, 33);
            cmbStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(75, 262);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Location = new Point(83, 359);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(270, 31);
            txtLocation.TabIndex = 2;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(74, 327);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(79, 25);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location";
            // 
            // dtpDateAcquired
            // 
            dtpDateAcquired.Format = DateTimePickerFormat.Short;
            dtpDateAcquired.Location = new Point(81, 427);
            dtpDateAcquired.Name = "dtpDateAcquired";
            dtpDateAcquired.Size = new Size(272, 31);
            dtpDateAcquired.TabIndex = 5;
            // 
            // lblDateAcquired
            // 
            lblDateAcquired.AutoSize = true;
            lblDateAcquired.Location = new Point(72, 397);
            lblDateAcquired.Name = "lblDateAcquired";
            lblDateAcquired.Size = new Size(125, 25);
            lblDateAcquired.TabIndex = 4;
            lblDateAcquired.Text = "Date Acquired";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ScrollBar;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(80, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(241, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.DarkGray;
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 484);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(428, 60);
            pnlFooter.TabIndex = 7;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(428, 544);
            Controls.Add(pnlFooter);
            Controls.Add(dtpDateAcquired);
            Controls.Add(lblStatus);
            Controls.Add(lblCategory);
            Controls.Add(lblDateAcquired);
            Controls.Add(lblLocation);
            Controls.Add(lblSerialNumber);
            Controls.Add(lblName);
            Controls.Add(cmbStatus);
            Controls.Add(cmbCategory);
            Controls.Add(txtLocation);
            Controls.Add(txtSerialNumber);
            Controls.Add(txtName);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EquipmentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EquipmentForm";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAddEditEquipment;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private Label lblName;
        private TextBox txtSerialNumber;
        private Label lblSerialNumber;
        private Label lblCategory;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private TextBox txtLocation;
        private Label lblLocation;
        private DateTimePicker dtpDateAcquired;
        private Label lblDateAcquired;
        private Button btnCancel;
        private Button btnSave;
        private Panel pnlFooter;
    }
}