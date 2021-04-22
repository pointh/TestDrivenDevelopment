using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public class Delitelnost
    {
        public static string VypisDelitele(int n)
        {
            string s = string.Empty;

            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    s += i.ToString();
            }

            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
