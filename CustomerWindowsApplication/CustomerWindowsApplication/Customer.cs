using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWindowsApplication
{
    class Customer
    {
        // Class variables go here
        private static int versionNumber;
        private static Customer[] myCustArray = new Customer[100];

        // Instance variables go here
        private string customerName;
        private string customerAddress;
        private int customerZip;

        //Default Constructor Method
        public Customer()
        {
        }//end of Customer Constructor method

        // Save a customer class method
        // This method finds a empty element and adds the
        // the customer object to it.
        public static void saveACustomer(Customer myCustObj)
        {
            for (int k = 0; k < myCustArray.Length; k++)
            {
                if (myCustArray[k] == null)
                {
                    myCustArray[k] = myCustObj;
                    return;
                }//end if
            }//end for loop
        }//end save a customer

        // get all customers class method
        // This method returns the customer array
        public static Customer[] getAllCustomers()
        {
            return myCustArray;
        }//end get all customers

        // retrieve the version number
        public static int getVersionNumber()
        {
            return versionNumber;
        }//end of getVersionNumber method

        // set the version Number
        public static void setVersionNumber(int newVersionNumber)
        {
            versionNumber = newVersionNumber;
        }//end of setVersionNumber method

        // Instance methods go here

        // retrieve the customer name
        public string getCustomerName()
        {
            return customerName;
        }//end of getCustomerName method

        // set the customer name
        public void setCustomerName(string newName)
        {
            customerName = newName;
        }//end of setCustomerName method

        // retrieve the customer address
        public string getCustomerAddress()
        {
            return customerAddress;
        }//end of getCustomerAddress method

        // set the customer address
        public void setCustomerAddress(string newAddress)
        {
            customerAddress = newAddress;
        }//end of setCustomerAddress method

        // retrieve the customer zip
        public int getCustomerZip()
        {
            return customerZip;
        }//end of getCustomerZip method

        // set the customer Zip
        public void setCustomerZip(int newZip)
        {
            customerZip = newZip;
        }//end of setCustomerZip method

    }//end of Class definition
}
