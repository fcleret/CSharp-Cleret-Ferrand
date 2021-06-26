using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intgr = new int[] { 5, 2, 9, 1, 6, 8 };
            foreach (int value in intgr)
            {
                if (value > 2)
                {
                    System.Console.WriteLine($"Value : {value}");
                }
            }

            System.Console.WriteLine("\n---\n");

            intgr.Where(n => n > 2).ToList().ForEach(n => System.Console.WriteLine($"Value : {n}"));

            try
            {
                System.Console.WriteLine(Manager.Instance.GetAllOffres());
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
        }
    }
}
