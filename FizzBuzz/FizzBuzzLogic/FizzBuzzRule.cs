using System;

namespace FizzBuzz.FizzBuzzLogic
{
    public class FizzBuzzRule
    {
        public Func<int, bool> op { get; set; }
        public string output { get; set; }
        public FizzBuzzRule(Func<int, bool> op, string output)
        {
            this.op = op;
            this.output = output;
        }
    }
    enum RuleType
    {
        Fizz = 3, Buzz = 5, Bar = 7, Foo = 10
    };

}