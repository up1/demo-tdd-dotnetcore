using Xunit;
using demo;

namespace HelloTests
{
    public class UnitTest1
    {
        [Fact]
        public void six_should_say_fizz()
        {
            var fizzBuzz = new FizzBuzz();
            var actualResult = fizzBuzz.Say(6);
            Assert.Equal("Fizz", actualResult);
        }

        [Fact]
        public void five_should_say_buzz()
        {
            var fizzBuzz = new FizzBuzz();
            var actualResult = fizzBuzz.Say(5);
            Assert.Equal("Buzz", actualResult);
        }

        [Fact]
        public void four_should_say_four()
        {
            var fizzBuzz = new FizzBuzz();
            var actualResult = fizzBuzz.Say(4);
            Assert.Equal("4", actualResult);
        }

        [Fact]
        public void three_should_say_fizz()
        {
            var fizzBuzz = new FizzBuzz();
            var actualResult = fizzBuzz.Say(3);
            Assert.Equal("Fizz", actualResult);
        }

        [Fact]
        public void one_should_say_one()
        {
            var fizzBuzz = new FizzBuzz();
            var actualResult = fizzBuzz.Say(1);
            Assert.Equal("1", actualResult);
        }

        [Fact]
        public void two_should_say_two()
        {
            var fizzBuzz = new FizzBuzz();
            var actualResult = fizzBuzz.Say(2);
            Assert.Equal("2", actualResult);
        }

     }
}
