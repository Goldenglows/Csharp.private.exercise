using System;

namespace _类型转换
{
    class Program
    {
        static void Main (string[] args)
        {
            int a = 10;
            double b = a;
            //这里自动将a转换为小数类型  10-10.0

            double c = 1234567897478;
            a = (int)c; //这样可以把大盒子放在小盒子里面
            //但是如果位数过大则会发生溢出1234567897-1234567897   十位数最大
            Console.WriteLine(a);
            //c为34.23 a为34 
            // a = c;
            //此处没有自动类型转换，因为double 比int取值范围大
            //大盒子不能放在小盒子里面，小盒子可以放在大盒子里面

            Father f = new Son();

            //这样是先创建一个Son，暂时把他当成Father来用
            //以后需要用到Son的功能时，才需要类型转换

            // Son s = f;
            //这样是不允许的，因为f是Father类里面的，s是Son类，不可以直接赋值

            Son s = (Son)f;

            Son s = f as Son;
            //这种写法的好处在于，如果转换失败了会返回一个NULL

            //可以这样进行赋值，前提f是包含在Son内的，本质上是Son类型

            // Father F = new Father();
            // //定义一个Father类型
            // Son s = (Son)F;k
            // //这样F是一个Father类型 ，不可以直接赋值

            


        }
    }

    class Father
    {

    }

    class Son : Father
    {
        //Son类继承自Father
        public void SonMethod()
        {

        }

    }
}