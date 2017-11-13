namespace CustomerWindowsApplication
{
    partial class CustomerAppForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.listAllCustomersBtn = new System.Windows.Forms.Button();
            this.exitBtm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Infromation Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.AccessibleName = "addCustomerBtn";
            this.addCustomerBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.Location = new System.Drawing.Point(144, 74);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(180, 23);
            this.addCustomerBtn.TabIndex = 1;
            this.addCustomerBtn.Text = "Add a Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // listAllCustomersBtn
            // 
            this.listAllCustomersBtn.AccessibleName = "";
            this.listAllCustomersBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAllCustomersBtn.Location = new System.Drawing.Point(144, 152);
            this.listAllCustomersBtn.Name = "listAllCustomersBtn";
            this.listAllCustomersBtn.Size = new System.Drawing.Size(180, 23);
            this.listAllCustomersBtn.TabIndex = 2;
            this.listAllCustomersBtn.Text = "List All Customers";
            this.listAllCustomersBtn.UseVisualStyleBackColor = true;
            this.listAllCustomersBtn.Click += new System.EventHandler(this.listAllCustomersBtn_Click);
            // 
            // exitBtm
            // 
            this.exitBtm.AccessibleName = "";
            this.exitBtm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtm.Location = new System.Drawing.Point(378, 220);
            this.exitBtm.Name = "exitBtm";
            this.exitBtm.Size = new System.Drawing.Size(75, 23);
            this.exitBtm.TabIndex = 3;
            this.exitBtm.Text = "Exit";
            this.exitBtm.UseVisualStyleBackColor = true;
            this.exitBtm.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // CustomerAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.exitBtm);
            this.Controls.Add(this.listAllCustomersBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label1);
            this.Name = "CustomerAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Manager Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button listAllCustomersBtn;
        private System.Windows.Forms.Button exitBtm;
    }
}

