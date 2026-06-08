namespace ApartmentSaleManagement
{
    partial class CustomerView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCView = new System.Windows.Forms.DataGridView();
            this.dgvCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDsort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.2935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.7065F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOrder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(769, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 539);
            this.panel4.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(22, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(22, 241);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(134, 38);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Buy Now";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 539);
            this.panel3.TabIndex = 2;
            // 
            // dgvCView
            // 
            this.dgvCView.AllowUserToAddRows = false;
            this.dgvCView.AllowUserToDeleteRows = false;
            this.dgvCView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCID,
            this.dgvLoc,
            this.dgvSize,
            this.dgvPrice});
            this.dgvCView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCView.Location = new System.Drawing.Point(0, 0);
            this.dgvCView.Name = "dgvCView";
            this.dgvCView.ReadOnly = true;
            this.dgvCView.RowHeadersWidth = 62;
            this.dgvCView.RowTemplate.Height = 28;
            this.dgvCView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCView.Size = new System.Drawing.Size(760, 539);
            this.dgvCView.TabIndex = 0;
            // 
            // dgvCID
            // 
            this.dgvCID.DataPropertyName = "ApartmentID";
            this.dgvCID.HeaderText = "ApartmentID";
            this.dgvCID.MinimumWidth = 8;
            this.dgvCID.Name = "dgvCID";
            this.dgvCID.ReadOnly = true;
            this.dgvCID.Width = 150;
            // 
            // dgvLoc
            // 
            this.dgvLoc.DataPropertyName = "Location";
            this.dgvLoc.HeaderText = "Location";
            this.dgvLoc.MinimumWidth = 8;
            this.dgvLoc.Name = "dgvLoc";
            this.dgvLoc.ReadOnly = true;
            this.dgvLoc.Width = 150;
            // 
            // dgvSize
            // 
            this.dgvSize.DataPropertyName = "Size";
            this.dgvSize.HeaderText = "Size";
            this.dgvSize.MinimumWidth = 8;
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.ReadOnly = true;
            this.dgvSize.Width = 150;
            // 
            // dgvPrice
            // 
            this.dgvPrice.DataPropertyName = "Price";
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 8;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(769, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 73);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDsort);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 73);
            this.panel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(512, 24);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(159, 38);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort by Asc";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDsort
            // 
            this.btnDsort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDsort.Location = new System.Drawing.Point(347, 24);
            this.btnDsort.Name = "btnDsort";
            this.btnDsort.Size = new System.Drawing.Size(159, 38);
            this.btnDsort.TabIndex = 1;
            this.btnDsort.Text = "Sort by Dsc";
            this.btnDsort.UseVisualStyleBackColor = true;
            this.btnDsort.Click += new System.EventHandler(this.btnDsort_Click);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 624);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDsort;
    }
}