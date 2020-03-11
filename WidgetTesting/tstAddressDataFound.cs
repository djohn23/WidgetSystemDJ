using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgetClasses;
using WidgetTesting;
//using Class_Library;

namespace WidgetTesting
{
    [TestClass]
    public class tstAddressDataFound
    {
        [TestMethod]
        public void FindMethodOK()
        {
            //CREATING THE FIND METHOD HANDOUT
            //CREATE AN INSTANCE OF THER CLASS YOU WANT TO CREATE
            clsAddress AnAddress = new clsAddress();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
// TEST METHODS FIND FOR EACH ADDRESS CLASS PROPERTY

        [TestMethod]
        public void TestAddressNoFound()
        {
            //CREATE AN INSTANCE OF THER CLASS YOU WANT TO CREATE
            clsAddress AnAddress = new clsAddress();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the address no
            if (AnAddress.AddressNo != 21)
            { OK = false; }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.HouseNo != "123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.Street != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.Town != "Test Town")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCountyFound()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.County != "Test County")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.PostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            //CREATE AN INSTANCE OF THER CLASS YOU WANT TO CREATE
            clsAddress AnAddress = new clsAddress();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.DateAdded != Convert.ToDateTime("16/09/2015"))
            { OK = false; }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}














