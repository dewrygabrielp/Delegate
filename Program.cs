using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            /*      #Delegate
             *      
               The delegate is used to store in a variable that the delegate generates
                        the functionality of a method and whose method we can pass as 
                              a parameter to another function or method


         # Func and Action

                         Action does not return any value while Func does
             */
           Person.Register(SearchMaxNumber, new List<int> { 1, 2, 3 });
            //Way #1
            FindMaxNumber Fun1 = SearchMaxNumber;

            Console.WriteLine(Fun1(new List<int> { 1, 5, 5, 3, 8, 9, 78 }));

            //Way #2
            FindMaxNumber Fun2 = delegate (List<int> lst)
            {
                return lst.OrderByDescending(d => d).First();
            };

            Console.WriteLine(Fun2(new List<int> { 1, 5, 5, 3, 8, 9, 78 }));

            //Way #3
            FindMaxNumber Fun3 = f => f.OrderByDescending(d=>d).First();

            Console.WriteLine(Fun3(new List<int> { 1, 5, 5, 3, 8, 9, 78 }));

        }
       public delegate int FindMaxNumber(List<int> lst);

        public static int SearchMaxNumber(List<int> lst)
        {
            return lst.OrderByDescending(d => d).First();
        }

        public class Person
        {
            public static void Register(FindMaxNumber Fn, List<int> lst)
            {
                Console.WriteLine("A user has just registered in the database");

                int a = Fn(lst);
                Console.WriteLine("Send confirmation email\n" + a);
            }
        }
    
    }
}
