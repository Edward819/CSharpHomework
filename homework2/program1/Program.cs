using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class program1
    {
        static void Main(string[] args)//函数的具体实现
        {

            Console.WriteLine("请输入一个整数");
            SuShu(Num());
        }
        static bool isSuShu(int m) 
        {
            if (m == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < m; i++)
                {
                    if (m % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void SuShu(int n) 
        {
            Console.Write("该数字的素数因子为：");
            for (int i = 2; i <= n; i++)
            {
                if (isSuShu(i))
                {
                    if (n % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
        static int Num() 
        {
            while (true)
            {
                try
                {
                    int numS = Convert.ToInt32(Console.ReadLine());
                    return numS;
                }
                catch
                {
                    Console.WriteLine("输入数字非法！请重新输入：");
                }
            }
        }
        
       
    }
}
