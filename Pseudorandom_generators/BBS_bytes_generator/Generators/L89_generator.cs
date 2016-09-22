using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class L89_generator
    {
        public BigInteger Seed { get; set; }

        public void WriteSequence(int counter)
        {
            using (StreamWriter sw = new StreamWriter("L89_generator_Sequence.txt", false, System.Text.Encoding.Default))
            {
                while (counter != 0)
                {
                    BigInteger generetedByte = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        Seed = ((((Seed >> 51) ^ Seed) & 0x00000001) << 89) | (Seed >> 1);
                        generetedByte =((generetedByte << 1) |(Seed & 0x00000001));
                    }
                    //Console.WriteLine(generetedByte);
                    sw.Write(generetedByte);
                    sw.Write(",");
                    counter--;
                }
            }
            Console.WriteLine("done!");
        }
    }
}
