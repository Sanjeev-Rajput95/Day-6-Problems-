using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_problems
{
    internal class Day6_Problems
    {
        public void Fibonacci_Series ()
        {
            int num;
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.Write("Enter the number : ");
            // string inputByUser = Console.ReadLine();
            //int num = Int32.Parse(inputByUser);
             num = int.Parse(Console.ReadLine());
            Console.Write(" " + num1 + " " + num2 + " " );
            
            for (int i = 2; i <= num; i++ )
            {
                num3 = num1 + num2;
                Console.Write(" " + num3 + " ");
                num1 = num2;
                num2 = num3;
            }

        }

        public void Perfect_Number ()
        {
            int n, i, sum;
            Console.WriteLine("");
            Console.Write("Check whether a given number is perfect number or not:\n");
            Console.Write("--------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.Write("\nSo, the number is perfect.");
            else
                Console.Write("\nSo, the number is not perfect.");
            Console.Write("\n");
        }

        public void Prime_Number()
        {
            Console.WriteLine("");
            Console.Write("Check whether a given number is prime number or not:\n");
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }

        public void Reverse_Number ()
        {
            Console.WriteLine("\n");
            int n, reverse = 0, rem;
            Console.Write("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }

        //method to generate the distinct coupon number
        public void generateNDistinctCouponNum(int n)
        {
            Console.WriteLine("\n");
            //array to store the distinct coupon number
            int[] CouponNumber = new int[n];
            int index = 0;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                //generate a random number
                int randomNumber = random.Next();

                //for the first element
                if (index == 0)
                {
                    //add the first random number in the array
                    CouponNumber[index] = randomNumber;
                    index++;

                }
                //for the other element
                else
                {
                    //using the for loop check whether the random number is distinct or not
                    for (int j = 0; j < index; j++)
                    {
                        while (randomNumber == CouponNumber[j])
                        {
                            randomNumber = random.Next();
                        }
                    }
                    //add the random number to the array
                    CouponNumber[index] = randomNumber;
                    index++;
                }
            }
            //display the distinct random number
            Console.WriteLine(n + " Distinct Coupon Numbers are:");
            for (int i = 0; i < CouponNumber.Length; i++)
            {
                Console.WriteLine(CouponNumber[i]);
            }
        }


        public void Simulate_Stopwatch()
        {
            Console.WriteLine("\n ");
            DateTime start = DateTime.Parse(" 7:30");
            DateTime end = DateTime.Parse(" 16:00 ");
            Console.WriteLine((end - start).TotalHours);
        }
    }
}
