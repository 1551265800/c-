using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象_cf实例_
{
    enum Weapon
    {
        knife,//小刀
        rifle,//步枪
        machineGun,//机枪
        sniperRifle//狙击枪
    }
    class Player
    {
        public string name = "斯沃特";
        public string gende = "男";
        public float hp = 100;
        public Weapon weapon = (Weapon)0;
        public Player(string name,string gende,float hp, Weapon weapon)
        {
            
            this.name =  name;
            this.gende = gende;
            this.hp = hp;
            this.weapon = weapon;
        }
        public void Introduce()
        {
            Console.WriteLine($"我是：{name},\n性别：{gende},\n我现在拿着：{weapon},\n血量为：{hp}\n");
        }
        public float attck(Weapon weapon ,float hp, string name)
        {   //选择武器
            Console.WriteLine($"请选择{name}要换的武器0.小刀1.步枪2.机枪3.狙击枪");
            string choose = Console.ReadLine();
            weapon = (Weapon)Convert.ToInt32(choose);
            Console.WriteLine($"现在{name}拿着{weapon}");
            Random rand = new Random();
            rand.Next(0, 10);
            //攻击
            Console.WriteLine($"并向对方发动了一次攻击");
            switch (weapon)
            {
            
                case Weapon.knife:
                    if (rand.Next(0, 15) > 2)
                    {
                        hp -= 10;
                        Console.WriteLine($"命中！对方还剩{hp}点血");
                    }
                    else Console.WriteLine("没有命中");
                   
                    break;
                case Weapon.rifle:
                    if (rand.Next(0, 15) > 4)
                    {
                        hp -= 20;
                        Console.WriteLine($"命中！对方还剩{hp}点血");
                    }
                    else Console.WriteLine("没有命中");
                   
                    break;
                case Weapon.machineGun:
                    if (rand.Next(0, 15) > 6)
                    {
                        hp -= 30;
                        Console.WriteLine($"命中！对方还剩{hp}点血");
                    }
                    else Console.WriteLine("没有命中");
                    break;
                case Weapon.sniperRifle:
                    if (rand.Next(0, 15) > 10)
                    {
                        hp -= 40;
                        Console.WriteLine($"命中！对方还剩{hp}点血");
                    }
                    else Console.WriteLine("没有命中");
                    break;
                default:
                    break;
            }
           return hp;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Player swart = new Player("斯沃特","男",100,Weapon.knife);
            Player mo = new Player("奥摩", "男", 100, Weapon.knife); 
            swart.Introduce();
            mo.Introduce();

            Random rand = new Random();
            int i = rand.Next(0, 10);
            //打架
            while (true)  {
               
                mo.hp = swart.attck(swart.weapon,mo.hp,swart.name);
                if (mo.hp <= 0) break;
                swart.hp = mo.attck(mo.weapon,swart.hp,mo.name);
                if (swart.hp <= 0) break;
            }
            if (mo.hp > 0) Console.WriteLine($"{mo.name}win");
            else Console.WriteLine($"{swart.name}win");
            Console.ReadLine();
        }
    }
}
