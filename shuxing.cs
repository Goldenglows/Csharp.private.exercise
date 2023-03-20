using System;
using System.Collections.Generic;
using System.Text;

namespace shuxing
{
    class Customer
    {
        private string? name;
        private string? address;
        private int age;
        private string? creatTime;

        // //设置年龄
        // public void setAge(int age){
        //     this.age = age;
        // }

        // //读取年龄
        // public int GetAge(){
        //     return age;
        // }

        //属性
        //定义属性一般都与变量名字类似，当然也可以取其他的名字
        public int Age
        {
            set//内含value参数00000000000000000000000000000
            {
                age = value;
            }

            get
            {
                return age;
            }

        }

        public string? Name
        {
            set{
                name = value;
            }
            get{
                return name;
            }

        }

        //属性可以设置为只读或者只写
        //只读
        //  public string Name
        // {   
        //     get{
        //         return name;
        //     }
        // }

        //只写
        //  public string Name
        // {
        //     set{
        //         name = value;
        //     }
        // }

        //可以类似这样简写
        public string? Address{
            get;set;
        }

        //初始化类里面并没有number字段
        //这样写了以后，系统会自动创建一个private int number;成员
        public int Number{get;set;}

        public void Show(){
            Console.WriteLine("名字" + name);
            Console.WriteLine("地址" + address);
            Console.WriteLine("年龄" + age);
            Console.WriteLine("创建时间" + creatTime);
        }


    }

    class Program
    {
        static void Main(string[] args){
            //设置数值就可以这样设置
            Customer lisi = new Customer();
            //自动会调出属性中的set
            lisi.Age = 34;
            //自动会调出属性中的get
            Console.WriteLine(lisi.Age);

            //匿名类型，会根据后面的赋值确定类型
            var age2 = 45;

            age2 = 910;

            //这样是不可以的
            age2 = "115";

            var name = "ges";

        }
    }
}