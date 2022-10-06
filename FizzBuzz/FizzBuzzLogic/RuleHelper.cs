using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.FizzBuzzLogic
{
    public static class RuleHelper
    {
        public static FizzBuzzRule[] RuleBook()
        {
            var fizz = new FizzBuzzRule(RemainderRule(RuleType.Fizz), "Fizz");
            var buzz = new FizzBuzzRule(RemainderRule(RuleType.Buzz), "Buzz");
            var bar = new FizzBuzzRule(RemainderRule(RuleType.Bar), "Bar");
            var foo = new FizzBuzzRule(MultiplicationRule(RuleType.Foo), "Foo");
            var rulez = new FizzBuzzRule[] { fizz, buzz, bar, foo };
            return rulez;
        }
        private static Func<int, bool> RemainderRule(RuleType arule)
        {
            Func<int, bool> rfunc = (i) => i % (int)arule == 0;
            return rfunc;
        }
        private static Func<int, bool> MultiplicationRule(RuleType arule)
        {
            Func<int, bool> rfunc = (i) => i * (int)arule > 100;
            return rfunc;
        }
    }
}
