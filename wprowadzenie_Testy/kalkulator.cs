using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testyJednostkowe
{
    public class kalkulator
    {

        public static int suma(int x, int y)
        {
            return x + y;
        }

        public static int nwd(int a, int b) 
        {
            int r = 0;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static bool czyPierwsza(int x)
        {
            
            return true;
        }
    }

}
