using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void TestMethod1()
        {  [TestMethod]
        public void Add_Integer_Test()
        {
            //arrange
            MyList<int> list = new MyList<int>();
            int expectedResult = 22;
            list.Add(5);
            list.Add(3);
            list.Add(5);
            list.Add(22);
            

            Assert.AreEqual(expectedResult, list[3]);



               public void SetList_IntegerN()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            int n = 1;
            myListInstance[0] = n;
            //assert
            Assert.AreEqual(myListInstance[0], n);
        }

        [TestMethod]
        public void Remove_String_Test()
        {
            //arrange
            MyList<string> list = new MyList<string>();
            string[] testIntArray = new string[5] { "Bird", "Moose", "Pig", "llama", "Cat", };

            //act

            list.Remove("Moose");


            //assert
            Assert.IsFalse(true, "Moose");
        }

        [TestMethod]
        public void AddTestLargeNumber()
        {
            //arrange
            MyList<int> list = new MyList<int>();
            int expectedResult = 15412;
            list.Add(15412);
            //assert
            Assert.AreEqual(expectedResult, list[0]);
        }


    }
    }
}
