﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T).ToString()}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

        public void Add(T item)
        {
            list.Add(item);
        }
    }
}