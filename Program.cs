using System;
using System.Collections.Generic;
using System.Reflection;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 5, 23, 3, 45, 1, 39, 6, 2, 6, 7 };

            var list = new List<ISort>
            {
                new BubbleSort(),
                new SimpleSort(),
                new DirectInsertSort(),
                new ShellSort(),
                new QuickSort()
            };

            foreach (var item in list)
            {
                item.Sort(arr);
            }
        }
    }
}
