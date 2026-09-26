namespace ComLabManager.UI
{
    partial class MaintenanceView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ticket = new DataGridViewTextBoxColumn();
            equipment = new DataGridViewTextBoxColumn();
            issue = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Navy;
            button1.Cursor = Cursors.NoMove2D;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(860, 560);
            button1.Name = "button1";
            button1.Size = new Size(193, 62);
            button1.TabIndex = 0;
            button1.Text = "Create Ticket";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ticket, equipment, issue, status, cost });
            dataGridView1.Location = new Point(-3, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1076, 646);
            dataGridView1.TabIndex = 1;
            // 
            // ticket
            // 
            ticket.HeaderText = "Ticket";
            ticket.MinimumWidth = 6;
            ticket.Name = "ticket";
            ticket.ReadOnly = true;
            // 
            // equipment
            // 
            equipment.HeaderText = "Equipment";
            equipment.MinimumWidth = 6;
            equipment.Name = "equipment";
            equipment.ReadOnly = true;
            // 
            // issue
            // 
            issue.HeaderText = "Issue";
            issue.MinimumWidth = 6;
            issue.Name = "issue";
            issue.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // cost
            // 
            cost.HeaderText = "Cost";
            cost.MinimumWidth = 6;
            cost.Name = "cost";
            cost.ReadOnly = true;
            // 
            // MaintenanceView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10F);
            Name = "MaintenanceView";
            Size = new Size(1076, 646);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ticket;
        private DataGridViewTextBoxColumn equipment;
        private DataGridViewTextBoxColumn issue;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn cost;
    }
}
