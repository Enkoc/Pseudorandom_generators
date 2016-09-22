using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class Cs_generator
    {
        byte[] BytesSequence;
        public void WriteSequence(int counter)
        {
            Random r = new Random();
            BytesSequence = new byte[counter];
            using (StreamWriter sw = new StreamWriter("Cs_generator_Sequence.txt", false, System.Text.Encoding.Default))
            {
                r.NextBytes(BytesSequence);
                foreach (byte b in BytesSequence)
                {
                    //Console.WriteLine(b);
                    sw.Write(b);
                    sw.Write(",");
                }
            }
            Console.WriteLine("done!");
        }
    }
}
