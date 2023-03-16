 using System;

 namespace day03_weituo
 {
    class Program
    {

        //chengfayunsuan
        static double Multipty(double param1,double param2){
            return param1*param2;
        }

        static double Divide(double param1,double param2){
            return param1/param2;
        }

        //dingyi weituo 委托 不用定义函数体，其余都差不多
        delegate double MyDelegate(double param1, double param2); 

        static void Main(string[] args)
        {
            //ceshi hanshu 
            // Console.WriteLine(Multipty(2,3));
            // Console.WriteLine(Divide(6,3));

            //引用委托 声明变量
            //该变量只有指向一个函数才能使用
            //要求必须返回值类型和参数个数以及参数列表类型完全一致才可以指向
            MyDelegate delegate1;
            delegate1 = Multipty;
            //这样该委托就被赋予了Multipty函数功能
            Console.WriteLine(delegate1(2,3));

            MyDelegate delegate2 = Divide;
            Console.WriteLine(delegate2(6,3));

            //委托类似变量可以修改
            MyDelegate delegate3;
            delegate3 = Multipty;
            delegate3 = Divide;
            Console.WriteLine(delegate3(10,5));

            //如果一个函数的参数也是一个函数的话，可以利用委托来规定函数类型，避免传参错误 

        }
    }
    
 }