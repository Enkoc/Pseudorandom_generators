using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class BM_bytes_generator
    {
        public BigInteger T0 { get; set; }

        string pStr = "CEA42B987C44FA642D80AD9F51F10457690DEF10C83D0BC1BCEE12FC3B6093E3";
        string aStr = "5B88C41246790891C095E2878880342E88C79974303BD0400B090FE38A688356";

        BigInteger p;
        BigInteger a;

        public void WriteSequence(int counter)
        {
            BigInteger Ti = T0;
            int xi = 0;
            using (StreamWriter sw = new StreamWriter("BM_Sequence_bytes.txt", false, System.Text.Encoding.Default))
            {
                while (counter != 0)
                {
                    Ti = BigInteger.ModPow(a, Ti, p);

                    for (int k=0; k<256; k++)
                    {
                        if(((k * (p - 1) / 256) < Ti) && (((k + 1) * (p - 1) / 256) >= Ti))
                        {
                            xi = k;
                            break;
                        }
                    }
                    sw.Write(xi);
                    sw.Write(",");
                    counter--;
                }
            }
            Console.WriteLine("done!");
        }
        public BM_bytes_generator()
        {
            PAInit();
        }
        void PAInit()
        {
            pStr = pStr.Reverse();
            aStr = aStr.Reverse();

            for (int i = 0; i < pStr.Length; i++)
            {
                int number = Int32.Parse(pStr[i].ToString(), NumberStyles.HexNumber);
                p += (BigInteger)(number * Math.Pow(16, i));
            }

            for (int i = 0; i < aStr.Length; i++)
            {
                int number = Int32.Parse(aStr[i].ToString(), NumberStyles.HexNumber);
                a += (BigInteger)(number * Math.Pow(16, i));
            }
        }
    }
}

