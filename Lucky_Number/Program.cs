using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2,2,3,3,3,4};
            getLuckyNumber(array);
            Console.ReadLine();
        }

        public static void getLuckyNumber(int[] array)
        {
            int i,j;
            int LuckyNumber = -1;
  
            for ( i = 0; i < array.Length; i++)
            {
                int count = 1;
                int nextouterindex = 0;
                for(j=i+1; j<array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                    else
                    {
                        if (count > 1)
                        {
                            nextouterindex = j - 1; break;
                        }
                    }

                }

                if (array[i]==count)
                {
                   
                    LuckyNumber = array[i];
                    if (LuckyNumber > array[i])
                    {
                        LuckyNumber = array[i];
                    }
                  
                }
                if (nextouterindex > 0)
                {
                    i = nextouterindex;
                }

            }
            Console.WriteLine(LuckyNumber+ " is lucky number");
        }
    }
}
