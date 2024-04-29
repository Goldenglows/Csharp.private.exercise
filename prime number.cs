using System;
using System.Collections.Generic;
using static System.Console;

namespace practice_primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //if (input != null)
            //{
            //    int MAX = int.Parse(input);
            //}
            //else
            //{
            //    Console.WriteLine("输入不能为空。");
            //}
            int MAX = int.Parse(Console.ReadLine());
            //false is prime number 
            bool[] prime = new bool[MAX];

            prime[0] = true;
            prime[1] = true;

            int num = 2, i;

            while (num < MAX) 
            { 
                if (! prime[num]) 
                {
                    // 对 num 的所有倍数进行标记为非质数
                    for (i = num; i < MAX; i+= num)
                    {
                        if (prime[i])
                            continue;
                        //将所有的非质数为true
                        prime[i] = true;
                    }
                }
                num++;
            }

            Console.WriteLine($"1 to {MAX} , PRIME NUMBERS ARE AS FOLLOW:\n");
            
            for (i=2,num=0; i<MAX; i++)
            {
                if (!prime[i])
                {
                    num++;
                    if (num % 5 == 0)
                        Console.WriteLine(i + '\n');
                    else
                        Console.WriteLine(i + '\t');
                }
            }

            WriteLine("\n\n PRIME NUMBER IS："+num);
            ReadKey();
        }
    }

}
