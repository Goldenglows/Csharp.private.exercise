using System;

namespace _002_
{
    class Program
    {
        static void Main(string[] args){
            //创建变量
            String str = Console.ReadLine()!;
            //ReadLine 必须要赋给字符串才可以
            //int a = Console.ReadLine();
            //这种类型是不合理的
            System.Console.WriteLine(str+"-");
            //只能将字符串的整数转换成一个整数：“12” - 12
            int Strint = Convert.ToInt32(str);
            System.Console.WriteLine(Strint+"-");
            //这样就会输出整数了

            //或者可以这样子
            int strint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strint);
        }
    }
}
