using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexToBinary
{
    class HexToBinary
    {
        static void Main()
        {
            string hexValue = "A00";
            StringBuilder decValue = new StringBuilder();
            foreach( char c in hexValue.ToCharArray() )
            {
              decValue.Append( Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2));
            }            
            
            Console.WriteLine(decValue);
        }
    }
}
