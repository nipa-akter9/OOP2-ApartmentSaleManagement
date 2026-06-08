namespace ApartmentSaleManagement
{
    partial class OrderList
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dgvAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMpay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.47169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.5283F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 647);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMpay);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.txtOrder);
            this.panel4.Controls.Add(this.lblOrder);
            this.panel4.Controls.Add(this.txtLoc);
            this.panel4.Controls.Add(this.txtSize);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.lblLoc);
            this.panel4.Controls.Add(this.lblSize);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.lblAID);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(697, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 547);
            this.panel4.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(227, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(160, 265);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(182, 26);
            this.txtOrder.TabIndex = 20;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(62, 267);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(85, 24);
            this.lblOrder.TabIndex = 19;
            this.lblOrder.Text = "OrderBy:";
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(160, 101);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(177, 26);
            this.txtLoc.TabIndex = 18;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(155, 161);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(182, 26);
            this.txtSize.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(155, 219);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(182, 26);
            this.txtPrice.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(160, 51);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(182, 26);
            this.txtID.TabIndex = 15;
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.Location = new System.Drawing.Point(55, 103);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(87, 24);
            this.lblLoc.TabIndex = 14;
            this.lblLoc.Text = "Location:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(94, 161);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(48, 24);
            this.lblSize.TabIndex = 13;
            this.lblSize.Text = "Size:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(85, 219);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 24);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price:";
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAID.Location = new System.Drawing.Point(6, 51);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(141, 24);
            this.lblAID.TabIndex = 11;
            this.lblAID.Text = "Appartment ID:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(106, 484);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 547);
            this.panel3.TabIndex = 2;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAID,
            this.dgvLoc,
            this.dgvSize,
            this.gdvPrice,
            this.dgvOrderby});
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 62;
            this.dgvOrder.RowTemplate.Height = 28;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(688, 547);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // dgvAID
            // 
            this.dgvAID.DataPropertyName = "ApartmentID";
            this.dgvAID.HeaderText = "ApartmentID";
            this.dgvAID.MinimumWidth = 8;
            this.dgvAID.Name = "dgvAID";
            this.dgvAID.ReadOnly = true;
            this.dgvAID.Width = 150;
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
            // gdvPrice
            // 
            this.gdvPrice.DataPropertyName = "Price";
            this.gdvPrice.HeaderText = "Price";
            this.gdvPrice.MinimumWidth = 8;
            this.gdvPrice.Name = "gdvPrice";
            this.gdvPrice.ReadOnly = true;
            this.gdvPrice.Width = 150;
            // 
            // dgvOrderby
            // 
            this.dgvOrderby.DataPropertyName = "OrderBy";
            this.dgvOrderby.HeaderText = "OrderBy";
            this.dgvOrderby.MinimumWidth = 8;
            this.dgvOrderby.Name = "dgvOrderby";
            this.dgvOrderby.ReadOnly = true;
            this.dgvOrderby.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(697, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 88);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 88);
            this.panel1.TabIndex = 0;
            // 
            // btnMpay
            // 
            this.btnMpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMpay.Location = new System.Drawing.Point(89, 374);
            this.btnMpay.Name = "btnMpay";
            this.btnMpay.Size = new System.Drawing.Size(201, 45);
            this.btnMpay.TabIndex = 22;
            this.btnMpay.Text = "Make Payment";
            this.btnMpay.UseVisualStyleBackColor = true;
            this.btnMpay.Click += new System.EventHandler(this.btnMpay_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderby;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMpay;
    }
}