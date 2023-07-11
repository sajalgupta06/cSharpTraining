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

        public class Emp
        {


            public int Salary( int workingHours = 0, int workingDays = 0, int projectHandles=0, int extras=0)
            {
               
                return workingHours * workingDays * 100 + projectHandles * 3000 + extras * 2000;


            }
        }

        static void Main(string[] args)
        {
          Emp emp = new Emp();


            int wh;
            int wd;
            int ph;
            int extras;
            string type;
            Console.WriteLine("Choose employee type");
            type = Console.ReadLine();


            

            switch (type)
            {
                case "HR":
                    {
                        Console.WriteLine("Enter working Hours, working days");
                        wh = int.Parse(Console.ReadLine());
                        wd = int.Parse(Console.ReadLine());
                        Console.WriteLine("Employee Salary is " + emp.Salary(wh,wd,1));
                        break;

                    }
                case "ADMIN":
                    {
                        Console.WriteLine("Enter working Hours, working days,project handle");
                        wh = int.Parse(Console.ReadLine());
                        wd = int.Parse(Console.ReadLine());
                        ph = int.Parse(Console.ReadLine());
                        Console.WriteLine("Employee Salary is " + emp.Salary(wh, wd,ph));
                        break;
                    }

                case "SOFTWARE_DEVELOPER":
                    {
                        Console.WriteLine("Enter working Hours, working days,project handle,extras");
                        wh = int.Parse(Console.ReadLine());
                        wd = int.Parse(Console.ReadLine());
                        ph = int.Parse(Console.ReadLine());
                        extras = int.Parse(Console.ReadLine());
                        Console.WriteLine("Employee Salary is "+emp.Salary(wh, wd, ph,extras));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Attempt");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }



}