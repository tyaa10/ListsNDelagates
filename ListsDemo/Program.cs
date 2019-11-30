using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList al1 = new ArrayList();
            Console.WriteLine($"Count = {al1.Count}; Capacity = {al1.Capacity}");
            al1.Add("Hello");
            Console.WriteLine($"Count = {al1.Count}; Capacity = {al1.Capacity}");
            al1.Add("World");
            Console.WriteLine($"Count = {al1.Count}; Capacity = {al1.Capacity}");
            al1.Add(4);
            Console.WriteLine($"Count = {al1.Count}; Capacity = {al1.Capacity}");
            al1.Add(5);
            Console.WriteLine($"Count = {al1.Count}; Capacity = {al1.Capacity}");
            al1.Add(44);
            Console.WriteLine($"Count = {al1.Count}; Capacity = {al1.Capacity}");

            List<string> vs;

            LinkedList<string> ll1 = new LinkedList<string>();
            // ll1.AddLast(4);*/

            // SortedList sortedList = new SortedList();
            /* SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(100, "abc");
            sortedList.Add(10, "zxc");
            sortedList.Add(0, "asd");
            sortedList.Add(-10, "rty");
            // sortedList.Add(true, "lkj");
            foreach (var item in sortedList)
            {
                // Console.WriteLine(((DictionaryEntry)item).Key + " " + ((DictionaryEntry)item).Value);
                Console.WriteLine(item);
            } */

            List<string> vs = new List<string>() { "Hello", "World", "!", "..." };
            /* foreach (var item in vs)
            {
                Console.WriteLine(item);
            } */

            /* int i = 0;
            foreach (var item in vs)
            {
                if (i == 1)
                {
                    vs.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine(item);
                }
                i++;
            } */

            /* for (int i = 0; i < vs.Count; i++)
            {
                if (i == 1)
                {
                    vs.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine(vs[i]);
                }
            } */

            /* for (int i = 0; i < vs.Count; i++)
            {
                if (i == 1)
                {
                    vs.RemoveAt(i);
                    i--;
                }
                else
                {
                    Console.WriteLine(vs[i]);
                }
            } */

            /* IEnumerator en = vs.GetEnumerator();
            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
            } */

            int i = 0;
            int oldCount = vs.Count;
            while (i < vs.Count)
            {
                if (i == 1 && oldCount == vs.Count)
                {
                    vs.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine(vs[i]);
                    i++;
                }
            }

            Console.WriteLine("*******");

            for (int j = 0; j < vs.Count; j++)
            {
                Console.WriteLine(vs[j]);
            }

            // Test comment 1
            // Test comment 2
            // Test comment 3
        }
    }
}
