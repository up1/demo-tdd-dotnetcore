using System;

namespace demo
{
    public class FizzBuzz
    {
        public string Say(int input)
        {
            if (หารสามลงตัว(input))
                return "Fizz";
            if (input == 5)
                return "Buzz";
            
            return input.ToString();
        }

        private bool หารสามลงตัว(int input) {
            return input % 3 == 0;
        }
    }

}