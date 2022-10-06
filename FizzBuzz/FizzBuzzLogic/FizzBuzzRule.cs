using System;

namespace FizzBuzz.FizzBuzzLogic
{
    public class FizzBuzzRule
    {
        public Func<int, bool> op { get; set; }
        public string output { get; set; }
        public FizzBuzzRule(RuleType ruleType)
        {
              if (RuleType.Fizz == ruleType || RuleType.Buzz == ruleType || RuleType.Bar == ruleType)
                this.op = RemainderRule(ruleType);
            else
                this.op = MultiplicationRule(ruleType);
            this.output = ruleType.ToString();  
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
    public enum RuleType
    {
        Fizz = 3, Buzz = 5, Bar = 7, Foo = 10
    };

}
