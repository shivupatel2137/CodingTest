using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChkProc());
            Console.ReadLine();
        }

        static string ChkProc()
        {
            int a, b, c, d, sumA, SumB, CnD;
            a = 50; b = 30; c = 20; d = 15;
            sumA = 130; SumB = 45; CnD = 30;
            Console.WriteLine("Enter no(N) of items required for SKU");
            int id = 0;
            int sum = 0;
            string s = Console.ReadLine();
            bool result = int.TryParse(s, out id);
            if(result == true)
            {
                string[] Ids = new string[id];
                Console.WriteLine("Enter Value for SKU Id: ");
                for (int i = 0; i < id; i++)
                {
                    Ids[i] = Console.ReadLine();
                }
                foreach (string sku in Ids)
                {
                    int val;
                    val = Convert.ToInt32(sku.Substring(0, 1));
                    if (sku.ToUpper().Contains("A"))
                    {
                        if (val >= 3)
                        {
                            int i = val / 3;
                            sum += i * sumA;
                            val -= i * 3;
                        }
                        sum += val * a;
                    }
                    else if (sku.ToUpper().Contains("B"))
                    {
                        if (val >= 2)
                        {
                            int i = val / 2;
                            sum += i * SumB;
                            val -= i * 2;
                        }
                        sum += val * b;
                    }
                    else if (sku.ToUpper().Contains("C"))
                    {
                        if (!Ids.Any(x => x.ToUpper().Contains("D")))
                            sum += val * c;
                    }
                    else if (sku.ToUpper().Contains("D"))
                    {
                        if (Ids.Any(x => x.ToUpper().Contains("C")))
                        {
                            int Cval = Convert.ToInt32(Ids.Where(x => x.ToUpper().Contains("C")).FirstOrDefault().ToString().Substring(0, 1));
                            if (val == Cval)
                            {
                                sum += val * CnD;
                            }
                            else if (val > Cval)
                            {
                                int i = val - Cval;
                                sum += Cval * CnD;
                                val -= i;
                                sum += i * d;
                            }
                            else if (Cval > val)
                            {
                                int i = Cval - val;
                                sum += val * CnD;
                                val -= i;
                                sum += i * c;
                            }
                        }
                        else
                        {
                            sum += val * d;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please Enter numeric value for Number of SKU.");
                ChkProc();
            }
            return "Total : " + sum;
        }
    }
}
