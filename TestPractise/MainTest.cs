using Practise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestPractise
{
    
    
    /// <summary>
    ///This is a test class for MainTest and is intended
    ///to contain all MainTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}

        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion
        /// <summary>
        ///A test for add
        ///</summary>
        [TestMethod()]
        public void TestAdd()
        {
            First target = new First(); // TODO: Initialize to an appropriate value
            int a = 2; // TODO: Initialize to an appropriate value
            int b = 3; // TODO: Initialize to an appropriate value
            int expected = 5; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.add(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for subtract
        ///</summary>
        [TestMethod()]
        public void TestSubtract()
        {
            First target = new First(); // TODO: Initialize to an appropriate value
            int a = 5; // TODO: Initialize to an appropriate value
            int b = 2; // TODO: Initialize to an appropriate value
            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.subtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for negative subtraction
        ///</summary>
        [TestMethod()]
        public void TestNegativeSubtraction()
        {
            First target = new First(); // TODO: Initialize to an appropriate value
            int a = 2; // TODO: Initialize to an appropriate value
            int b = 3; // TODO: Initialize to an appropriate value
            int expected = -1; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.subtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for negative subtraction
        ///</summary>
        [TestMethod()]
       // [ExpectedException(typeof(Exception))]
        public void TestNegativeMaxRangeSubtraction()
        {
            First target = new First(); // TODO: Initialize to an appropriate value
            int a = -10;
            int b = Int32.MaxValue; 
            //int expected = 2147483649; 
            int actual;
            try
            {
                actual = target.subtract(a, b);
            }
            catch (Exception e)
            {
                 Assert.IsInstanceOfType(e, typeof(Exception));
            }
           
          
           
        }

    }
}
