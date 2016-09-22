using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class Wolfram_generator
    {
        public ulong r0 { get; set; }
        public void WriteSequence(int counter)
        {
            ulong ri = r0;
            ulong xi= 0;
            using (StreamWriter sw = new StreamWriter("Wolfram_generator_Sequence.txt", false, System.Text.Encoding.Default))
            {
                while (counter != 0)
                {
                    ulong generetedByte = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        // цикл зсув
                        ri = (((ri << 1) + (ri >> 31) & uint.MaxValue) ^ (ri | ((ri >> 1) + (ri << 31) & uint.MaxValue)));
                        xi = ri % 2;
                        generetedByte =((generetedByte << 1) + xi);
                    }
                    sw.Write(generetedByte);
                    sw.Write(",");
                    counter--;
                    //Console.WriteLine(generetedByte);
                }
            }
            Console.WriteLine("done!");
        }
    }
}
