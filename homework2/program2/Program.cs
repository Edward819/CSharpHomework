using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class program2
    {
        static void Main(string[] args)
        { 
            Console.Write("数组元素个数为：");
            string s = Console.ReadLine();
            int NumCount = Int32.Parse(s);
            int[] Nums = new int[NumCount];
            for (int i = 0; i < NumCount; i++)
            {
                string p = Console.ReadLine();
                Nums[i] = Int32.Parse(p);
            }
            int MaxNum = Nums[0],MinNum = Nums[0];
            double sum = 0;
            for (int j = 0; j < NumCount; j++)
            {
                if (Nums[j] > MaxNum)
                    MaxNum = Nums[j];
                if (Nums[j] < MinNum)
                    MinNum = Nums[j];
                sum = sum + Nums[j];
            }
            double average = sum / NumCount;
            Console.WriteLine("最大值为:" + MaxNum);
            Console.WriteLine("最小值为:" + MinNum);
            Console.WriteLine("平均值为:" + average);
            Console.WriteLine("元素和为:" + sum);
        }
    }
}
