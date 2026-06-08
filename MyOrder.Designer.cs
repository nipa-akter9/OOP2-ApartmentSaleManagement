namespace ApartmentSaleManagement
{
    partial class MyOrder
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
            this.btnMback = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMyOrder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.125F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMback);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(682, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 374);
            this.panel4.TabIndex = 3;
            // 
            // btnMback
            // 
            this.btnMback.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMback.Location = new System.Drawing.Point(3, 144);
            this.btnMback.Name = "btnMback";
            this.btnMback.Size = new System.Drawing.Size(97, 57);
            this.btnMback.TabIndex = 0;
            this.btnMback.Text = "Back";
            this.btnMback.UseVisualStyleBackColor = true;
            this.btnMback.Click += new System.EventHandler(this.btnMback_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMyOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 374);
            this.panel3.TabIndex = 2;
            // 
            // dgvMyOrder
            // 
            this.dgvMyOrder.AllowUserToAddRows = false;
            this.dgvMyOrder.AllowUserToDeleteRows = false;
            this.dgvMyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAID,
            this.dgvLoc,
            this.dgvSize,
            this.dgvPrice});
            this.dgvMyOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvMyOrder.Name = "dgvMyOrder";
            this.dgvMyOrder.ReadOnly = true;
            this.dgvMyOrder.RowHeadersWidth = 62;
            this.dgvMyOrder.RowTemplate.Height = 28;
            this.dgvMyOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyOrder.Size = new System.Drawing.Size(673, 374);
            this.dgvMyOrder.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(682, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 64);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 64);
            this.panel1.TabIndex = 0;
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
            // dgvPrice
            // 
            this.dgvPrice.DataPropertyName = "Price";
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 8;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 150;
            // 
            // MyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MyOrder";
            this.Text = "MyOrder";
            this.Load += new System.EventHandler(this.MyOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMyOrder;
        private System.Windows.Forms.Button btnMback;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
    }
}