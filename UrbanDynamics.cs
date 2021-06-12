using System;
using System.Collections;
using System.Linq;

namespace UrbanDynamics
{
    public struct State
    {
        public double EMM;
        public double ELM;
        public double ELJM;
        public double ETM;
        public double EGM;
        public double EM;

        public double NECP;
        public double NECD;

        public double LAJM;
        public double LAUM;
        public double LATM;
        public double LAHM;
        public double LCHCD;
        public double LCR;
        public double LDC;
        public double LDI;
        public double LJ;

        public double HAV;
        public double BAV;
        public double AV;
        public double TC;

        public double L;
        public double U;
        public double P;

        public double LA;
        public double LAM;
        public double LAMP;
        public double LB;
        public double LD;
        public double LLF;
        public double LHR;
        public double LUR;
        public double LTM;
        public double LMM;
        public double LMMP;
        public double LTPG;
        public double LSM;
        public double LUM;

        public double AMM;
        public double AMMP;
        public double LCHP;
        public double UA;
        public double UAMM;
        public double UB;
        public double LTU;
        public double UD;
        public double UDM;
        public double UEM;
        public double UFW;
        public double UH;
        public double UHM;
        public double UHPM;
        public double UHPR;
        public double ULJR;
        public double UJM;
        public double UJP;
        public double UJ;
        public double UM;
        public double UR;
        public double UMM;
        public double UMMP;
        public double UTL;
        public double UTLP;
        public double UHR;
        public double UTP;
        public double UW;

        public double MA;
        public double MD;
        public double MP;
        public double MPB;
        public double MAJM;
        public double MAPM;
        public double MATM;
        public double MAHM;
        public double MAM;
        public double MAMP;
        public double MDM;
        public double MLR;
        public double MLM;
        public double LEM;
        public double MSM;
        public double LDM;

        public double PEM;
        public double PH;
        public double PHA;
        public double PHC;
        public double PHGR;
        public double PHO;
        public double PHAM;
        public double PHLM;
        public double PHPM;
        public double PHTM;
        public double PHEM;
        public double PHGM;
        public double PHM;
        public double PHCP;
        public double PHCD;
        public double PHOM;

        public double WH;
        public double WHA;
        public double WHC;
        public double WHCD;
        public double WHCP;
        public double WHO;
        public double WHGR;
        public double WHAM;
        public double WHLM;
        public double WHUM;
        public double WHTM;
        public double WHEM;
        public double WHGM;
        public double WHM;
        public double WHOM;

        public double SHD;
        public double SHAM;
        public double SHLM;
        public double SHDM;
        public double SHDP;

        public double NE;
        public double NEA;
        public double NEC;
        public double NED;
        public double NEGR;
        public double EDM;
        public double BDM;

        public double DIEM;
        public double DILM;
        public double DIDM;
        public double DIDP;

        public double TCM;
        public double TN;
        public double TAI;
        public double TPCSP;
        public double TPCR;

        public double MB;
        public double MBD;
        public double MHR;
        public double MPR;
        public double MJ;
        public double MR;

        public double DI;
        public double DID;

        public double TR;
        public double TRN;
        public double TRNP;

        public double LR;
        public double LRP;

        public double HUT;
        public double PUT;
        public double LFO;
    }

    public class UrbanDynamics
    {
        #region Constants
        public static double AMF = 1;
        public static double AMMP = 1;
        public static double AMMPT = 20;
        public static double AREA = 100000;
        public static double DI = 100;
        public static double DIAV = 100;
        public static double DICF = 0.3;
        public static double DIDF = 1;
        public static double DIDN = 0.03;
        public static double DIDR = 0;
        public static double DIL = 10;
        public static double DIM = 1;
        public static double EF = 1;
        public static double L = 14000;
        public static double LAF = 1;
        public static double LAMP = 1;
        public static double LAMPT = 15;
        public static double LAN = 0.03;
        public static double LBR = 0.01;
        public static double LCHCL = 0.6;
        public static double LCHPC = 0;
        public static double LDN = 0.02;
        public static double LFS = 6;
        public static double LMF = 1;
        public static double LMMP = 1;
        public static double LMMPT = 15;
        public static double LMN = 0.02;
        public static double LPH = .1;
        public static double LPP = .2;
        public static double LRP = 1;
        public static double LRPT = 5;
        public static double LTR = 0;
        public static double MAF = 1;
        public static double MAMP = 1;
        public static double MAMPT = 10;
        public static double MAN = 0.03;
        public static double MB = 1000;
        public static double MBAV = 300;
        public static double MBCF = 0.5;
        public static double MBDN = 0.05;
        public static double MBL = 15;
        public static double MBM = 2;
        public static double MDN = 0.02;
        public static double MP = 3900;
        public static double MPBR = 0.0075;
        public static double MPFS = 5;
        public static double NE = 200;
        public static double NEAT = 10;
        public static double NEAV = 500;
        public static double NECF = 1;
        public static double NECL = 20;
        public static double NECN = 0.05;
        public static double NECR = 0;
        public static double NEDN = 0.08;
        public static double NEGRI = 0.03;
        public static double NEL = 20;
        public static double NEM = 4;
        public static double PH = 5000;
        public static double PHAT = 10;
        public static double PHAV = 30;
        public static double PHCL = 2;
        public static double PHCN = 0.03;
        public static double PHCR = 0;
        public static double PHF = 1;
        public static double PHGRI = 0.03;
        public static double PHON = 0.03;
        public static double PHPD = 3;
        public static double SHDF = 1;
        public static double SHDN = 0.02;
        public static double SHDR = 0;
        public static double SWT1 = 0;
        public static double SWT2 = 0;
        public static double SWT3 = 0;
        public static double SWT4 = 0;
        public static double SWT5 = 0;
        public static double SWT6 = 0;
        public static double SWT7 = 0;
        public static double SWT8 = 0;
        public static double SWT9 = 0;
        public static double SWT10 = 0;
        public static double TAN = 50;
        public static double TLP = 200;
        public static double TMP = 150;
        public static double TPCN = 250;
        public static double TPCS = 0;
        public static double TRNPT = 30;
        public static double TUP = 300;
        public static double U = 1200;
        public static double UAN = 0.05;
        public static double UBR = 0.015;
        public static double UDN = 0.02;
        public static double UFS = 8;
        public static double UH = 1100;
        public static double UHAV = 5;
        public static double UHPD = 12;
        public static double UJPC = 0;
        public static double UMF = 1;
        public static double UMMP = 1;
        public static double UMMPT = 10;
        public static double UMN = 0.1;
        public static double UTLP = 75;
        public static double UTLPT = 10;
        public static double UTR = 0;
        public static double WH = 21000;
        public static double WHAT = 10;
        public static double WHAV = 15;
        public static double WHCL = 1;
        public static double WHCN = 0.03;
        public static double WHCR = 0;
        public static double WHF = 1;
        public static double WHGRI = 0.03;
        public static double WHON = 0.02;
        public static double WHPD = 6;
        #endregion

        #region Lookup Tables
        // (4.1) Underemployed arrivals mobility multiplier
        public static double[] UAMMT_X = { 0, 0.025, 0.05, 0.075, 0.1, 0.125, 0.15 };
        public static double[] UAMMT_Y = { 0.3, 0.7, 1.0, 1.2, 1.3, 1.4, 1.5 };
        // (5.1) Underemployed housing multiplier
        public static double[] UHMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0 };
        public static double[] UHMT_Y = { 2.5, 2.4, 2.2, 1.7, 1.0, 0.4, 0.2, 0.1, 0.05 };
        // (7.1) Public expenditure multiplier table
        public static double[] PEMT_X = { 0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0 };
        public static double[] PEMT_Y = { 0.2, 0.6, 1.0, 1.6, 2.4, 3.2, 4.0 };
        // (10.1) Underemployed / job multiplier table
        public static double[] UJMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5, 2.75, 3.0 };
        public static double[] UJMT_Y = { 2.0, 2.0, 1.9, 1.6, 1.0, 0.6, 0.4, 0.3, 0.2, 0.15, 0.1, 0.05, 0.02 };
        // (11.1) Underemployed housing program multiplier
        public static double[] UHPMT_X = { 0, 0.01, 0.02, 0.03, 0.04, 0.05 };
        public static double[] UHPMT_Y = { 1.0, 1.2, 1.5, 1.9, 2.4, 3.0 };
        // (14.1) Underemployed departure multiplier
        public static double[] UDMT_X = { -3, -2, -1, 0, 1, 2, 3 };
        public static double[] UDMT_Y = { 8, 4, 2, 1, 0.5, 0.25, 0.125 };
        // (19.1) Underemployed fraction working
        public static double[] UFWT_X = { 0, 1, 2, 3, 4 };
        public static double[] UFWT_Y = { 0.9, 0.8, 0.5, 0.33, 0.25 };
        // (24.1) Labor supply multiplier
        public static double[] LSMT_X = { 0, 0.5, 1.0, 1.5, 2.0 };
        public static double[] LSMT_Y = { 2.4, 2.0, 1.0, 0.4, 0.2 };
        // (25.1) Labor / underemployed multiplier
        public static double[] LUMT_X = { 0, 1, 2, 3, 4, 5 };
        public static double[] LUMT_Y = { 0.2, 0.7, 1.0, 1.2, 1.3, 1.4 };
        // (27.1) Underemployed educational multiplier
        public static double[] UEMT_X = { 0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0 };
        public static double[] UEMT_Y = { 0.2, 0.7, 1.0, 1.3, 1.5, 1.6, 1.7 };
        // (31.1) Labor layoff fraction
        public static double[] LLFT_X = { 0, 0.5, 1.0, 1.5, 2.0 };
        public static double[] LLFT_Y = { 0, 0.01, 0.03, 0.1, 0.3 };
        // (35.1) Manager supply multiplier table
        public static double[] MSMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0 };
        public static double[] MSMT_Y = { 2.3, 2.2, 2.0, 1.6, 1.0, 0.5, 0.2, 0.1, 0.05 };
        // (38.1) Manager / labor ratio multiplier
        public static double[] MLMT_X = { 0, 0.05, 0.1, 0.15, 0.2 };
        public static double[] MLMT_Y = { 0.2, 0.7, 1.0, 1.2, 1.3 };
        // (40.1) Labor educational multiplier table
        public static double[] LEMT_X = { 0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0 };
        public static double[] LEMT_Y = { 0.2, 0.7, 1.0, 1.3, 1.5, 1.6, 1.7 };
        // (44.1) Labor arrival job multiplier
        public static double[] LAJMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0 };
        public static double[] LAJMT_Y = { 2.6, 2.6, 2.4, 1.8, 1.0, 0.4, 0.2, 0.1, 0.05 };
        // (45.1) Labor arrival underemployed multiplier
        public static double[] LAUMT_X = { 0, 1, 2, 3, 4, 5 };
        public static double[] LAUMT_Y = { 0.4, 0.8, 1.0, 1.2, 1.3, 1.3 };
        // (46.1) Labor arrival tax multiplier
        public static double[] LATMT_X = { -2, 0, 2, 4 };
        public static double[] LATMT_Y = { 1.2, 1.0, 0.7, 0.3 };
        // (47.1) Labor arrival housing multiplier
        public static double[] LAHMT_X = { 0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0 };
        public static double[] LAHMT_Y = { 1.3, 1.2, 1.0, 0.5, 0.2, 0.1, 0.05 };
        // (50.1) Labor departure multiplier
        public static double[] LDMT_X = { -3, -2, -1, 0, 1, 2, 3 };
        public static double[] LDMT_Y = { 8, 4, 2, 1, 0.5, 0.25, 0.125 };
        // (56.1) Manager arrival job multiplier
        public static double[] MAJMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0 };
        public static double[] MAJMT_Y = { 2.7, 2.6, 2.4, 2.0, 1.0, 0.4, 0.2, 0.1, 0.05 };
        // (57.1) Manager arrival population multiplier
        public static double[] MAPMT_X = { 0, 0.02, 0.04, 0.06, 0.08, 0.1 };
        public static double[] MAPMT_Y = { 0.3, 0.7, 1.0, 1.2, 1.3, 1.3 };
        // (59.1) Manager arrival tax multiplier
        public static double[] MATMT_X = { -2, 0, 2, 4 };
        public static double[] MATMT_Y = { 1.4, 1.0, 0.7, 0.3 };
        // (60.1) Manager arrival housing multiplier
        public static double[] MAHMT_X = { 0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0 };
        public static double[] MAHMT_Y = { 1.3, 1.2, 1.0, 0.5, 0.2, 0.1, 0.05 };
        // (63.1) Manager departure multiplier
        public static double[] MDMT_X = { -3, -2, -1, 0, 1, 2, 3 };
        public static double[] MDMT_Y = { 8, 4, 2, 1, 0.5, 0.25, 0.125 };
        // (67.1) Premium housing adequacy multiplier
        public static double[] PHAMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0 };
        public static double[] PHAMT_Y = { 0, 0.001, 0.01, 0.2, 1.0, 3.0, 4.6, 5.6, 6.0 };
        // (68.1) Premium housing land multiplier
        public static double[] PHLMT_X = { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0 };
        public static double[] PHLMT_Y = { 0.4, 0.9, 1.3, 1.6, 1.8, 1.9, 1.8, 1.4, 0.7, 0.2, 0.0 };
        // (72.1) Premium housing population multiplier
        public static double[] PHPMT_X = { 0, 0.02, 0.04, 0.06, 0.08, 0.1 };
        public static double[] PHPMT_Y = { 0.3, 0.7, 1.0, 1.2, 1.3, 1.3 };
        // (73.1) Premium housing tax multiplier
        public static double[] PHTMT_X = { -2, 0, 2, 4 };
        public static double[] PHTMT_Y = { 1.2, 1.0, 0.7, 0.3 };
        // (74.1) Premium housing enterprise multiplier
        public static double[] PHEMT_X = { -0.1, -0.05, 0.0, 0.05, 0.1, 0.15 };
        public static double[] PHEMT_Y = { 0.2, 0.6, 1.0, 1.4, 1.8, 2.2 };
        // (75.1) Premium housing enterprise multiplier
        public static double[] PHGMT_X = { -0.1, -0.05, 0.0, 0.05, 0.1, 0.15 };
        public static double[] PHGMT_Y = { 0.2, 0.6, 1.0, 1.4, 1.8, 2.2 };
        // (80.1) Premium housing enterprise multiplier
        public static double[] PHOMT_X = { -3, -2, -1, 0, 1, 2, 3 };
        public static double[] PHOMT_Y = { 2.8, 2.6, 2.0, 1.0, 0.5, 0.3, 0.2 };
        // (85.1) Worker housing adequacy multiplier
        public static double[] WHAMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0 };
        public static double[] WHAMT_Y = { 0, 0.05, 0.1, 0.3, 1.0, 1.8, 2.4, 2.8, 3.0 };
        // (86.1) Worker housing land multiplier
        public static double[] WHLMT_X = { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0 };
        public static double[] WHLMT_Y = { 0.4, 0.9, 1.3, 1.6, 1.8, 1.9, 1.8, 1.4, 0.7, 0.2, 0.0 };
        // (87.1) Worker housing underemployed multiplier
        public static double[] WHUMT_X = { 0, 1, 2, 3, 4, 5 };
        public static double[] WHUMT_Y = { 0.5, 0.8, 1.0, 1.2, 1.3, 1.3 };
        // (88.1) Worker housing tax multiplier
        public static double[] WHTMT_X = { -2, 0, 2, 4 };
        public static double[] WHTMT_Y = { 1.2, 1.0, 0.7, 0.3 };
        // (89.1) Worker housing enterprise multiplier
        public static double[] WHEMT_X = { -0.2, -0.1, 0.0, 0.1, 0.2, 0.3 };
        public static double[] WHEMT_Y = { 0.3, 0.7, 1.0, 1.2, 1.3, 1.4 };
        // (90.1) Worker housing growth multiplier
        public static double[] WHGMT_X = { -0.1, -0.05, 0.0, 0.05, 0.1, 0.15 };
        public static double[] WHGMT_Y = { 0.2, 0.6, 1.0, 1.4, 1.8, 2.2 };
        // (94.1) Worker housing obsolescence multiplier
        public static double[] WHOMT_X = { -3, -2, -1, 0, 1, 2, 3 };
        public static double[] WHOMT_Y = { 2.2, 2.0, 1.6, 1.0, 0.7, 0.5, 0.4 };
        // (97.1) Slum housing abandoned multiplier
        public static double[] SHAMT_X = { 0, 0.5, 1.0, 1.5, 2.0 };
        public static double[] SHAMT_Y = { 3.6, 2.0, 1.0, 0.6, 0.4 };
        // (97.1) Slum housing land multiplier
        public static double[] SHLMT_X = { 0.8, 0.85, 0.9, 0.95, 1.0 };
        public static double[] SHLMT_Y = { 1.0, 1.2, 1.6, 2.2, 6.0 };
        // (104.1) Enterprise manager / job multiplier
        public static double[] EMMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0 };
        public static double[] EMMT_Y = { 0.1, 0.15, 0.3, 0.5, 1.0, 1.4, 1.7, 1.9, 2.0 };
        // (104.1) Enterprise land multiplier
        public static double[] ELMT_X = { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0 };
        public static double[] ELMT_Y = { 1.0, 1.15, 1.3, 1.4, 1.45, 1.4, 1.3, 1.0, 0.7, 0.4, 0 };
        // (106.1) Enterprise labor / job multiplier
        public static double[] ELJMT_X = { 0, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0 };
        public static double[] ELJMT_Y = { 0, 0.05, 0.15, 0.4, 1.0, 1.5, 1.7, 1.8, 1.8 };
        // (107.1) Enterprise tax multiplier
        public static double[] ETMT_X = { -2, -1, 0, 1, 2, 3, 4 };
        public static double[] ETMT_Y = { 1.3, 1.2, 1.0, 0.8, 0.5, 0.25, 0.1 };
        // (108.1) Enterprise growth multiplier
        public static double[] EGMT_X = { -0.1, -0.05, 0.0, 0.05, 0.1, 0.15 };
        public static double[] EGMT_Y = { 0.2, 0.6, 1.0, 1.4, 1.8, 2.2 };
        // (112.1) Enterprise decline multiplier
        public static double[] EDMT_X = { -3, -2, -1, 0, 1, 2, 3 };
        public static double[] EDMT_Y = { 2, 1.8, 1.5, 1.0, 0.7, 0.5, 0.5 };
        // (115.1) Business decline multiplier
        public static double[] BDMT_X = { -3, -2, -1, 0, 1, 2, 3 };
        public static double[] BDMT_Y = { 2, 1.8, 1.5, 1.0, 0.7, 0.5, 0.4 };
        // (119.1) Declining industry enterprise multiplier
        public static double[] DIEMT_X = { -3, -2, -1, 0, 1, 2, 3 };
        public static double[] DIEMT_Y = { 0.4, 0.5, 0.7, 1.0, 1.6, 2.4, 4.0 };
        // (120.1) Declining industry land multiplier
        public static double[] DILMT_X = { 0.8, 0.85, 0.9, 0.95, 1.0 };
        public static double[] DILMT_Y = { 1.0, 1.2, 1.6, 2.2, 6.0 };
        // (122.1) Tax ratio table
        public static double[] TRT_X = { -2, -1, 0, 1, 2, 3, 4 };
        public static double[] TRT_Y = { 0.3, 0.5, 1.0, 1.8, 2.8, 3.6, 4.0 };
        // (127.1) Tax collection multiplier
        public static double[] TCMT_X = { 0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0 };
        public static double[] TCMT_Y = { 2.0, 1.6, 1.3, 1.1, 1.0, 0.9, 0.8 };
        // (135.1) Underemployed / labor job ratio
        public static double[] ULJRT_X = { 0, 0.5, 1.0, 1.5, 2.0 };
        public static double[] ULJRT_Y = { 1.15, 0.8, 0.5, 0.25, 0.1 };
        // (138.1) Labor construction ratio
        public static double[] LCRT_X = { 0, 0.5, 1.0, 1.5, 2.0 };
        public static double[] LCRT_Y = { 0, 0.5, 0.9, 1.1, 1.15 };
        #endregion

        public State Update(double DT, double TIME, State S_J)
        {
            State S_K = new State();

            #region Level Equations
            // (2) Attractiveness for migration multiplier perceived
            S_K.AMMP = S_J.AMMP + (DT / AMMPT) * (S_J.AMM - S_J.AMMP);

            // (42) Labor arrival multiplier perceived
            S_K.LAMP = S_J.LAMP + (DT / LAMPT) * (S_J.LAM - S_J.LAMP);
            // (54) Manager arrival multiplier perceived
            S_K.MAMP = S_J.MAMP + (DT / MAMPT) * (S_J.MAM - S_J.MAMP);

            // (22) Underemployed mobility multiplier perceived
            S_K.UMMP = S_J.UMMP + (DT / UMMPT) * (S_J.UMM - S_J.UMMP);
            // (33) Labor mobility multiplier perceived
            S_K.LMMP = S_J.LMMP + (DT / LMMPT) * (S_J.LMM - S_J.LMMP);

            // (139) Labor / job ratio perceived
            S_K.LRP = S_J.LRP + (DT / LRPT) * (S_J.LR - S_J.LRP);

            // --- POPULATION ---

            // (29) Labor
            S_K.L = S_J.L + DT * (S_J.UTL + S_J.LB - S_J.LTM + S_J.LA - S_J.LD - S_J.LTU);
            // (16) Underemployed
            S_K.U = S_J.U + DT * (S_J.UA + S_J.UB + S_J.LTU - S_J.UD - S_J.UTL);
            // (52) Managerial-professional
            S_K.MP = S_J.MP + DT * (S_J.LTM + S_J.MPB + S_J.MA - S_J.MD);
            // (9) Population
            S_K.P = (S_K.MP * MPFS) + (S_K.L * LFS) + (S_K.U * UFS);

            // --- HOUSING ---

            // (95) Underemployed housing
            S_K.UH = S_J.UH + DT * (S_J.WHO - S_J.SHD + S_J.LCHP);
            // (81) Worker housing
            S_K.WH = S_J.WH + DT * (S_J.PHO + S_J.WHC - S_J.WHO);
            // (92) Worker housing average
            S_K.WHA = S_J.WHA + (DT / WHAT) * (S_J.WH - S_J.WHA);
            // (78) Premium housing
            S_K.PH = S_J.PH + DT * (S_J.PHC - S_J.PHO);
            // (77) Premium housing average
            S_K.PHA = S_J.PHA + (DT / PHAT) * (S_J.PH - S_J.PHA);  

            // --- BUSINESS ---

            // (100) New enterprise level equation
            S_K.NE = S_J.NE + DT * (S_J.NEC - S_J.NED);
            // (110) New enterprise average
            S_K.NEA = S_J.NEA + (DT / NEAT) * (S_J.NE - S_J.NEA);
            // (113) Mature business
            S_K.MB = S_J.MB + DT * (S_J.NED - S_J.MBD);
            // (116) Declining industry
            S_K.DI = S_J.DI + DT * (S_J.MBD - S_J.DID);

            // -- TAXES ---

            // (123) Tax ratio needed perceived
            S_K.TRNP = S_J.TRNP + (DT / TRNPT) * (S_J.TRN - S_J.TRNP);
            
            #endregion

            #region Auxiliary Equations
            // (109) New enterprise growth rate
            S_K.NEGR = (S_K.NE - S_K.NEA) / (S_K.NE * NEAT);
            // (76) Premium housing growth rate
            S_K.PHGR = (S_K.PH - S_K.PHA) / (S_K.PH * PHAT);
            // (70) Housing units total
            S_K.HUT = S_K.PH + S_K.WH + S_K.UH;
            // (71) Productive units total
            S_K.PUT = S_K.NE + S_K.MB + S_K.DI;
            // (69) Land fraction occupied
            S_K.LFO = (S_K.HUT * LPH + S_K.PUT * LPP) / AREA;

            // (122) Tax ratio
            S_K.TR = Table.LookupClamp(TRT_X, TRT_Y, Math.Log(S_K.TRNP, 2.0));

            // (58) Manager population ratio
            S_K.MPR = S_K.MP / (S_K.L + S_K.U);
            // (61) Manager housing ratio
            S_K.MHR = (S_K.MP * MPFS) / (S_K.PH * PHPD);
            // (37) Manager jobs
            S_K.MJ = (S_K.NE * NEM) + (S_K.MB * MBM) + (S_K.DI * DIM);
            // (36) Manager / job ratio
            S_K.MR = S_K.MP / S_K.MJ;

            // (67) Premium housing adequacy multiplier
            S_K.PHAM = Table.Lookup(PHAMT_X, PHAMT_Y, S_K.MHR);
            // (68) Premium housing land multiplier
            S_K.PHLM = Table.LookupClamp(PHLMT_X, PHLMT_Y, S_K.LFO);
            // (72) Premium housing population multiplier
            S_K.PHPM = Table.LookupClamp(PHPMT_X, PHPMT_Y, S_K.MPR);
            // (73) Premium housing tax multiplier
            S_K.PHTM = Table.LookupClamp(PHTMT_X, PHTMT_Y, Math.Log(S_K.TR, 2.0));
            // (74) Premium housing enterprise multiplier
            S_K.PHEM = Table.LookupClamp(PHEMT_X, PHEMT_Y, S_K.NEGR);
            // (75) Premium housing growth multiplier
            S_K.PHGM = Table.LookupClamp(PHGMT_X, PHGMT_Y, S_K.PHGR);
            // (66) Premium housing multiplier
            S_K.PHM = S_K.PHAM * S_K.PHLM * S_K.PHPM * S_K.PHTM * S_K.PHEM * S_K.PHGM * PHF;
            // (142) Premium housing construction program
            S_K.PHCP = PHCR * S_K.PH * S_K.PHLM * CLIP(0, 1, SWT3, TIME);
            // (65) Premium housing construction desired
            S_K.PHCD = (PHCN * S_K.PH * S_K.PHM) + S_K.PHCP;

            // (48) Labor housing / ratio
            S_K.LHR = (S_K.L * LFS) / (S_K.WH * WHPD);
            // (26) Labor / underemployed ratio
            S_K.LUR = S_K.L / S_K.U;

            // (91) Worker housing growth rate
            S_K.WHGR = (S_K.WH - S_K.WHA) / (S_K.WH * WHAT);
            // (85) Worker housing adequacy multiplier
            S_K.WHAM = Table.LookupClamp(WHAMT_X, WHAMT_Y, S_K.LHR);
            // (86) Worker housing land multiplier
            S_K.WHLM = Table.LookupClamp(WHLMT_X, WHLMT_Y, S_K.LFO);
            // (87) Worker housing underemployed multiplier
            S_K.WHUM = Table.LookupClamp(WHUMT_X, WHUMT_Y, S_K.LUR);
            // (88) Worker housing tax multiplier
            S_K.WHTM = Table.LookupClamp(WHTMT_X, WHTMT_Y, Math.Log(S_K.TR, 2.0));
            // (89) Worker housing enterprise multiplier
            S_K.WHEM = Table.LookupClamp(WHEMT_X, WHEMT_Y, S_K.NEGR);
            // (90) Worker housing growth multiplier
            S_K.WHGM = Table.LookupClamp(WHGMT_X, WHGMT_Y, S_K.WHGR);
            // (84) Worker housing multiplier
            S_K.WHM = S_K.WHAM * S_K.WHLM * S_K.WHUM * S_K.WHTM * S_K.WHEM * S_K.WHGM * WHF;
            // (143) Worker housing construction program
            S_K.WHCP = WHCR * S_K.HUT * S_K.WHLM * CLIP(0, 1, SWT4, TIME);
            // (83) Worker housing construction desired
            S_K.WHCD = (WHCN * S_K.WH * S_K.WHM) + S_K.WHCP;
            
            // (104) Enterprise manager / job multiplier
            S_K.EMM = Table.LookupClamp(EMMT_X, EMMT_Y, S_K.MR);
            // (105) Enterprise land multiplier
            S_K.ELM = Table.LookupClamp(ELMT_X, ELMT_Y, S_K.LFO);
            // (106) Enterprise labor / job multiplier
            S_K.ELJM = Table.LookupClamp(ELJMT_X, ELJMT_Y, S_K.LRP);
            // (107) Enterprise tax multiplier
            S_K.ETM = Table.LookupClamp(ETMT_X, ETMT_Y, Math.Log(S_K.TR, 2.0));
            // (108) Enterprise growth multiplier
            S_K.EGM = Table.LookupClamp(EGMT_X, EGMT_Y, S_K.NEGR);
            // (103) Enterprise multiplier
            S_K.EM = S_K.EMM * S_K.ELM * S_K.ELJM * S_K.ETM * S_K.EGM * EF;

            // (145) New-enterprise construction program
            S_K.NECP = NECR * S_K.PUT * S_K.ELM * CLIP(0, 1, SWT6, TIME);
            // (102) New enterprise construction desired
            S_K.NECD = NECN * S_K.EM * (NECF * S_K.NE + MBCF * S_K.MB + DICF * S_K.DI) + S_K.NECP;

            // (150) Low cost housing construction desired
            S_K.LCHCD = LCHPC * S_K.U * S_K.WHLM * CLIP(0, 1, SWT10, TIME);

            // (131) Labor desired for construction
            S_K.LDC =
                S_K.PHCD * PHCL +
                S_K.WHCD * WHCL +
                S_K.NECD * NECL +
                S_K.LCHCD * LCHCL;

            // (132) Labor desired for industry
            S_K.LDI = S_K.NE * NEL + S_K.MB * MBL + S_K.DI * DIL;
            // (133) Total available jobs
            S_K.LJ = S_K.LDC + S_K.LDI;
            // (134) Labor / job ratio
            S_K.LR = S_K.L / S_K.LJ;

            // (44) Labor arrival job multiplier
            S_K.LAJM = Table.Lookup(LAJMT_X, LAJMT_Y, S_K.LR);
            // (45) Labor arrival underemployed multiplier
            S_K.LAUM = Table.LookupClamp(LAUMT_X, LAUMT_Y, S_K.LUR);
            // (46) Labor arrival tax multiplier
            S_K.LATM = Table.Lookup(LATMT_X, LATMT_Y, Math.Log(S_K.TR, 2));
            // (47) Labor arrival housing multiplier
            S_K.LAHM = Table.Lookup(LAHMT_X, LAHMT_Y, S_K.LHR);
            // (43) Labor arrival multiplier
            S_K.LAM = S_K.LAJM * S_K.LAUM * S_K.LATM * S_K.LAHM * LAF;
            // (138) Labor construction ratio
            S_K.LCR = Table.LookupClamp(LCRT_X, LCRT_Y, S_K.LR);
            #endregion

            // --- TAX SECTOR ---

            // (129) Housing assessed value
            S_K.HAV = (PHAV * S_K.PH + WHAV * S_K.WH + UHAV * S_K.UH);
            // (130) Business assessed value
            S_K.BAV = (NEAV * S_K.NE + MBAV * S_K.MB + DIAV * S_K.DI);
            // (128) Assessed value
            S_K.AV = (S_K.HAV + S_K.BAV);
            // (121) Tax collections
            S_K.TC = S_K.AV * TAN * S_K.TR;

            // --- WORKER HOUSING SECTOR ---

            // (94) Worker housing obsolescence multiplier
            S_K.WHOM = Table.LookupClamp(WHOMT_X, WHOMT_Y, Math.Log(S_K.WHM, 2.0));

            // --- JOB SECTOR ---

            // (135) Underemployed labor / job ratio
            S_K.ULJR = Table.LookupClamp(ULJRT_X, ULJRT_Y, S_K.LR);
            // (148) Underemployed job program
            S_K.UJP = UJPC * S_K.U * CLIP(0, 1, SWT9, TIME);
            // (136) Underemployed jobs
            S_K.UJ = S_K.LJ * S_K.ULJR + S_K.UJP;
            // (137) Underemployed job ratio
            S_K.UR = S_K.U / S_K.UJ;

            // --- UNDER-EMPLOYED SECTOR ---

            // (147) Tax per capita subsidy program
            S_K.TPCSP = TPCS * CLIP(0, 1, SWT8, TIME);
            // (8) Tax per capita ratio
            S_K.TPCR = ((S_K.TC / S_K.P) + S_K.TPCSP) / TPCN;
            // (7) Public expenditure multiplier
            S_K.PEM = Table.LookupClamp(PEMT_X, PEMT_Y, S_K.TPCR);

            // (12) Underemployed housing program rate
            S_K.UHPR = S_J.LCHP / S_K.U;
            // (11) Underemployed housing program multiplier
            S_K.UHPM = Table.LookupClamp(UHPMT_X, UHPMT_Y, S_K.UHPR);
            // (10) Underemployed / job multiplier
            S_K.UJM = Table.LookupClamp(UJMT_X, UJMT_Y, S_K.UR);
            // (140) Underemployment training program
            S_K.UTP = UTR * S_K.U * CLIP(0, 1, SWT1, TIME);

            // (19) Underemployed fraction working
            S_K.UFW = Table.LookupClamp(UFWT_X, UFWT_Y, S_K.UR);
            // (18) Underemployed working
            S_K.UW = S_K.U * S_K.UFW;
            // (20) Underemployed to labor perceived
            S_K.UTLP = S_J.UTLP + (DT / UTLPT) * (S_J.UTL - S_J.UTLP);
            // (21) Underemployed mobility
            S_K.UM = S_K.UTLP / S_K.U;

            // (6) Underemployed / housing ratio
            S_K.UHR = (S_K.U * UFS) / (S_K.UH * UHPD);
            // (4) Underemployed arrivals mobility multiplier
            S_K.UAMM = Table.Lookup(UAMMT_X, UAMMT_Y, S_K.UM);
            // (5) Underemployed / housing multiplier
            S_K.UHM = Table.LookupClamp(UHMT_X, UHMT_Y, S_K.UHR);
            // (3) Attractiveness for migration multiplier
            S_K.AMM = S_K.UAMM * S_K.UHM * S_K.PEM * S_K.UJM * S_K.UHPM * AMF;
            // (14) Underemployed departure multiplier
            S_K.UDM = Table.LookupClamp(UDMT_X, UDMT_Y, Math.Log(S_K.AMM, 2.0));

            // --- LABOR SECTOR ---

            // (24) Labor supply multiplier
            S_K.LSM = Table.LookupClamp(LSMT_X, LSMT_Y, S_K.LR);
            // (25) Labor / underemployed multiplier
            S_K.LUM = Table.LookupClamp(LUMT_X, LUMT_Y, S_K.LUR);
            // (27) Underemployed educational multiplier
            S_K.UEM = Table.LookupClamp(UEMT_X, UEMT_Y, S_K.TPCR);
            // (23) Underemployed mobility multiplier
            S_K.UMM = S_K.LSM * S_K.LUM * S_K.UEM * UMF;

            // (31) Labor layoff fractions
            S_K.LLF = Table.Lookup(LLFT_X, LLFT_Y, S_K.LR);
            // (141) Labor training program
            S_K.LTPG = LTR * S_K.L * CLIP(0, 1, SWT2, TIME);

            // (35) Manager supply multiplier
            S_K.MSM = Table.LookupClamp(MSMT_X, MSMT_Y, S_K.MR);
            
            // (39) Manager / labor ratio
            S_K.MLR = S_K.MP / S_K.L;
            // (38) Manager / labor multiplier
            S_K.MLM = Table.LookupClamp(MLMT_X, MLMT_Y, S_K.MLR);
            // (40) Labor educational multiplier
            S_K.LEM = Table.LookupClamp(LEMT_X, LEMT_Y, S_K.TPCR);
            // (34) Labor mobility multiplier
            S_K.LMM = S_K.MSM * S_K.MLM * S_K.LEM * LMF;
            // (50) Labor departure multiplier
            S_K.LDM = Table.LookupClamp(LDMT_X, LDMT_Y, Math.Log(S_K.LAM, 2));

            // --- MANAGERIAL-PROFESSIONAL SECTOR

            // (56) Manager arrival job multiplier
            S_K.MAJM = Table.Lookup(MAJMT_X, MAJMT_Y, S_K.MR);
            // (57) Manager arrival population multiplier
            S_K.MAPM = Table.LookupClamp(MAPMT_X, MAPMT_Y, S_K.MPR);
            // (59) Manager arrival tax multiplier
            S_K.MATM = Table.Lookup(MATMT_X, MATMT_Y, Math.Log(S_K.TR, 2));
            // (60) Manager arrival housing multiplier
            S_K.MAHM = Table.Lookup(MAHMT_X, MAHMT_Y, S_K.MHR);
            // (55) Manager arrival multiplier
            S_K.MAM = S_K.MAJM * S_K.MAPM * S_K.MATM * S_K.MAHM * MAF;
            // (63) Manager departure multiplier
            S_K.MDM = Table.LookupClamp(MDMT_X, MDMT_Y, Math.Log(S_K.MAM, 2));

            // --- PREMIUM HOUSING SECTOR ---

            // (80) Premium housing obsolescence multiplier
            S_K.PHOM = Table.LookupClamp(PHOMT_X, PHOMT_Y, Math.Log(S_K.PHM, 2.0));

            // --- UNDEREMPLOYED HOUSING SECTOR ---

            // (98) Slum housing abandoned multiplier
            S_K.SHAM = Table.Lookup(SHAMT_X, SHAMT_Y, S_K.UHR);
            // (99) Slum housing land multiplier
            S_K.SHLM = Table.LookupClamp(SHLMT_X, SHLMT_Y, S_K.LFO);
            // (97) Slum housing demolition multiplier
            S_K.SHDM = S_K.SHAM * S_K.SHLM * SHDF;
            // (144) Slum housing demolition program
            S_K.SHDP = SHDR * S_K.UH * CLIP(0, 1, SWT5, TIME);

            // --- MATURE BUSINESS SECTOR ---

            // (112) Enterprise decline multiplier
            S_K.EDM = Table.LookupClamp(EDMT_X, EDMT_Y, Math.Log(S_K.EM, 2.0));
            // (115) Business decline multiplier
            S_K.BDM = Table.LookupClamp(BDMT_X, BDMT_Y, Math.Log(S_K.EM, 2.0));

            // --- DECLINING INDUSTRY SECTOR ---

            // (119) Declining industry enterprise multiplier
            S_K.DIEM = Table.Lookup(DIEMT_X, DIEMT_Y, Math.Log(S_K.EM, 2.0));
            // (120) Declining industry land multiplier
            S_K.DILM = Table.LookupClamp(DILMT_X, DILMT_Y, S_K.LFO);
            // (118) Declining industry demolition multiplier
            S_K.DIDM = S_K.DIEM * S_K.DILM * DIDF;
            // (146) Declining industry demolition program
            S_K.DIDP = DIDR * S_K.DI * CLIP(0, 1, SWT7, TIME);

            // --- TAX SECTOR ---

            // (127) Tax collection multiplier
            S_K.TCM = Table.LookupClamp(TCMT_X, TCMT_Y, S_K.LUR);
            // (126) Taxes needed
            S_K.TN = (
                TMP * MPFS * S_K.MP +
                TLP * LFS * S_K.L +
                TUP * UFS * S_K.U) * (S_K.TCM);
            // (125) Tax assessment indicated
            S_K.TAI = S_K.TN / S_K.AV;
            // (124) Tax ratio needed
            S_K.TRN = S_K.TAI / TAN;

            #region Rate Equations
            // (82) Worker housing construction
            S_K.WHC = S_K.WHCD * S_K.LCR;
            // (64) Premium housing construction rate
            S_K.PHC = S_K.PHCD * S_K.LCR;

            // (96) Slum housing demolition rate
            S_K.SHD = (SHDN * S_K.UH * S_K.SHDM) + S_K.SHDP;
            // (93) Worker housing obsolescence
            S_K.WHO = WHON * S_K.WH * S_K.WHOM;
            // (79) Premium housing obsolescence
            S_K.PHO = PHON * S_K.PH * S_K.PHOM;

            // (149) Low cost housing program
            S_K.LCHP = S_K.LCHCD * S_K.LCR;

            // (17) Underemployed to labor
            S_K.UTL = (UMN * S_K.UW * S_K.UMMP) + S_K.UTP;
            // (30) Labor to underemployed
            S_K.LTU = S_K.L * S_K.LLF;
            // (32) Labor to manager
            S_K.LTM = (LMN * S_K.L * S_K.LMMP) + S_K.LTPG;

            // (1) Unemployed arrivals
            S_K.UA = UAN * (S_K.U + S_K.L) * S_K.AMMP;
            // (41) Labor arrivals
            S_K.LA = LAN * S_K.L * S_K.LAMP;
            // (53) Manager arrivals
            S_K.MA = MAN * S_K.MP * S_K.MAMP;

            // (15) Underemployed births
            S_K.UB = S_K.U * UBR;
            // (28) Labor births
            S_K.LB = S_K.L * LBR;
            // (51) Managerial-professional birth rate (births minus deaths)
            S_K.MPB = S_K.MP * MPBR;

            // (13) Underemployed departures
            S_K.UD = UDN * S_K.U * S_K.UDM;
            // (49) Labor departures
            S_K.LD = LDN * S_K.L * S_K.LDM;
            // (62) Manager departures
            S_K.MD = MDN * S_K.MP * S_K.MDM;

            // (101) New enterprise construction
            S_K.NEC = S_K.NECD * S_K.LCR;

            // (111) New enterprise decline
            S_K.NED = NEDN * S_K.NE * S_K.EDM;
            // (114) Mature business decline
            S_K.MBD = MBDN * S_K.MB * S_K.BDM;
            // (117) Declining industry demolition
            S_K.DID = (DIDN * S_K.DI * S_K.DIDM) + S_K.DIDP;
            #endregion

            return S_K;
        }

        /// <summary>
        /// Returns 'a' if 't' is less than 'sw'. Otherwise returns 'b'.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sw"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        double CLIP(double a, double b, double sw, double t)
        {
            return (t < sw ? a : b);
        }
    }
}