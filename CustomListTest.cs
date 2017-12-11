using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomListTest
    { 
        [TestMethod]
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


        [TestMethod]
               public void Set_List_IntegerN()
        {
            //arrange
            MyList<int> My_List_Instance = new MyList<int>();
            int n = 1;
            myInstance[0] = n;
            //assert
            Assert.AreEqual(myInstance[0], n);
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
        public void Subtract_String()
        {
            //Arrange
            MyList<string> listOne = new MyList<string>(4) { "Shimmy", "Shimmy", "QuarterTurn", "Goodbye" };
            MyList<string> listTwo = new MyList<string>(2) { "Here", "There" };
            string expected = "There, Goodbye";
            //Act
            MyList<string> actualList = listOne - listTwo;
            string actual = actualList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
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
        [TestMethod]
        public void Count_String_Test()
        {
            MyList<string> list = new MyList<string>() { "Harry", "Lloyd", "Samsonite" };
            int expectedResult = 3;
            //act
            int actualResult = list.Count;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void To_String_Test()
        {
            //arrange
            MyList<string> list = new MyList<string>() { "Foxtrot", "Uniform", "Charlie", "Kilo" };
            //acts
            string actualResult = list.ToString();
            string expectedResult = "Foxtrot Uniform Charlie Kilo ";
            //assert
            Assert.AreEqual(expectedResult, actualResult)
        }

        [TestMethod]
        public void Add_Test_Negative_Number()
        {
            //arrange
            MyList<int> list = new MyList<int>();

            int expectedResult = -12;
            list.Add(-2);
            list.Add(-4);
            list.Add(-8);
            list.Add(-12);
            list.Add(-25);
            list.Add(-34);
            list.Add(-92);

            //assert
            Assert.AreEqual(expectedResult, list[-12]);
        }
        [TestMethod]
        public void Count_Double_Test()
        {
            //arrange
            MyList<double> list = new MyList<double>() { 111.11, 222.22, 7.00, 94.90, 12.90 };
            int expectedResult = 4;
            //act
            int actualResult = list.Count;
            //assert
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Zip_New_List()
        {
            //Arrange
            MyList<string> numbers = new MyList<string>(3) { "1", "2", "3" };
            MyList<string> words = new MyList<string>(4) { "one", "two", "three", "four" };
            string expected = "1, one, 2, two, 3, three";
            //Act
            MyList<string> numbersAndWords = numbers.Zip(words);
            string result = numbersAndWords.ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Overwrite_Zip_List()
        {
            //Arrange
            MyList<string> numbers = new MyList<string>(3) { "3", "6", "9", "10" };
            MyList<string> words = new MyList<string>(4) { "three", "six", "nine", "ten" };
            string expected = "3, three, 6, six, 9, nine";
            //Act
            numbers = numbers.Zip(words);
            string result = numbers.ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Sort_Integers()
        {
            //Arrange
            MyList<int> numbers = new MyList<int>(7) { 8, 6, 7, 5, 3, 0, 9 };
            string expected = "0, 3, 5, 6, 7, 8, 9";
            //Act
            string result = numbers.Sort().ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Sort_Doubles()
        {
            //Arrange
           MyList<double> numbers = new MyList<double>(5) { 3.3, 1.1, 2.2, 4.4, 0.4 };
            string expected = "0.4, 1.1, 2.2, 3.3, 4.4";
            //Act
            string result = numbers.Sort().ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}