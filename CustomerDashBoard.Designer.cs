namespace ApartmentSaleManagement
{
    partial class CustomerDashBoard
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnMOrder = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPayHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(210, 21);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(196, 74);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy Apartment";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnMOrder
            // 
            this.btnMOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMOrder.Location = new System.Drawing.Point(210, 140);
            this.btnMOrder.Name = "btnMOrder";
            this.btnMOrder.Size = new System.Drawing.Size(196, 74);
            this.btnMOrder.TabIndex = 1;
            this.btnMOrder.Text = "My Order";
            this.btnMOrder.UseVisualStyleBackColor = true;
            this.btnMOrder.Click += new System.EventHandler(this.btnMOrder_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(210, 334);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(196, 74);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(653, 354);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPayHistory
            // 
            this.btnPayHistory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayHistory.Location = new System.Drawing.Point(210, 238);
            this.btnPayHistory.Name = "btnPayHistory";
            this.btnPayHistory.Size = new System.Drawing.Size(196, 74);
            this.btnPayHistory.TabIndex = 6;
            this.btnPayHistory.Text = "Payment History";
            this.btnPayHistory.UseVisualStyleBackColor = true;
            this.btnPayHistory.Click += new System.EventHandler(this.btnPayHistory_Click);
            // 
            // CustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPayHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMOrder);
            this.Controls.Add(this.btnBuy);
            this.Name = "CustomerDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnMOrder;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPayHistory;
    }
}