using System;
using System.Threading;

namespace duoxiancheng
{
    class Program
    {
        static void Main(string[] args)
        {
            //线程
            Thread t =  Thread.CurrentThread;
            //返回线程类，CT 为当前线程
            t.Name="MainThread";
            //.Name 可以为线程命名
            //用于多线程的运行，方便一点
            Console.WriteLine(t.Name);

            //多线程，可以提高程序运行的效率3

            // //线程执行什么方法,委托
            // ThreadStart start = new ThreadStart(ChildThreadMethod);
            // //新建线程
            // Thread childThread = new Thread(start);

            //两步可以合成为一步
            Thread childThread = new Thread(new ThreadStart(ChildThreadMethod));

            //运行线程
            childThread.Start();

            Console.WriteLine("main");
            //多次运行，会发现运行的时候有的时候先执行main 有的时候执行child
            //本质上是两个线程，先后顺序不确定

            //可以写一个死循环，来放大观察两个线程的交替进行
            while(true)
            {
                Console.WriteLine("liaotianzhong ");
                Thread.Sleep(1);

                //此时表示1s = 1000ms  1ms
                //就是每次运行一次这个线程就要休息1ms

            }

            //宏观上是同时在执行

            //表示终止该线程
            childThread.Abort();

            //另一种终止 的方法
            isRun = false;

        }

        private static bool isRun = true
        //创建新的线程
        //创建新的方法
        private static void ChildThreadMethod()
        {
            while(isRun)
            {
            //作为展示，此线程正在运行
            Console.WriteLine ("Child Thread running!");
            }
        }
    }
}