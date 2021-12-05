using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    class Person {
        //在类内的字段可以赋初值
        public string name="诗昂";//字段：描述一个类特性的变量
        public int age = 20;
        public char skinColor = 'Y';
       
        public  void Chat() //方法&函数
        {
            Console.WriteLine("我是" + name + "嘿嘿");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();//实例化，对象在new操作后，才被分配内存
           // person.Chat();
            //类类型是引用类型；结构体是值类型，所以结构体不new也能直接用
            person.age = 20;
            Person person2 = person;//1号只是把引用传给了二号，用的还是同一块内存空间
            person2.age = 18;
            Console.WriteLine(person.age);
            //字段的声明与使用
            Console.WriteLine("姓名:{0}，年龄:{1}，肤色:{2}"
                            ,person.name,person.age,person.skinColor);
        }
    }
}
