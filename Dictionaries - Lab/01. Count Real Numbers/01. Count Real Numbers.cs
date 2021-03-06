﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = new SortedDictionary<double, int>();
            foreach (var num in numbers)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 0;
                }
                result[num]++;
            }
            foreach (var kvp in result.Keys)
            {
                Console.WriteLine($"{kvp} -> {string.Join(" ", result[kvp])}");
            }
        }
    }
}
