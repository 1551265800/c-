using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性//快捷设置字段的读写权限，可以用到属性，或称 属性访问器
{
    class Person
    {
        //private string name; //设置字段的时候一般设置为私有，要调用私有字段可以使用方法
        //属性的优点：1.控制读写权限 2.属性访问器中可以添加代码
        #region 自己添加的方法
        //public void SetName(string name)
        //{
        //    this.name = name;//要调用私有字段可以使用方法
        //}
        //public string GetName()
        //{
        //    return this.name;
        //}
        #endregion
        #region 属性访问器
        //public string Name
        //{
        //    get { /*Console.WriteLine("名字读取"); */ return name;  }    //若没有get访问器，则被认为是不可读的
        //    set { /*Console.WriteLine("名字写入");*/  name = value; }   //若没有set访问器，则被认为是不可写的
        //}
        //简写
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "诗昂"; //执行get
            Console.WriteLine(person.Name);//执行set
            //person.SetName("诗昂");
            //Console.WriteLine(person.GetName());
            person.Age = 18;
            Console.WriteLine(person.Age);
        }
    }
}
