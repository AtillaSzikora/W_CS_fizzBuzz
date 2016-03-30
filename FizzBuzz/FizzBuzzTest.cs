using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzApp;

namespace FizzBuzzTest {

    [TestClass]
    public class FizzBuzzTest {

        [TestMethod]
        public void GetFizzBuzz_OnOne_ReturnsOneAsString() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetFizzBuzz(1);
            Assert.AreEqual(result, "1"); }

        [TestMethod]
        public void GetFizzBuzz_OnTwo_ReturnsTwoAsString() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetFizzBuzz(2);
            Assert.AreEqual(result, "2"); }

        [TestMethod]
        public void GetFizzBuzz_OnThree_ReturnsThreeAsString() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetFizzBuzz(3);
            Assert.AreEqual(result, "Fizz"); }

        [TestMethod]
        public void GetFizzBuzz_OnSix_ReturnsSixAsString() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetFizzBuzz(6);
            Assert.AreEqual(result, "Fizz"); }

        [TestMethod]
        public void GetFizzBuzz_OnFive_ReturnsFiveAsString() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetFizzBuzz(5);
            Assert.AreEqual(result, "Buzz"); }

        [TestMethod]
        public void GetFizzBuzz_OnFifteen_ReturnsFifteenAsString() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetFizzBuzz(15);
            Assert.AreEqual(result, "FizzBuzz"); }

        [TestMethod]
        public void Generate_ReturnsFizzBuzzList1To100() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            List<string> result = fizzBuzz.Generate();
            Assert.AreEqual(100, result.Count); }
    }
}