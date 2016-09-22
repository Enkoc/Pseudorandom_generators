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
    class BBS_generator
    {
        string pStr = "D5BBB96D30086EC484EBA3D7F9CAEB07";
        string qStr = "425D2B9BFDB25B9CF6C416CC6E37B59C1F";

        BigInteger p;
        BigInteger q;
        BigInteger n;
        public int r0 { get; set; }

        public BBS_generator()
        {
            PQNInit();
        }
        public void WriteSequence(int counter)
        {
            BigInteger ri = r0;
            ulong xi = 0;
            using (StreamWriter sw = new StreamWriter("BBS_Sequence.txt", false, System.Text.Encoding.Default))
            {
                while (counter != 0)
                {
                    ulong generetedByte = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        ri = (ri * ri) % n;
                        xi =(ulong)(ri % 2);
                        generetedByte = (generetedByte << 1) | (xi & 0x00000001);
                    }
                    //Console.WriteLine(generetedByte);
                    sw.Write(generetedByte);
                    sw.Write(",");
                    counter--;
                }
            }
            Console.WriteLine("done!");
        }
        void PQNInit()
        {
            pStr = pStr.Reverse();
            qStr = qStr.Reverse();

            for (int i = 0; i < pStr.Length; i++)
            {
                int number = Int32.Parse(pStr[i].ToString(), NumberStyles.HexNumber);
                p += (BigInteger)(number * Math.Pow(16, i));
            }

            for (int i = 0; i < qStr.Length; i++)
            {
                int number = Int32.Parse(qStr[i].ToString(), NumberStyles.HexNumber);
                q += (BigInteger)(number * Math.Pow(16, i));
            }

            n = q * p;
        }
    }
}
