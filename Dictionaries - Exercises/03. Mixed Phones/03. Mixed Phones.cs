using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    public class Program
    {
        public static void Main()
        {
            var phoneNumbers = new SortedDictionary<string, long>();
            var line = Console.ReadLine();
            while (line!="Over")
            {
                var token = line.Split("  :".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                var firstElement = token[0];
                var secondElement = token[1];
                long phoneNumber = 0;
                if (long.TryParse(firstElement, out phoneNumber))
                {
                    phoneNumbers[secondElement] = phoneNumber;
                }
                else if(long.TryParse(secondElement, out phoneNumber))
                {
                    phoneNumbers[firstElement] = phoneNumber;
                }
                line = Console.ReadLine();
            }
            foreach (var kvp in phoneNumbers)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
