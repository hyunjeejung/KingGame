using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Game
{
    class Program
    {    
        static void Main(string[] args)
        {


                //최초 체력 부여 및 매 라운드별 체력 차감하기!!

                int[] hparray =
                {
                50,
                40,
                30,
                20
                };


                int[] nowhparray = new int[hparray.Length];

                for (int i = 1; i < 5; i++)
                {

                    if (i == 1)
                    {
                        for (int w = 0; w < hparray.Length; w++)
                        {
                            int nowhp = hparray[w];
                            nowhparray[w] = nowhp;
                        }
                    }

                    else
                    {
                        for (int w = 0; w < nowhparray.Length; w++)
                        {
                            int nowhp = nowhparray[w];
                            nowhparray[w] = nowhp - 10;
                        }
                    }


                    foreach (var arr in nowhparray)
                    {
                        Console.WriteLine(arr + " 체력 " + i + " 라운드");
                    }

                    Console.WriteLine("");

                }
        }


    }
}







