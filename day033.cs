using System;
using System.Collections.Generic;
using System.Text;

namespace day03day
{
    public class day03
    {
        //构造函数
        //基本类型的默认值为 0 ：值类型的默认值为0 引用类型的默认值为NULL
        //必须与类名一致，且没有返回值
        //用作给类中的数据进行初始化
        public string? name;
        public int age;
        public string? adress;
        public int number;
        // public day03(string arg1,int arg2,string arg3,int arg4){
        //     //构造函数
        //     //每个类都有构造函数，若自己没有写，则系统会给你默认添加一个无参的构造函数
        //     //调用 day03 dayday = new day03（）；时，系统会自动调用构造函数
        //     // Console.WriteLine("我是day03");
        //     // name = arg1;
        //     // age = arg2;
        //     // adress = arg3;
        //     // number = arg4;

        // }
        //这样赋值，如果代码多的话，看不出来哪个参数到底是什么
        //所以我们要用this来赋值
        public day03(string name,int age,string adress,int number){
            //这样会导致参数和上面的类名重复
            this.name = name;
            this.age = age;
            this.adress = adress;
            this.number = number;

        }


        //可以有多个构造函数


    }

    class Program
    {
        static void Main(string[] args)
        {
            day03 d1 = new day03("1",1,"1",1);
            //有了构造函数就要这样赋值+

            //可以有多个构造函数，后面的括号填什么系统会自动匹配
            //但是写了构造函数，系统就不会自动给你构造函数了

        }
    }
}