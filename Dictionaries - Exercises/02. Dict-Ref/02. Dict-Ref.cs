using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictRef = new Dictionary<string, int>();
            while (input != "end") 
            {
                var token = input.Split();
                var name = token[0];
                var value = token[token.Length - 1];
                var number = 0;
                int.TryParse(value, out number);
                if (number > 0) 
                {
                    dictRef[name] = number;
                }
                if (dictRef.ContainsKey(value))
                {
                    var refferencedValue = dictRef[value];
                    dictRef[name] = refferencedValue;
                }
                input = Console.ReadLine();
            }
            foreach (var kvp in dictRef)
            {
                Console.WriteLine("{0} === {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
