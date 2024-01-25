namespace ProjectManagementSystem
{
    partial class Resources_Details
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.resourceSet1 = new ProjectManagementSystem.ResourceSet();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(663, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Resources";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-215, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 86);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resources";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourceTypeIdDataGridViewTextBoxColumn,
            this.resourceTypeNameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resourcesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(919, 339);
            this.dataGridView1.TabIndex = 15;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Resources.*\r\nFROM     Resources";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Resources] ([ResourceTypeId], [ResourceTypeName], [Qty], [UnitPrice]" +
    ") VALUES (@ResourceTypeId, @ResourceTypeName, @Qty, @UnitPrice)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ResourceTypeId", System.Data.SqlDbType.VarChar, 0, "ResourceTypeId"),
            new System.Data.SqlClient.SqlParameter("@ResourceTypeName", System.Data.SqlDbType.VarChar, 0, "ResourceTypeName"),
            new System.Data.SqlClient.SqlParameter("@Qty", System.Data.SqlDbType.Int, 0, "Qty"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Int, 0, "UnitPrice")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Resources", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ResourceTypeId", "ResourceTypeId"),
                        new System.Data.Common.DataColumnMapping("ResourceTypeName", "ResourceTypeName"),
                        new System.Data.Common.DataColumnMapping("Qty", "Qty"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True;P" +
    "ooling=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // resourceSet1
            // 
            this.resourceSet1.DataSetName = "ResourceSet";
            this.resourceSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.resourceSet1;
            // 
            // resourceTypeIdDataGridViewTextBoxColumn
            // 
            this.resourceTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ResourceTypeId";
            this.resourceTypeIdDataGridViewTextBoxColumn.HeaderText = "Resource Type Id";
            this.resourceTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resourceTypeIdDataGridViewTextBoxColumn.Name = "resourceTypeIdDataGridViewTextBoxColumn";
            this.resourceTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.resourceTypeIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // resourceTypeNameDataGridViewTextBoxColumn
            // 
            this.resourceTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ResourceTypeName";
            this.resourceTypeNameDataGridViewTextBoxColumn.HeaderText = "Resource Type";
            this.resourceTypeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resourceTypeNameDataGridViewTextBoxColumn.Name = "resourceTypeNameDataGridViewTextBoxColumn";
            this.resourceTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.resourceTypeNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Estimate Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // Resources_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Resources_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resources_Details";
            this.Load += new System.EventHandler(this.Resources_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private ResourceSet resourceSet1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    }
}