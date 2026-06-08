namespace ApartmentSaleManagement
{
    partial class CustomerList
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
            this.btnCBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCus = new System.Windows.Forms.DataGridView();
            this.dgvCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.875F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCBack);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(660, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 377);
            this.panel4.TabIndex = 3;
            // 
            // btnCBack
            // 
            this.btnCBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCBack.Location = new System.Drawing.Point(30, 141);
            this.btnCBack.Name = "btnCBack";
            this.btnCBack.Size = new System.Drawing.Size(85, 54);
            this.btnCBack.TabIndex = 0;
            this.btnCBack.Text = "Back";
            this.btnCBack.UseVisualStyleBackColor = true;
            this.btnCBack.Click += new System.EventHandler(this.btnCBack_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 377);
            this.panel3.TabIndex = 2;
            // 
            // dgvCus
            // 
            this.dgvCus.AllowUserToAddRows = false;
            this.dgvCus.AllowUserToDeleteRows = false;
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCID,
            this.dgvCName,
            this.dgvEmail,
            this.dgvPhone,
            this.dgvPass});
            this.dgvCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCus.Location = new System.Drawing.Point(0, 0);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.ReadOnly = true;
            this.dgvCus.RowHeadersWidth = 62;
            this.dgvCus.RowTemplate.Height = 28;
            this.dgvCus.Size = new System.Drawing.Size(651, 377);
            this.dgvCus.TabIndex = 0;
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
            // dgvCName
            // 
            this.dgvCName.DataPropertyName = "CName";
            this.dgvCName.HeaderText = "CName";
            this.dgvCName.MinimumWidth = 8;
            this.dgvCName.Name = "dgvCName";
            this.dgvCName.ReadOnly = true;
            this.dgvCName.Width = 150;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "Email";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 8;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            this.dgvEmail.Width = 150;
            // 
            // dgvPhone
            // 
            this.dgvPhone.DataPropertyName = "Phone";
            this.dgvPhone.HeaderText = "Phone";
            this.dgvPhone.MinimumWidth = 8;
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            this.dgvPhone.Width = 150;
            // 
            // dgvPass
            // 
            this.dgvPass.DataPropertyName = "Password";
            this.dgvPass.HeaderText = "Password";
            this.dgvPass.MinimumWidth = 8;
            this.dgvPass.Name = "dgvPass";
            this.dgvPass.ReadOnly = true;
            this.dgvPass.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(660, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 61);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 61);
            this.panel1.TabIndex = 0;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCBack;
    }
}