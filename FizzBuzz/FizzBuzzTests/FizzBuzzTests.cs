using FizzBuzz;
using NUnit.Framework;
using System;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1, "1")]      //passing TestCase (FizzBuzz return "1")
        [TestCase(2, "2")]      //Failing TestCase (FizzBuzz return "1"), Passing TestCase (FizzBuzz return "2")
        [TestCase(3, "Fizz")]   //Test for Fizz (input/3)
        [TestCase(5, "Buzz")]   //Test for buzz (input/5)
        [TestCase(6, "Fizz")]   //Test for Fizzbuzz (input/3)
        [TestCase(10, "Buzz")]   //Test for Fizzbuzz (input/5)
        [TestCase(15, "FizzBuzz")]   //Test for Fizzbuzz (input /5 && /3)
        public void FizzBuzzer_GivenInt_returnsString(int input, string expected)   
        {
           
            FizzBuzzer fb = new FizzBuzzer();       //instantiates a variable of class FizzBuzzer
            string actual = fb.FizzBuzz(input);     //declares local var actual, calls the Fizzbuzz method and assigns the input value to the local var 'actual'
            Assert.AreEqual(expected, actual);       // Checks if the input matches the expected value
        } 
    }
}
