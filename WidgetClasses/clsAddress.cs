using System;

namespace WidgetClasses
{
    public class clsAddress


        //PROPERTIES BELOW

    { 
        //addressNo private member variable
        private Int32 mAddressNo;
        //AddressNo public property
        public int AddressNo
        {
            //this line of code sends data out of the property
            get { return mAddressNo; }
            // this line of code allows data into the property
            set { mAddressNo = value; }
        }

        //set private member variable
        private string mHouseNo;
        //set public property
        public string HouseNo
        {
            get { return mHouseNo; }
            set { mHouseNo = value; }
        }

        //street private member variable
        private string mStreet;
        //Street public proprty
        public string Street
        {
            get { return mStreet; }
            set { mStreet = value; }
        }

        private string mTown;
        public string Town

        {
            get { return mTown; }
            set { mTown = value; }
        }

        private string mCounty;
        public string County
        {
            get { return mCounty; }
            set { mCounty = value; }
        }


        private string mPostCode;
        public string PostCode
        {
            get { return mPostCode; }
            set { mPostCode = value; }
        }

        //date added private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }

        private bool mActive;
        public bool Active
        {
            get { return mActive; }
            set { mActive = value; }
        }

        //METHODS BELOW


        public bool Find(int addressNo)
        {
            //set the private data members to the test data value
            mAddressNo = 21;
            mHouseNo = "123";
            mStreet = "Test Street";
            mTown = "Test Town";
            mCounty = "Test County";
            mPostCode = "XXX XXX";
            mActive = true;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            //always return true
            return true;
        }
    }
}