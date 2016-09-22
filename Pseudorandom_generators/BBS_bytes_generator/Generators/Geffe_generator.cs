using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class Geffe_generator
    {
        public ulong L11 { get; set; }
        public ulong L9 { get; set; }
        public ulong L10 { get; set; }

        public void WriteSequence(int counter)
        {
            using (StreamWriter sw = new StreamWriter("Geffe_generator_Sequence.txt", false, System.Text.Encoding.Default))
            {
                while (counter != 0)
                {
                    ulong generetedByte = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        L11 = ((((L11 >> 2) ^ L11) & 0x00000001) << 10) | (L11 >> 1);
                        L9 = ((((L9 >> 4) ^ (L9 >> 3) ^ (L9 >> 1) ^ L9) & 0x00000001) << 8) | (L9 >> 1);
                        L10 = ((((L10 >> 3) ^ L10) & 0x00000001) << 9) | (L10 >> 1);
                        ulong zi = (L10 & L11) ^ (0x00000001 ^ L10) & L9;
                        generetedByte = (generetedByte << 1) | (zi & 0x00000001);
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
