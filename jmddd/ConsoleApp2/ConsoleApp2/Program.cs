using ConsoleApp2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{

    public class Opertion
    {
       public int s;
        public virtual int Add()
        {
            int a, b;
            Random rd = new Random();
            a = rd.Next(1, 101);
            b = rd.Next(1, 101);
            s = a + b;
            Console.Write("(" + a + "+" + b + ")");
            
            return s;
        }
        public virtual int Sub()
        {

            int a,b,t;
            Random rd = new Random();
            a = rd.Next(1, 101);
            b = rd.Next(1, 101);
            if (b > a)
            {
                t = a;
                a = b;
                b = a;
            }
            s = a - b;
            Console.Write("(" + a + "-" + b + ")");          
            return s;
        }
        public virtual int Mul()
        {
            int a, b;
            Random rd = new Random();
            a = rd.Next(1, 101);
            b = rd.Next(1, 101);
            s = a * b;
            Console.Write(a + "*" + b);
            return s;
        }
        public virtual int Div()
        {
            float a, b;
            Random rd = new Random();
            a = rd.Next(1, 101);
            b = rd.Next(1, 101);
            if(a%b!=0)
            {
               float r = a % b;
                a = a+ b - r;
            }          
            s = (int)(a / b);
            Console.Write(a + "/" + b);
            return s;
        }
       public void Add(Opertion op)
        {
            int a, b,t;
            Random rd = new Random();
         
            b = rd.Next(1, 101);
            a = s;
            t = a + b;
            Console.WriteLine("+" + b  + "=" + t);
        }
        public void Sub(Opertion op)
        {
            int a, b,t;
            Random rd = new Random();
            b = rd.Next(1, 101);
            a = s;
            while(a!=0 && b > a)
            {
                b = rd.Next(1,51);
            }
            if (a==0)
            {
                t = a + b;
                Console.WriteLine("+"+b+"="+t);
            }
            else 
            {
                t = a - b;
                Console.WriteLine("-" + b + "=" + t);

            }
           
        }
        public void Mul(Opertion op)
        {
            int a, b,t;
            Random rd = new Random();

            b = rd.Next(1, 101);
            a = s;
            t = a* b;
            Console.WriteLine("*" + b  + "=" + t);
        }
        public void Div(Opertion op)
        {
            float a, b,t;
            Random rd = new Random();

            b = rd.Next(1, 101);
            a = s;
            while(a % b != 0)
            {
                b = rd.Next(1, 101);
            }
            t = (int)(a / b);
            Console.WriteLine( "/" + b + "=" + t);
        }
    }
       
    }
    //为第一个式子随机产生单一的四则运算
    public class Fuhao
        {
            public void Fh(Opertion o1)

            {
                Random ro = new Random();
            
            switch (ro.Next(1, 5).ToString())
                {
                    case "1":
                        o1.Add();
                        break;
                    case "2":
                        o1.Sub();
                        break;
                    case "3":
                        o1.Mul();
                        break;
                    case "4":
                        o1.Div();
                        break;
                }
            }
        }
//继承第二个类，产生第二个符号
public class Fuhao2 : Fuhao
{
    public new void Fh(Opertion o1)
    {
        Random ro = new Random();
        switch (ro.Next(1, 5).ToString())
        {
            case "1":
                o1.Add(o1);
                break;
            case "2":
                o1.Sub(o1);
                break;
            case "3":
                o1.Mul(o1);
                break;
            case "4":
                o1.Div(o1);
                break;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fuhao f1 = new Fuhao();
            Fuhao2 f2 = new Fuhao2();
            Opertion o1 = new Opertion();
            Console.Write("输入要产生算式的数目: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                //产生了一个式子的运算
                f1.Fh(o1);
                //产生的第二个式子
                f2.Fh(o1);
            }
            Console.WriteLine("完成！");

        }
    }
}
   

