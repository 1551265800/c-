using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //0.0100-0.0300
            int i = 0;
            while ( i++ <10)
            {
                int ranNum = random.Next(100, 301);
                float realNum = ranNum / 10000f;
                Console.WriteLine("0.0100-0.0300内的随机数:"+realNum);

            }
           
        }
    }
}
