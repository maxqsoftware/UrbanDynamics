using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanDynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            double DT = 1;
            double N = 250;
            UrbanDynamics sim = new UrbanDynamics();

            double HAV0 = (
                UrbanDynamics.PHAV * UrbanDynamics.PH +
                UrbanDynamics.WHAV * UrbanDynamics.WH +
                UrbanDynamics.UHAV * UrbanDynamics.UH);
            double BAV0 = (
                UrbanDynamics.NEAV * UrbanDynamics.NE + 
                UrbanDynamics.MBAV * UrbanDynamics.MB + 
                UrbanDynamics.DIAV * UrbanDynamics.DI);
            double AV0 = (HAV0 + BAV0);

            double LUR0 = UrbanDynamics.L / UrbanDynamics.U;
            double TCM0 = UrbanDynamics.TABHL(UrbanDynamics.TCMT_X, UrbanDynamics.TCMT_Y, LUR0);
            double TN0 = (
                UrbanDynamics.TMP * UrbanDynamics.MPFS * UrbanDynamics.MP +
                UrbanDynamics.TLP * UrbanDynamics.LFS * UrbanDynamics.L +
                UrbanDynamics.TUP * UrbanDynamics.UFS * UrbanDynamics.U) * TCM0;
            double TAI0 = TN0 / AV0;
            double TRN0 = TAI0 / UrbanDynamics.TAN;

            SimState S_K;
            SimState S_J = new SimState
            {
                AMMP = UrbanDynamics.AMMP,
                DI = UrbanDynamics.DI,
                L = UrbanDynamics.L,
                LAMP = UrbanDynamics.LAMP,
                LMMP = UrbanDynamics.LMMP,
                LRP = UrbanDynamics.LRP,
                MAMP = UrbanDynamics.MAMP,
                MB = UrbanDynamics.MB,
                MP = UrbanDynamics.MP,
                NE = UrbanDynamics.NE,
                NEA = UrbanDynamics.NE - (UrbanDynamics.NEGRI * UrbanDynamics.NEAT * UrbanDynamics.NE),
                NEGR = UrbanDynamics.NEGRI,
                PH = UrbanDynamics.PH,
                PHA = UrbanDynamics.PH - (UrbanDynamics.PHGRI * UrbanDynamics.PHAT * UrbanDynamics.PH),
                PHGR = UrbanDynamics.PHGRI,
                TRNP = TRN0,
                U = UrbanDynamics.U,
                UH = UrbanDynamics.UH,
                UMMP = UrbanDynamics.UMMP,
                UTLP = UrbanDynamics.UTLP,
                WH = UrbanDynamics.WH,
                WHA = UrbanDynamics.WH - (UrbanDynamics.WHGRI * UrbanDynamics.WHAT * UrbanDynamics.WH),
                WHGR = UrbanDynamics.WHGRI
            };

            S_J = sim.Update(0, 0, S_J);
            Console.WriteLine($"0,{S_J.U},{S_J.L},{S_J.MP},{S_J.UH},{S_J.WH},{S_J.PH},{S_J.NE},{S_J.MB},{S_J.DI}");
            for (int k = 1; k <= N; k++)
            {
                double TIME_K = DT * k;
                S_K = sim.Update(DT, TIME_K, S_J);
                S_J = S_K;
                Console.WriteLine($"{k},{S_J.U},{S_J.L},{S_J.MP},{S_J.UH},{S_J.WH},{S_J.PH},{S_J.NE},{S_J.MB},{S_J.DI}");
            }

            Console.ReadKey();
        }
    }
}
