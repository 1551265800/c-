using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{   
    /// <summary>
/// 发量
/// </summary>
    enum HairCount
    {
        dense,//浓密
        sparse,//稀疏
        秃头,//秃头
    }
    enum ProgrammerLevel
    {
        primary,//初级
        intermediate,//中级
        高级//高级
    }
    /// <summary>
    /// 秃头程序员
    /// </summary>
    //帮助注释 三个/  类，方法，字段，属性可以添加帮助注释
    // 优点：在使用类，方法，字段，属性时提示帮助注释的内容
    class Programmer
    {
        private string[] underbrag = {"钱多","话少","头发少","有程序员鼓励师" };
        public string name = "诗昂";
        public int age = 20;
        /// <summary>
        /// 程序员的发量
        /// </summary>
        public HairCount hairCount;
        /// <summary>
        /// 自我介绍
        /// </summary>
        public void Introduce()
        {   
            Console.WriteLine($"我是：{name}，今年{age}岁，我是{hairCount}");
        }

        public ProgrammerLevel returnProgrammerLevel()
        {
            ProgrammerLevel level = ProgrammerLevel.primary;
            switch (hairCount)
            {
                case HairCount.dense:
                    level = ProgrammerLevel.primary;
                    break;
                case HairCount.sparse:
                    level = ProgrammerLevel.intermediate;
                    break;
                case HairCount.秃头:
                    level = ProgrammerLevel.高级;
                    break;
                default:
                    break;
            }return level;
        }
        /// <summary>
        /// 随机自黑
        /// </summary>
        /// <returns></returns>
        public string RondomUnderbrag()
        {   //随机数
            Random random = new Random();

            int i = random.Next(0,underbrag.Length);//随机一个从0到数组最大长度的值，左闭右开
            string words = underbrag[i];
            return words;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer xiaoming = new Programmer();
            xiaoming.hairCount = HairCount.秃头;
            xiaoming.Introduce();//方法用大驼峰，字段用小驼峰
            Console.WriteLine($"等级是{xiaoming.returnProgrammerLevel()}，我{xiaoming.RondomUnderbrag()}");

        }
    }
}
