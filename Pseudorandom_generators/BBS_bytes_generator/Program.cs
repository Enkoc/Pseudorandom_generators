using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class Program
    {
        static void Main(string[] args)
        {
            Cs_generator cs = new Cs_generator();
            cs.WriteSequence(1000000);

            LehmerLow_generator lehmerLow = new LehmerLow_generator();
            lehmerLow.x0 = 1;
            lehmerLow.WriteSequence(1000000);

            LehmerHigh_generator lehmerHigh = new LehmerHigh_generator();
            lehmerHigh.x0 = 1;
            lehmerHigh.WriteSequence(1000000);

            L20_generator l20 = new L20_generator();
            l20.Seed = 1;
            l20.WriteSequence(1000000);

            L89_generator l89 = new L89_generator();
            l89.Seed = 1;
            l89.WriteSequence(1000000);

            Geffe_generator geffe = new Geffe_generator();
            geffe.L9 = 1;
            geffe.L10 = 1;
            geffe.L11 = 1;
            geffe.WriteSequence(1000000);

            Librarian_generator librarian = new Librarian_generator();
            librarian.WriteSequence(1000000);

            Wolfram_generator wolfram = new Wolfram_generator();
            wolfram.r0 = 1;
            wolfram.WriteSequence(1000000);

            BM_generator bm = new BM_generator();
            bm.T0 = 1;
            bm.WriteSequence(1000000);

            BM_bytes_generator bm_bytes = new BM_bytes_generator();
            bm_bytes.T0 = 1;
            bm_bytes.WriteSequence(1000000);

            BBS_generator bbs = new BBS_generator();
            bbs.r0 = 2;
            bbs.WriteSequence(1000000);

            BBS_Byte_generator bbs_bytes = new BBS_Byte_generator();
            bbs_bytes.r0 = 2;
            bbs_bytes.WriteSequence(1000000);

            Console.ReadKey();
        }
    }
}
