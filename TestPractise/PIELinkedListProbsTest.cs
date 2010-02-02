using Practise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestPractise
{
    
    
    /// <summary>
    ///This is a test class for PIELinkedListProbsTest and is intended
    ///to contain all PIELinkedListProbsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PIELinkedListProbsTest
    {

        Practise.PIELinkedList p = new Practise.PIELinkedList();
        LinkedList ll = new LinkedList(5);
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
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            
            
        }
        
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
        ///A test for IsEmpty when not empty
        ///</summary>
        [TestMethod()]
        public void TestEmptyWhenNotEmpty()
        {
            Assert.AreEqual(ll.IsEmpty(), false);            
        }
        
        /// <summary>
        ///A test for IsEmpty when empty
        ///</summary>
        [TestMethod()]
        public void TestEmptyWhenEmpty()
        {
            ll.RemoveFirst();
            Assert.AreEqual(ll.IsEmpty(), true);
        }
        /// <summary>
        ///A test for IsEmpty when empty would an exception be thrown?
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestEmptyWhenEmptyThrowException()
        {
            ll.RemoveFirst();
            ll.RemoveFirst();
            Assert.AreEqual(ll.IsEmpty(), true);
        }
    }
}
