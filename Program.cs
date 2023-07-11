using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Call by value
/*namespace ConAppMethods
{
    *//*  public class OurClass
      {
          public void Display()
          {
              Console.WriteLine("Hello");
          }
      }
      *//*
    public class Calc
    {
        public void Inc(int num)
        {
            Console.WriteLine("Value of num in method befoew inc"+ num );
            num += 5;
            Console.WriteLine("Value of num in method after inc" + num);

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int mynum = 5;
            Calc obj = new Calc();
            Console.WriteLine("Value of num in Main befoew inc" + mynum);
             obj.Inc(mynum);
            Console.WriteLine("Value of num in Main after inc" + mynum);
            Console.ReadKey();

        }
    }
}
*/



namespace ConAppMethods
{
   
   /* public class Calc
    {
        public void Inc(double salary, out double bonus )
        {
            bonus = salary * 0.15;

        }
    }
*/
    //ref keyword
    /*    internal class Program
        {
            static void Main(string[] args)
            {
                int mynum = 5;
                Calc obj = new Calc();
                Console.WriteLine("Value of num in Main befoew inc" + mynum);
                obj.Inc(ref mynum);
                Console.WriteLine("Value of num in Main after inc" + mynum);
                Console.ReadKey();

            }
        }
    }*/


    // out keyword
    /*   internal class Program
       {
           static void Main(string[] args)
           {
               double salary = 40000 ;
               double bonus;
               Calc obj = new Calc();
               obj.Inc( salary,out bonus);
               Console.WriteLine($"salary {salary}, bonus:{bonus}");
               Console.ReadKey();

           }
       }
   */

    // params keyord
    internal class Program
    {

        public class Calc
        {
            public void Add(params double[] numbers)
            {
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void Main(string[] args)
        {
            double salary = 40000;
            double bonus;
            Calc obj = new Calc();
            obj.Add(1,2,3,4,5);
            Console.ReadKey();

        }
    }



}