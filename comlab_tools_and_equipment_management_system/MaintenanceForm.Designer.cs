namespace ComLabManager.UI
{
    partial class MaintenanceForm
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            colEquipmentId = new DataGridViewTextBoxColumn();
            colIssueDescription = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colDateReported = new DataGridViewTextBoxColumn();
            colRepariCost = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colEquipmentId, colIssueDescription, colStatus, colDateReported, colRepariCost });
            dataGridView1.Location = new Point(29, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(688, 197);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 329);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(679, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 306);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 32);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "Logs";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 470);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(273, 520);
            button1.Name = "button1";
            button1.Size = new Size(191, 52);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // colEquipmentId
            // 
            colEquipmentId.HeaderText = "Equipment Id";
            colEquipmentId.MinimumWidth = 6;
            colEquipmentId.Name = "colEquipmentId";
            colEquipmentId.Width = 125;
            // 
            // colIssueDescription
            // 
            colIssueDescription.HeaderText = "Issue Description";
            colIssueDescription.MinimumWidth = 6;
            colIssueDescription.Name = "colIssueDescription";
            colIssueDescription.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // colDateReported
            // 
            colDateReported.HeaderText = "Date Reported";
            colDateReported.MinimumWidth = 6;
            colDateReported.Name = "colDateReported";
            colDateReported.Width = 125;
            // 
            // colRepariCost
            // 
            colRepariCost.HeaderText = "Repair Cost";
            colRepariCost.MinimumWidth = 6;
            colRepariCost.Name = "colRepariCost";
            colRepariCost.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 271);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 6;
            label3.Text = "Selected Ticket -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 271);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 7;
            label4.Text = "\"\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 378);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Open", "Resolved" });
            comboBox1.Location = new Point(29, 401);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 28);
            comboBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(409, 401);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 27);
            textBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 439);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 11;
            label6.Text = "Date Reported";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(409, 378);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 12;
            label7.Text = "Repair Cost";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(409, 470);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(286, 27);
            dateTimePicker2.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 439);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 14;
            label8.Text = "Date Resolved";
            // 
            // MaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 584);
            Controls.Add(label8);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "MaintenanceForm";
            Text = "MaintenanceForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridViewTextBoxColumn colEquipmentId;
        private DataGridViewTextBoxColumn colIssueDescription;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colDateReported;
        private DataGridViewTextBoxColumn colRepariCost;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label8;
    }
}