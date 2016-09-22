using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class Librarian_generator
    {
        string text;

        public Librarian_generator()
        {
            ReadText();
        }
        void ReadText()
        {
            using (StreamReader sr = new StreamReader("Text.txt", System.Text.Encoding.Default))
            {
                text = sr.ReadToEnd();
            }
        }
        public void WriteSequence(int counter)
        {
            Encoding enc = Encoding.Default;
            byte[] bytes = enc.GetBytes(text);
            using (StreamWriter sw = new StreamWriter("Librarian_generator.txt", false, System.Text.Encoding.Default))
            {
                for(int i=0; i<counter; i++)
                {
                    //Console.WriteLine(bytes[i]);
                    sw.Write(bytes[i]);
                    sw.Write(",");
                }

            }
            Console.WriteLine("done!");
        }
    }
}
