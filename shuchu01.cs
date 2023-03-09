using System;//引入命名空间System

namespace _001_//命名空间的名字 数字不能开头，一般不使用中文
//定义命名空间，对写的代码进行分类，需要使用命名空间的代码，就需要using引用
{
    class Program
    //命名空间下创建一个类，类的名字为Program 一般和文件名字保持一致
    //命名空间一般和项目名保持一致  
    //类 包含程序使用的数据和方法声明
    //类 一般包含多个方法，方法定义了类的行为，本文类只有一个方法
    {
        static void Main(string[] args)
        //创建一个Main方法,在方法下面有代码
        //方法通过方法体中的语句指定它的行为
        {
            Console.WriteLine("hello World!");
            // Console 就是System命名空间下的类
            // WriteLine 是Console 类下的方法


            //输出是有两个方法：Write 和WriteLine
            Console.Write("Hello Nian");
            //Write 书写是不换行的
            //WriteLine 是换行的
            // Console.Write("Suainian");
            //两个write中的内容会连接在一起，不会另外换行


        }
    }

}