using System;
using System.Collections.Generic;
using System.Text;

namespace leiyingyong
{
    class Vehicle
    {
        public int Speed;
        public int MaxSpeed;
        public int Weight;

        public void Run(){
            Console.WriteLine("车启动");
        }

        public void Stop(){
            Console.WriteLine("车熄火");
        }

    }

    class Vector3
    {
        public int x;
        public int y;
        public int z;
        public double Get_Lenght(int x1,int y1,int z1)
        {
            return Math.Sqrt(x*x+y*y+z*z);
        }
        public void Set()
        {
            Console.WriteLine("set");

        }
    }

    class Vector4
    {
        private int x;
        private int y;
        private int z;
        //该成员只能在类的内部使用
        //private
        //如果需要访问的可以设置get函数，需要修改的设置set函数，以便在外界修改，这样可以约束修改的值（设置范围
        public double Get_Lenght(int x1,int y1,int z1)
        {
            return Math.Sqrt(x*x+y*y+z*z);
        }
        public void Set()
        {
            Console.WriteLine("set");
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            car.Speed=10000000;
            car.MaxSpeed=9999999;
            car.Weight=6;
            car.Run();
            car.Stop();

            Vector3 v1 = new Vector3();
            v1.x=3;
            v1.y=4;
            v1.z=4;
            Console.WriteLine(v1.Get_Lenght(v1.x,v1.y,v1.z));
            v1.Set();

        }
    }

}