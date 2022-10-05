using System;
using System.Collections.Generic;

/**
 *
 * Given is the following FizzBuzz application which counts from 1 to 100 and outputs either the corresponding
 * number or the corresponding text if one of the following rules apply.
 * Rules:
 *  - dividable by 3 without a remainder -> Fizz
 *  - dividable by 5 without a remainder -> Buzz
 *  - dividable by 3 and 5 without a remainder -> FizzBuzz
 *
 * ACCEPTANCE CRITERIA:
 * Please refactor this code so that it can be easily extended in the future with other rules, such as
 * "if it is dividable by 7 without a remainder output Bar"
 * "if multiplied by 10 is larger than 100 output Foo"
 *
 */

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        private FizzBuzzRule[] rules { get; set; }
        public FizzBuzzEngine()
        {
            this.rules = new FizzBuzzRule[] { };
        }
        public FizzBuzzEngine(FizzBuzzRule[] r)
        {
            this.rules = r;
        }
        public void Run(int limit = 110)
        {
            for (int i = 1; i <= limit; i++)
            {
                string output = "";
                foreach (FizzBuzzRule rule in this.rules)
                {
                    if (rule.op(i))
                        output += rule.output;                    
                }
                if (string.IsNullOrEmpty(output))
                    output = i.ToString();
                Console.WriteLine("{0}: {1}", i, output);
            }
        }      
    }
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

    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzzRule[] rulez = RuleBook();
            FizzBuzzEngine engine = new FizzBuzzEngine(rulez);
            engine.Run();
        }

        private static FizzBuzzRule[] RuleBook()
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
            Func<int, bool> rfunc =(i) => i % (int) arule == 0;
            return rfunc;
        }
        private static Func<int, bool> MultiplicationRule(RuleType arule)
        {
            Func<int, bool> rfunc = (i) => i * (int) arule > 100;
            return rfunc;
        }
    }
}
