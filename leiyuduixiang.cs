using System;
using System.Collections.Generic;
using System.Text;

namespace lei
{
    //类的名字大多都与文件名字一致
    //大多一个文件存一个类

    //设计一个顾客类
    class Customer
    {
        public string? name;
        public string? address;
        public int age;
        public string? createTime;

        public void Show()
        {
            Console.WriteLine("名字："+name);
            Console.WriteLine("地址："+address);
            Console.WriteLine("年龄："+age);
            Console.WriteLine("入会日期："+createTime);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //用类创建对象  c1 是对象名
            Customer c1 = new Customer();
            // //声明了一个对象
            // Customer c2;
            // //仅仅声明是不行的，要进行实例化（对对象进行赋值）
            // c2 = new Customer();
            c1.name = "年";
            c1.address = "炎";
            c1.age =3000;
            c1.createTime = "2023年";

            c1.Show();
        }
    }



}


        //面向对象编程
        //类+对象
        //类 创建对象的模板
        //类中的数据和函数称为类的成员
        //数据成员 类的数据-字段  常量和事件的成员
        //函数成员 操作类中数据的功能
