using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public static class AListOfCompanies 
    {
        public static void Main(string[] args) 
        {
            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<String> my_list = new LinkedList<String>();
            
            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Company Share 1");
            my_list.AddLast("Company Share 2");
            my_list.AddLast("Company Share 3");
            my_list.AddLast("Company Share 4");
            my_list.AddLast("Company Share 5");
            my_list.AddLast("Company Share 6");
            Console.WriteLine("List Of Company Shares :");

            // Accessing the elements of
            // LinkedList Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
            // After using Remove(LinkedListNode)
            // method
            Console.WriteLine("List Of Company Shares :");

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(T) method
            Console.WriteLine("List Of Company Shares :");

            my_list.Remove("Company Share 1");
            // After using Remove(LinkedListNode)
            // method

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(T) method
            Console.WriteLine("List Of Company Shares :");

            my_list.Remove("Company Share 2");
            // After using Remove(LinkedListNode)
            // method

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(T) method
            Console.WriteLine("List Of Company Shares :");

            my_list.Remove("Company Share 3");

            my_list.AddLast("Company Share 1");
            // Accessing the elements of
            // LinkedList Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
            // After using Remove(LinkedListNode)
            // method
            Console.WriteLine("List Of Company Shares :");


        }

    }
}

