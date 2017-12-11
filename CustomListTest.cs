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
            string[] testIntArray = new string[5] { "Bird", "Moose", "Pig", "llama", "Yoda", };

            //act

            list.Remove("Moose");


            //assert
            Assert.IsFalse(true, "Moose");
        }

        [TestMethod]
        public void Add_Test_Large_Number()
        {
            //arrange
            MyList<int> list = new MyList<int>();
            int expectedResult = 15412;
            list.Add(15412);
            //assert
            Assert.AreEqual(expectedResult, list[0]);
        }

        [TestMethod]
        public void Add_String()
        {
            //arrange
            MyList<string> list = new MyList<string>();
            string expectedResult = "Yoda";

            //act
            list.Add("Yoda");
            list.Add("Force");


            //assert
            Assert.AreNotSame(expectedResult, list[0]);
        }
        [TestMethod]
        public void Add_Test_Double()
        {
            //arrange
            MyList<double> list = new List<double>();
            double expectedResult = 11;
            //act
            list.Add(.35);
            list.Add(10.65);


            //assert
            Assert.AreNotEqual(expectedResult, list[0]);
        }
        [TestMethod]
        public void Count_Int_Test()
        {
            //arrange
            MyList<int> list = new MyList<int>() { 1, 2, 3, 4, 5 };
            int expectedResult = 5;
            //act
            int actualResult = list.Count;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void Count_String_Test()
        {
            MyList<string> list = new MyList<string>() { "Harry", "Lloyd", "Samsonite" };
            int expectedResult = 3;
            //act
            int actualResult = list.Count;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void To_String_Test()
        {
            //arrange
            MyList<string> list = new MyList<string>() { "Foxtrot", "Uniform", "Charlie", "Kilo" };
            //act
            string actualResult = list.ToString();
            string expectedResult = "Foxtrot Uniform Charlie Kilo ";
            //assert
            Assert.AreEqual(expectedResult, actualResult)
    }
    }
}
