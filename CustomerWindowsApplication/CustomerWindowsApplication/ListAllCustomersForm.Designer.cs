using System;
using System.Windows.Forms;

namespace CustomerWindowsApplication
{
    partial class ListAllCustomersForm
    {
        private Form myReturnForm = null;

        public ListAllCustomersForm(Form formThatCreatedMe)
        {
            InitializeComponent();

            myReturnForm = formThatCreatedMe;
            displayCustomers();
        }


        //display the customers

        private void displayCustomers()

        {
            //format the header in the text box
            customerList.Text = ""; //Clear the textbox
            customerList.AppendText(
                "-------------------------------------------------- \r\n");
            customerList.AppendText(
                "Name                 Address                 Zip \r\n");
            customerList.AppendText(
                "-------------------------------------------------- \r\n");


            //local variables
            String name = "";
            String address = "";
            int zip = 0;

            //get all customers
            Customer[] myCustArray = Customer.getAllCustomers();

            //loop thru the array and display all the data
            for (int k = 0; k < myCustArray.Length; k++)
            {
                if (myCustArray[k] != null)
                {
                    //get the customer attributes for this customer
                    name = myCustArray[k].getCustomerName();
                    address = myCustArray[k].getCustomerAddress();
                    zip = myCustArray[k].getCustomerZip();

                    //format the data
                    name = name.PadRight(20, ' ');
                    address = address.PadRight(23, ' ');

                    //display it to the textBox
                    this.customerList.AppendText(name + " " +
                        address + " " + zip + "\r\n");

                }//end if not null
            }//end for loop
        }//end displayCustomers method

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
            this.customerList = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "List All Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerList
            // 
            this.customerList.BackColor = System.Drawing.SystemColors.Window;
            this.customerList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerList.Location = new System.Drawing.Point(27, 61);
            this.customerList.Multiline = true;
            this.customerList.Name = "customerList";
            this.customerList.ReadOnly = true;
            this.customerList.Size = new System.Drawing.Size(434, 159);
            this.customerList.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(357, 226);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // ListAllCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.label1);
            this.Name = "ListAllCustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List All Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerList;
        private System.Windows.Forms.Button okBtn;
    }
}