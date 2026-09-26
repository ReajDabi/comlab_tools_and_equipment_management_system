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
            dataGridView1 = new DataGridView();
            ticket = new DataGridViewTextBoxColumn();
            equipment = new DataGridViewTextBoxColumn();
            stauts = new DataGridViewTextBoxColumn();
            reported = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ticket, equipment, stauts, reported, cost });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(675, 564);
            dataGridView1.TabIndex = 0;
            // 
            // ticket
            // 
            ticket.HeaderText = "Ticket";
            ticket.MinimumWidth = 6;
            ticket.Name = "ticket";
            ticket.Width = 125;
            // 
            // equipment
            // 
            equipment.HeaderText = "Equipment";
            equipment.MinimumWidth = 6;
            equipment.Name = "equipment";
            equipment.Width = 125;
            // 
            // stauts
            // 
            stauts.HeaderText = "Status";
            stauts.MinimumWidth = 6;
            stauts.Name = "stauts";
            stauts.Width = 125;
            // 
            // reported
            // 
            reported.HeaderText = "Reported";
            reported.MinimumWidth = 6;
            reported.Name = "reported";
            reported.Width = 125;
            // 
            // cost
            // 
            cost.HeaderText = "Cost";
            cost.MinimumWidth = 6;
            cost.Name = "cost";
            cost.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 41, 59);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(681, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Repair Ticket";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "Equipment";
            // 
            // MaintenanceView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "MaintenanceView";
            Size = new Size(958, 564);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ticket;
        private DataGridViewTextBoxColumn equipment;
        private DataGridViewTextBoxColumn stauts;
        private DataGridViewTextBoxColumn reported;
        private DataGridViewTextBoxColumn cost;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
    }
}
