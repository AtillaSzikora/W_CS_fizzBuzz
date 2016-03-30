using System.Collections.Generic;

namespace FizzBuzzApp {

    public class FizzBuzz {

        public string GetFizzBuzz(int number) {

            if (number % 15 == 0) {
                return "FizzBuzz"; }

            if (number % 3 == 0) {
                return "Fizz"; }

            else if (number % 5 == 0) {
                return "Buzz"; }

            return number.ToString(); }

        public List<string> Generate() {
            var resultList = new List<string>();
            for (int i = 1; i < 101; i++) {
                resultList.Add(GetFizzBuzz(i)); }
            return resultList; } }
}
