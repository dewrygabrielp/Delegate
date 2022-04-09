using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            //El delegado se usa para almacenarle un metodo y ese metodo mandarlo por parametro a otro metodo y durante
            //su ejecucion se mostrara la ejecucion de ambos metodos.

            //Devuelve un valor
            Func<double, double, double> Sum1 = Result;

            //No devuelve nada
            Action<double, double, double> Sum2;

            Show show = ShowName;
            MakeAny(show);
            Make(show);


            Sum Su = SumNumbers;
            Numbers(Su);
            Console.WriteLine(Nada(Sum1));
           
            
            

                

        }
        public delegate void Show();
        public delegate int Sum(int a, int b);
        public  Func<double, double, double> Sum1 = Result;
        public static double Nada(Func<double, double, double> Sum2)
        {
            return Sum2(5, 5);
        }
        public static double Result(double a, double b)
        {
            a = 10;
            b = 20;

            return a + b;
        }

        public static void Sum10(Func<double, double, double> Suma)
        {
           double Num1 = 0.50;
           double Num2 = 0.50;

            Console.WriteLine(Suma(Num1, Num2));
            
        }

        public static void ShowName()
        {
            Console.WriteLine("Mi nombre es Dewry");
        }
        public static void MakeAny(Show show)
        {
            Console.WriteLine("Te voy a decir mi nombre: ");
            
            show();
        }
        public static void Make(Show make)
        {
            Console.WriteLine("Te dije mi nombre");
            make();
        }
        public static int SumNumbers(int a, int b)
        {
            int Result = a + b;
            return Result;
        }
        public static void Numbers(Sum sum)
        {
            Console.WriteLine(sum(15, 10));
            Console.WriteLine("Esta es una suma: de 10 y 15 = 25");
            
        }
    }
}
