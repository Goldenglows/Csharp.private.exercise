using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230327{
    class Program{
        static void Main(string[] args){
            //使用BCL中的List线性表
            List<string>strList = new List<string>();
            //0号
            strList.Add("123");
            //1号
            strList.Add("456");
            //2号
            strList.Add("789");
            Console.WriteLine(strList[1]);//通过索引器访问一号元素
            //Remove方法进行元素的删除
            strList.Remove("789");
            //读取列表长度
            Console.WriteLine(strList.Count);
            //清空列表
            strList.Clear();

            Console.ReadKey();
        }
    }

}
