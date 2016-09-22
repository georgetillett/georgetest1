using System;
using System.Collections.Generic;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzUnitTest
{
    [TestClass]
    public class MultiplesTest
    {
        [TestMethod]
        public void TestMultipleThree_Positive()
        {
            // Create a list of integers that are multiples of 3
            List<int> threes = new List<int>();
            for(int value = 3; value < 100; value += 3)
            {
                threes.Add(value);
            }

            // Test the method
            foreach(int value in threes)
            {
                Assert.IsTrue(FizzBuzzModel.IsMultipleThree(value));
            }
        }

        [TestMethod]
        public void TestMultipleThree_Negative()
        {
            // Create a list of integers that are NOT multiples of 3
            List<int> notThrees = new List<int>();

            // Offset by one: 1,4,7,10...
            for (int value = 1; value <= 100; value += 3)
            {
                notThrees.Add(value);
            }
            // Offset by two: 2,5,8,11...
            for (int value = 2; value <= 100; value += 3)
            {
                notThrees.Add(value);
            }

            // Test the method
            foreach (int value in notThrees)
            {
                Assert.IsFalse(FizzBuzzModel.IsMultipleThree(value));
            }
        }
        [TestMethod]
        public void TestMultipleFive_Positive()
        {
            // Create a list of integers that are multiples of 5
            List<int> fives = new List<int>();
            for (int value = 5; value < 100; value += 5)
            {
                fives.Add(value);
            }

            // Test the method
            foreach (int value in fives)
            {
                Assert.IsTrue(FizzBuzzModel.IsMultipleFive(value));
            }
        }

        [TestMethod]
        public void TestMultipleFive_Negative()
        {
            // Create a list of integers that are NOT multiples of 5
            List<int> notFives = new List<int>();

            // Offset by one: 1,6,11...
            for (int value = 1; value <= 100; value += 5)
            {
                notFives.Add(value);
            }
            // Offset by two: 2,7,12...
            for (int value = 2; value <= 100; value += 5)
            {
                notFives.Add(value);
            }
            // Offset by three: 3,8,13...
            for (int value = 3; value <= 100; value += 5)
            {
                notFives.Add(value);
            }
            // Offset by four: 4,9,14...
            for (int value = 1; value <= 100; value += 5)
            {
                notFives.Add(value);
            }

            // Test the method
            foreach (int value in notFives)
            {
                Assert.IsFalse(FizzBuzzModel.IsMultipleFive(value));
            }
        }
    }
}
