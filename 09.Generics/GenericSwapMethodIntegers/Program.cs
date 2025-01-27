﻿using System.Runtime.CompilerServices;

namespace GenericSwapMethodIntegers
{
    class Program
    {
        static void Main()
        {
            Box<int> box = new Box<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }
            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index1 = indices[0], index2 = indices[1];

            box.Swap(index1, index2);
            Console.WriteLine(box);
        }
    }
}