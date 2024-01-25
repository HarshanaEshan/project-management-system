namespace ProjectManagementSystem
{
    partial class Labour_Details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.laboursSet1 = new ProjectManagementSystem.LaboursSet();
            this.laboursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labourTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labourTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboursSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-158, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 86);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Labours";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labourTypeIdDataGridViewTextBoxColumn,
            this.labourTypeDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.laboursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 340);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(542, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Labours";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Labours.*\r\nFROM     Labours";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Labours] ([LabourTypeId], [LabourType], [Salary], [Count]) VALUES (@" +
    "LabourTypeId, @LabourType, @Salary, @Count)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LabourTypeId", System.Data.SqlDbType.VarChar, 0, "LabourTypeId"),
            new System.Data.SqlClient.SqlParameter("@LabourType", System.Data.SqlDbType.VarChar, 0, "LabourType"),
            new System.Data.SqlClient.SqlParameter("@Salary", System.Data.SqlDbType.Int, 0, "Salary"),
            new System.Data.SqlClient.SqlParameter("@Count", System.Data.SqlDbType.Int, 0, "Count")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Labours", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LabourTypeId", "LabourTypeId"),
                        new System.Data.Common.DataColumnMapping("LabourType", "LabourType"),
                        new System.Data.Common.DataColumnMapping("Salary", "Salary"),
                        new System.Data.Common.DataColumnMapping("Count", "Count")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True;P" +
    "ooling=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // laboursSet1
            // 
            this.laboursSet1.DataSetName = "LaboursSet";
            this.laboursSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laboursBindingSource
            // 
            this.laboursBindingSource.DataMember = "Labours";
            this.laboursBindingSource.DataSource = this.laboursSet1;
            // 
            // labourTypeIdDataGridViewTextBoxColumn
            // 
            this.labourTypeIdDataGridViewTextBoxColumn.DataPropertyName = "LabourTypeId";
            this.labourTypeIdDataGridViewTextBoxColumn.HeaderText = "LabourTypeId";
            this.labourTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labourTypeIdDataGridViewTextBoxColumn.Name = "labourTypeIdDataGridViewTextBoxColumn";
            this.labourTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.labourTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // labourTypeDataGridViewTextBoxColumn
            // 
            this.labourTypeDataGridViewTextBoxColumn.DataPropertyName = "LabourType";
            this.labourTypeDataGridViewTextBoxColumn.HeaderText = "LabourType";
            this.labourTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labourTypeDataGridViewTextBoxColumn.Name = "labourTypeDataGridViewTextBoxColumn";
            this.labourTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.labourTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // Labour_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(739, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Labour_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Labour_Details";
            this.Load += new System.EventHandler(this.Labour_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboursSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboursBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn labourTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labourTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource laboursBindingSource;
        private LaboursSet laboursSet1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}