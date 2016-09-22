using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class LehmerLow_generator
    {
        BigInteger m = (BigInteger)Math.Pow(2, 32);
        BigInteger a = (BigInteger)(Math.Pow(2, 16) + 1);
        int c = 119;

        public int x0 { get; set; }

        public void WriteSequence(int counter)
        {
            using (StreamWriter sw = new StreamWriter("LehmerLow_generator_Sequence.txt", false, System.Text.Encoding.Default))
            {
                BigInteger xi = x0;
                while (counter != 0)
                {
                    xi = ((a* xi + c) % m);
                    sw.Write(xi % 256);
                    sw.Write(",");
                    counter--;
                }
            }
            Console.WriteLine("done!");
        }
    }
}
