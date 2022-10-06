using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.FizzBuzzLogic
{
    public class FizzBuzzEngine
    {
        private FizzBuzzRule[] rules { get; set; }
        public FizzBuzzEngine() => this.rules = new FizzBuzzRule[] { };        
        public FizzBuzzEngine(FizzBuzzRule[] r) => this.rules = r;
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
}
