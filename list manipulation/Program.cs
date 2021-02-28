using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace list_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare all required lists
            List<int> firstName_surName1 = new List<int>();
            List<int> firstName_surName2 = new List<int>();
            List<int> firstName_surName3 = new List<int>();

            //adding values using for statement
            //mat no. u2018/3025052
            //hence ending of mat no. being 2
            //will start the list sequence
            for (int i = 2; i < 12; i++) {
                firstName_surName1.Add(i);
            }

            Console.WriteLine("\nvalues for firstName_surName1 are; ");
            // foreach iteration to print out all values of firstName_surName1
            foreach (int nums in firstName_surName1)
            {
                Console.Write(nums);
                Console.ReadLine();
            }


            // adding values to firstName_surName2
            //on the given condition i.e raised to the power 2
            firstName_surName2.Add(firstName_surName1[0] * firstName_surName1[0]);
            firstName_surName2.Add(firstName_surName1[1] * firstName_surName1[1]);
            firstName_surName2.Add(firstName_surName1[2] * firstName_surName1[2]);
            firstName_surName2.Add(firstName_surName1[3] * firstName_surName1[3]);
            firstName_surName2.Add(firstName_surName1[4] * firstName_surName1[4]);
            firstName_surName2.Add(firstName_surName1[5] * firstName_surName1[5]);
            firstName_surName2.Add(firstName_surName1[6] * firstName_surName1[6]);
            firstName_surName2.Add(firstName_surName1[7] * firstName_surName1[7]);
            firstName_surName2.Add(firstName_surName1[8] * firstName_surName1[8]);
            firstName_surName2.Add(firstName_surName1[9] * firstName_surName1[9]);


            Console.WriteLine("\nvalues for firstName_surName2 are; ");
            // foreach iteration to print out values of variable firstName_surName2
            foreach (int value in firstName_surName2)
            {
                Console.Write(value);
                Console.ReadLine();
            }


            // adding numbers to firstName3_surName3
            // on condition that the value is the sum of both firstName_surName1
            // and firstName_surName2
            firstName_surName3.Add(firstName_surName1[0] + firstName_surName2[0]);
            firstName_surName3.Add(firstName_surName1[1] + firstName_surName2[1]);
            firstName_surName3.Add(firstName_surName1[2] + firstName_surName2[2]);
            firstName_surName3.Add(firstName_surName1[3] + firstName_surName2[3]);
            firstName_surName3.Add(firstName_surName1[4] + firstName_surName2[4]);
            firstName_surName3.Add(firstName_surName1[5] + firstName_surName2[5]);
            firstName_surName3.Add(firstName_surName1[6] + firstName_surName2[6]);
            firstName_surName3.Add(firstName_surName1[7] + firstName_surName2[7]);
            firstName_surName3.Add(firstName_surName1[8] + firstName_surName2[8]);
            firstName_surName3.Add(firstName_surName1[9] + firstName_surName2[9]);


            Console.WriteLine("\nvalues for firstName_surName3 are;");
            //iteration to print out all the values of firstName_surName3
            foreach (int values in firstName_surName3)
            {
                Console.Write(values);
                Console.ReadLine();
            }


            firstName_surName1.Clear();
            Console.WriteLine("\nthere are " + firstName_surName1.Count() + " elements in this list(firstName_surName1)");
            Console.ReadLine();

            firstName_surName2.Clear();
            Console.WriteLine("there are " + firstName_surName2.Count() + " elements in this list(firstName_surName2)");
            Console.ReadLine();

            firstName_surName3.Clear();
            Console.WriteLine("there are " + firstName_surName3.Count() + " elements in this list(firstName_surName3)");
            Console.ReadLine();
        }
    }
}

