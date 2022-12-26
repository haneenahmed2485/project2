using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count, low, high;
            Console.WriteLine("Enter the lower range");
            low = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the high range");
            high = int.Parse(Console.ReadLine());

            for (int num = low; num <= high; num++)
            {
                count = 0;
                for (int i =2; i <= num/2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }

                }
                if (count == 0 && num  != 1)
                    Console.WriteLine(num);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
















           







            














                



        














                
           
          





            













             














































































        }

































    }
    }

