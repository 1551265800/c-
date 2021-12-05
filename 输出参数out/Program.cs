using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出参数out //返回多个return结果
{
    class Out
    {
        public  void Cal(int a,int b,out int x,out int y)//out:出口
        {
            x = b;
            y = a;//离开方法前形参必须赋值
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Out mm = new Out();

            mm.Cal(3, 5, out int x, out int y);//实参必须是个变量,前面要加out
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();
            
        }
    }
}
