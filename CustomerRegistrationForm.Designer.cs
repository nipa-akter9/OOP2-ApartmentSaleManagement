namespace ApartmentSaleManagement
{
    partial class CustomerRegistrationForm
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
            this.lblCName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPass = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.Location = new System.Drawing.Point(199, 97);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(79, 26);
            this.lblCName.TabIndex = 0;
            this.lblCName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(197, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 26);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblCPass
            // 
            this.lblCPass.AutoSize = true;
            this.lblCPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPass.Location = new System.Drawing.Point(68, 458);
            this.lblCPass.Name = "lblCPass";
            this.lblCPass.Size = new System.Drawing.Size(210, 26);
            this.lblCPass.TabIndex = 2;
            this.lblCPass.Text = "Confirm Password:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(160, 361);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(118, 26);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(194, 264);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(84, 26);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(447, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtCPass
            // 
            this.txtCPass.Location = new System.Drawing.Point(447, 458);
            this.txtCPass.Name = "txtCPass";
            this.txtCPass.Size = new System.Drawing.Size(307, 26);
            this.txtCPass.TabIndex = 6;
            this.txtCPass.TextChanged += new System.EventHandler(this.txtCPass_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(447, 375);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(307, 26);
            this.txtPass.TabIndex = 7;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(447, 266);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(307, 26);
            this.txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(447, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(549, 419);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(69, 26);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "DNM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "e";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(403, 535);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(215, 64);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.CursorChanged += new System.EventHandler(this.button1_MouseHover);
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // CustomerRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 632);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtCPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblCPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCName);
            this.Name = "CustomerRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRegistrationForm";
            this.Load += new System.EventHandler(this.CustomerRegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReg;
    }
}