using System;

namespace FizzBuzzApp {

    class FizzBuzzApp {

        static void Main(string[] args) {
            var fizzBuzz = new FizzBuzz();
            foreach (var item in fizzBuzz.Generate()) {
                Console.WriteLine(item); } }
    }
}
