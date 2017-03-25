using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = new Dictionary<char, int>();
            foreach (var word in text)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }
            foreach (var kvp in result)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
