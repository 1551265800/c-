using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//将值类型的字段达到引用类型的效果
namespace 引用参数ref
    
{
    internal class Program
    {
        class Person
        {
            public int age = 5;
            public string name;
        }
        class MyClass
        {
            
            public void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
            public void Temp(Person p1, Person p2)
            {
                int temp = p1.age;
                p1.age = p2.age;
                p2.age = temp;
            }
        }
       
        static void Main(string[] args)
        {   MyClass @class = new MyClass();
            int x = 1,y = 2;
            @class.Swap(ref x,ref y);//引用参数
            Console.WriteLine(x);
            Console.WriteLine(y);
            Person p1 = new Person
            {
                age = 5, name = "诗昂"
            };
            Person p2 = new Person
            {
                age = 10,
                name = "诗昂2"
            };//简化的赋初始值操作
            @class.Temp(p1,p2);
            Console.WriteLine(p1.age);
            Console.WriteLine(p2.age);
        }
    }
}
