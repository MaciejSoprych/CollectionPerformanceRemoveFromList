using System;
using System.Diagnostics;

namespace CollectionPerformanceRemoveFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListManager listManager = new ListManager();
            
            var list2 = TxtReader.GetList();
            Stopwatch stopWatch2 = Stopwatch.StartNew();
            listManager.RemoveItemsOofN(list2);
            stopWatch2.Stop();
            Console.WriteLine($"time O(N) milliseconds: {stopWatch2.ElapsedMilliseconds}");

            var list1 = TxtReader.GetList();
            Stopwatch stopWatch1 = Stopwatch.StartNew();
            listManager.RemoveItemsOofN2(list1);
            stopWatch1.Stop();
            Console.WriteLine($"time O(N)^2 milliseconds: {stopWatch1.ElapsedMilliseconds}");



        }
    }
}
