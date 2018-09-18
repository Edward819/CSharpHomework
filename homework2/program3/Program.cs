using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class program3
    {
         static void Main(string[] args)
         {
             Console.Write("100以内的素数有：");
             int[] numA = new int[99];
             for (int i = 2; i <= 100; i++)
             {
                 numA[i - 2] = i;
             }
             int p = 0;
             for (int j = 2; j < 100; j++)
             {
                 for (int k = 2; k < 100; k++)
                 {
                     p = j * k;
                     if (p <= 100)
                     {
                         numA[p - 2] = 0;
                         continue;
                     }
              
                 }   
             }
             for (int n = 0; n < numA.Length; n++)
             {
                 if (numA[n] != 0)
                 {
                     Console.Write(" " + numA[n]);
                 }
              
             }
        }
    }
}
