using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToList();
            var result = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }
            var total = new List<string>();
            foreach (var kvp in result)
            {
                var value = kvp.Value;
                if (value%2==1)
                {
                    total.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", total));
        }
    }
}
