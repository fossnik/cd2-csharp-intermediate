﻿using System;
using System.Collections.Generic;

namespace Lecture10
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }

    public class Order
    {
        
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}