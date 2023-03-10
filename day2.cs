using System;

namespace _day2_
{
    class Program
    {
        static void Mian(string[] args)
        {
            //变量的交换
            // //方法1
            // int a=10,b=5;
            // int temp;
            // temp=a;
            // a=b;
            // b=temp;
            // //缺点：占据内存多
            // //方法2
            // int a=5,b=10;
            // a=a+b;
            // //此时a=15
            // b=a-b;
            // //b=15-5=10  也就是赋给b了a的值
            // a=a-b;
            // //a=15-10=5    

            //格式化输出
            int a=10,b=5;
            //欲输出a+b
            Console.WriteLine(a+"+"+b+"="+(a+b));
            //每个部分要用+连接到一起，表达式要用括号括起来否则会当做单独数据输出
            Console.WriteLine("a+b=c",a,b,a+b);
            //类似c语言的printf
            //也可以这样  用大括号加上取值的标号
            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            //不能取不存在的值 比如后面只有三个数，但是前面取了{3}这样是不可以的

            

        }
    }
}