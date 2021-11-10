using System;

namespace HomeWork3
{
    class Program
    {

        public static double Task1(int a, int b)
        {
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }
            return result;
        }
            public static int Task2(int A)
        {
            int count=0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i % A == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int Task3(int A)
        {
            int count = 0;
            for (int i = 1; i <= 5; i++)
            {
                if ((i > 0) && (i*i > A))
                {
                    count++;
                }
            }
            return count;
        }

        public static int Task4(int a, int b)
        {
            while(b!=0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static int Task5(int a, int b)
        {
            int sum = 0;
            int result=0;
            if (a > b)
            {
                for (; a <= b; a++)
                {
                    if(a % 7 == 0)
                    {
                        sum += a;
                    }
                }
                result = sum;
            }
            else
            {
              for(; b <= a; b++)
                {
                    if (b % 7 == 0)
                    {
                        sum += b;
                    }
                    result = sum;
                }
            }
            return result;
         }

        public static int Task6(int n)
        {
            int prev = 0;
            int next = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }

        public static int Task7(int a, int b)
        {
            {
                while ((a != 0) && (b != 0))
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                return Math.Max(a, b);
            }
        }

        public static int Task9(int a)
        {
            int check, count = 0;
            while(true)
            {
                check = a % 10;
                a /= 10;
                if(check % 2 != 0)
                {
                    count++;
                }
            }
            return count++;
        }

        public static int Task10(int a)
        {
            int b=0;
            while (a !=0)
            {
                int c = a % 10;
                b = b * 10 + c;
                a /= 10;
            }
            return b;
        }

        public static void Task11(int n)
        {
            int check, countEven = 0, countNotEven = 0;
            for (int i = 1; i <= n; i++)
            {
                check = i % 10;
                i /= 10;
                if (check % 2 != 0)
                {
                    countNotEven++;
                }
                else
                {
                    countEven++;
                }
                if (countEven > countNotEven)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //public static int Task11(int n)
        //{
        //    int checkE, checkNe, sumE = 0, sumNE=0;
        //    for (int i = 1; i < n; i++)
        //    {

        //    }

        //}

        static void Main(string[] args)
        {
            //int A = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Task10(123));
            Task11(20);
            Console.ReadKey();
        }
    }
}
