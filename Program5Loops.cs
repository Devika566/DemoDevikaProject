namespace ConApp1
{
    class Program5Loops
    {
        static void Main()
        {
            /*int i;
            i = 1; //Intial value
            Console.WriteLine("Generate 1 to 10 using while loop...");
            while(i<=10) //condition
            {
                Console.Write($"{i} ");
                i++; //update value
            }

            Console.WriteLine("\nGenerate 1 to 10 using for loop");
            for(i = 1;i<=10;i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nGenerate 1 to 10 using do while loop");
            i = 1;
            do
            {
                Console.Write(i + " ");
                i++;
            }while(i<=10); */

            //Display 10 to 1
            int a;
            a = 10;
            Console.WriteLine("Generate 10 to 1 using while loop...");
            while (a>=1)
            {
                Console.Write($"{a} ");
                a--;
            }
            Console.WriteLine();

            //Display 2,4,6,8,10.
            int b;
            b = 2;
            Console.WriteLine("Generate even numbers upto 10 using while loop...");
            while (b <= 10)
            {
                Console.Write($"{b} ");
                b+=2;
            }
            Console.WriteLine();

            //Display 1,3,5,7,9.
            int c;
            c = 9;
            Console.WriteLine("Generate odd numbers upto 10 using while loop...");
            while (c>=1)
            {
                Console.Write($"{c} ");
                c -= 2;
            }
            Console.WriteLine();


        }
    }
      /* Loop:
       Used to iterate,generate sequence
      3-types of loops:
      while:    Entry control loop ------infinte category
      for:      Entry control loop ------finite category
      do..while:Exit control loop -------infinite category
      */



}
