using System;
using System.Windows.Forms;

namespace CustomerWindowsApplication
{
    partial class AddCustomerForm
    {
        private Form myReturnForm = null;

        public AddCustomerForm(Form formThatCreatedMe)
        {
            InitializeComponent();

            myReturnForm = formThatCreatedMe;
        }

        private void saveNewCustomerInfo()
        {
            //get the values from the textBoxes
            String newName = custNameField.Text;
            String newAddress = custAddressField.Text;
            int newZip = 0;

            try
            {
                newZip = Convert.ToInt32(custZipField.Text);
            }
            catch (Exception e)
            {

            }

            // create a new customer object
            Customer newCustObj = new Customer();

            // set the cust obj. attributes
            newCustObj.setCustomerName(newName);
            newCustObj.setCustomerAddress(newAddress);
            newCustObj.setCustomerZip(newZip);

            // save the new customer object
            Customer.saveACustomer(newCustObj);
        }//end save customer



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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.custNameField = new System.Windows.Forms.TextBox();
            this.custAddressField = new System.Windows.Forms.TextBox();
            this.custZipField = new System.Windows.Forms.TextBox();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.saveAndExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Customer Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zip";
            // 
            // custNameField
            // 
            this.custNameField.Location = new System.Drawing.Point(151, 77);
            this.custNameField.Name = "custNameField";
            this.custNameField.Size = new System.Drawing.Size(100, 20);
            this.custNameField.TabIndex = 4;
            // 
            // custAddressField
            // 
            this.custAddressField.Location = new System.Drawing.Point(151, 113);
            this.custAddressField.Name = "custAddressField";
            this.custAddressField.Size = new System.Drawing.Size(181, 20);
            this.custAddressField.TabIndex = 5;
            // 
            // custZipField
            // 
            this.custZipField.Location = new System.Drawing.Point(151, 144);
            this.custZipField.Name = "custZipField";
            this.custZipField.Size = new System.Drawing.Size(62, 20);
            this.custZipField.TabIndex = 6;
            // 
            // cancleBtn
            // 
            this.cancleBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleBtn.Location = new System.Drawing.Point(62, 214);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(77, 35);
            this.cancleBtn.TabIndex = 7;
            this.cancleBtn.Text = "Cancel";
            this.cancleBtn.UseVisualStyleBackColor = true;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // saveAndExitBtn
            // 
            this.saveAndExitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndExitBtn.Location = new System.Drawing.Point(307, 214);
            this.saveAndExitBtn.Name = "saveAndExitBtn";
            this.saveAndExitBtn.Size = new System.Drawing.Size(125, 35);
            this.saveAndExitBtn.TabIndex = 8;
            this.saveAndExitBtn.Text = "Save and Exit";
            this.saveAndExitBtn.UseVisualStyleBackColor = true;
            this.saveAndExitBtn.Click += new System.EventHandler(this.saveAndExitBtn_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.saveAndExitBtn);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.custZipField);
            this.Controls.Add(this.custAddressField);
            this.Controls.Add(this.custNameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add A Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custNameField;
        private System.Windows.Forms.TextBox custAddressField;
        private System.Windows.Forms.TextBox custZipField;
        private System.Windows.Forms.Button cancleBtn;
        private System.Windows.Forms.Button saveAndExitBtn;
    }
}