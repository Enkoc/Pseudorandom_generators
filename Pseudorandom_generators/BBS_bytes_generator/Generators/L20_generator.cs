using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class L20_generator
    {
        public ulong Seed {get; set;}

        public void WriteSequence(int counter)
        {
            using (StreamWriter sw = new StreamWriter("L20_generator_Sequence.txt", false, System.Text.Encoding.Default))
            {
                while (counter != 0)
                {
                    ulong generetedByte = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        Seed = ((((Seed >> 17) ^ (Seed >> 15) ^ (Seed >> 11) ^ Seed) & 0x00000001) << 19) | (Seed >> 1);
                        generetedByte = (generetedByte << 1) | (Seed & 0x00000001);
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
