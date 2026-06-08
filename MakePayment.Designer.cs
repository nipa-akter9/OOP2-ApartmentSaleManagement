namespace ApartmentSaleManagement
{
    partial class MakePayment
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPD = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPDate = new System.Windows.Forms.Label();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.lblAID = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.lblCID = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(378, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 44);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 44);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtPD);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.lblPDate);
            this.panel4.Controls.Add(this.txtAP);
            this.panel4.Controls.Add(this.lblAID);
            this.panel4.Controls.Add(this.txtCID);
            this.panel4.Controls.Add(this.lblCID);
            this.panel4.Controls.Add(this.txtPID);
            this.panel4.Controls.Add(this.lblPID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(758, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 573);
            this.panel4.TabIndex = 3;
            // 
            // txtPD
            // 
            this.txtPD.Location = new System.Drawing.Point(168, 299);
            this.txtPD.Name = "txtPD";
            this.txtPD.Size = new System.Drawing.Size(282, 26);
            this.txtPD.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(191, 401);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(148, 26);
            this.txtPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(80, 397);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 29);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // lblPDate
            // 
            this.lblPDate.AutoSize = true;
            this.lblPDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDate.Location = new System.Drawing.Point(12, 296);
            this.lblPDate.Name = "lblPDate";
            this.lblPDate.Size = new System.Drawing.Size(161, 29);
            this.lblPDate.TabIndex = 6;
            this.lblPDate.Text = "Payment Date:";
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(191, 219);
            this.txtAP.Name = "txtAP";
            this.txtAP.ReadOnly = true;
            this.txtAP.Size = new System.Drawing.Size(148, 26);
            this.txtAP.TabIndex = 5;
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAID.Location = new System.Drawing.Point(29, 219);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(156, 29);
            this.lblAID.TabIndex = 4;
            this.lblAID.Text = "Apartment ID:";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(179, 137);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(160, 26);
            this.txtCID.TabIndex = 3;
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCID.Location = new System.Drawing.Point(29, 133);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(144, 29);
            this.lblCID.TabIndex = 2;
            this.lblCID.Text = "Customer ID:";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(179, 58);
            this.txtPID.Name = "txtPID";
            this.txtPID.ReadOnly = true;
            this.txtPID.Size = new System.Drawing.Size(160, 26);
            this.txtPID.TabIndex = 1;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(38, 54);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(135, 29);
            this.lblPID.TabIndex = 0;
            this.lblPID.Text = "Payment ID:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(117, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPID,
            this.dgvCID,
            this.dgvAID,
            this.dgvPDate,
            this.dgvStatus,
            this.dgvPrice});
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayment.Location = new System.Drawing.Point(0, 0);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersWidth = 62;
            this.dgvPayment.RowTemplate.Height = 28;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayment.Size = new System.Drawing.Size(749, 573);
            this.dgvPayment.TabIndex = 0;
            this.dgvPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(195, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPayment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 573);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(758, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 100);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.73567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.26433F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 685);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvPID
            // 
            this.dgvPID.DataPropertyName = "PaymentID";
            this.dgvPID.HeaderText = "PaymentID";
            this.dgvPID.MinimumWidth = 8;
            this.dgvPID.Name = "dgvPID";
            this.dgvPID.ReadOnly = true;
            this.dgvPID.Width = 150;
            // 
            // dgvCID
            // 
            this.dgvCID.DataPropertyName = "CustomerID";
            this.dgvCID.HeaderText = "CustomerID";
            this.dgvCID.MinimumWidth = 8;
            this.dgvCID.Name = "dgvCID";
            this.dgvCID.ReadOnly = true;
            this.dgvCID.Width = 150;
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
            // dgvPDate
            // 
            this.dgvPDate.DataPropertyName = "PaymentDate";
            this.dgvPDate.HeaderText = "PaymentDate";
            this.dgvPDate.MinimumWidth = 8;
            this.dgvPDate.Name = "dgvPDate";
            this.dgvPDate.ReadOnly = true;
            this.dgvPDate.Width = 150;
            // 
            // dgvStatus
            // 
            this.dgvStatus.DataPropertyName = "Status";
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.MinimumWidth = 8;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.Width = 150;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status:";
            // 
            // MakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MakePayment";
            this.Text = "MakePayment";
            this.Load += new System.EventHandler(this.MakePayment_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker txtPD;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPDate;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
    }
}