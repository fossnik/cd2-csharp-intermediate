using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Exercise: Design a Stack
 * A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion.
 * Design a class called Stack with three methods.
 *
 * void Push(object obj)
 * object Pop()
 * void Clear()
 */
namespace Exercises_Inheritance
{
    public class Stack
    {
        // creates an encapsulated list (of objects) for a stack
        private List<object> stack;

        public void Push(object obj)
        {
            stack.Add(obj);
        }

        public object Pop()
        {
            var last = stack.FindLastIndex();
            var last_element = stack.ElementAt(last);
            
            stack.RemoveAt(last);
            return last_element;
        }

        public void Clear()
        {
            stack.RemoveAll();
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}