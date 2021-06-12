public class UrbanDynamics
{
#region Underemployed Sector
    // Eq (1)
    // Rate equation describing the arrival of underemployed into the area
    // Underemployed are the potential wage earners
    float UA()
    {
        // UA.KL = (U.K + L.K)(UAN)(AMMP.K)
    }

    // Eq (2)
    // Level equation describing the perception of by the outside undermployed
    // of the attractiveness of the particular urban area. This is a time delay
    // of the true attractiveness
    float AMMP()
    {
        // AMMP.K = AMMP.J + (DT/AMMPT)(AMM.J-AMMP.J)
    }

    // Eq (3)
    // Level equation describing the true value of attractiveness by the outside
    // undermployed to a particular urban area. 
    float AMMP()
    {
        // AMMP.K = (UAMM.K)(UHM.K)(PEM.K)(UJM.K)(UHPM.K)(AMF)
    }

    // Eq (4)
    // Equation describing the effect of upward economic mobility on
    // attractiveness of the area to underemployed individuals
    float UAMM()
    {
        // UAMM.K = TABLE(UAMMT,UM.K,0,0.15,0.25)
        // UAMMT = [(0,0.3),(0.025,0.7),(0.05,1.0),(0.075,1.2),(0.01,1.3),(0.0125,1.4),(0.015,1.5)]
    }

    // Eq (5)
    // Equation describing the the effect of the ratio of undermployed to
    // available housing on attractiveness of an area to underemployed individuals.
    // Normal ratio (neither repulsion nor attraction) is 1.0
    float UHM()
    {
        // UHM.K = TABHL(UHMT,UHR.K,0,2,0.25)
        // UHMT = [(0,2.5),(.25,2.4),(.5,2.2),(.75,1.7),(1.0,1),(1.25,.4),(1.5,.2),(1.75,.1),(2.0,0.05)]
    }

    // Eq (6)
    // Equation defining the underemployed housing ratio. It is the ratio of
    // underemployed population to the total number of people that could normally
    // be housed in the existing underemployed housing.
    float UHR()
    {
        // UHR.K = (U.K*UFS)/(UH.K*UHP0)
    }

    // Eq (7)
    // Equation describing impact of per capita public expenditure on the
    // attractiveness to underemployed individuals.
    float PEM()
    {
        // PEM.K = TABHL(PEMT,TPCR.K,0,3,0.5)
    }

    // Eq (8)
    // Computes the tax per capita ratio
    float TPCR()
    {
        // TPCR.K = ((TC.K / P.K) + TPCSP.K) / TPCN
    }

    // Eq (9)
    // Computes the total population
    float P()
    {
        // P.K = (MP.K)(MPFS) + (L.K)(LFS) + (U.K)(UFS)
    }

    // Eq (10)
    // Equation describing impact of underemployed / job ratio on the
    // attractiveness to underemployed individuals.
    float UJM()
    {
        // UJM.K = TABHL(UJMT,UR.K,0,3,0.25)
    }

    // Eq (11)
    // Impact of low-cost housing program on area attractiveness.
    // Accounts for attractiveness above and beyond that provided
    // by the physical housing units
    // (May or may not include this)
    float UHPM()
    {
        // UHPM.K = TABHL(UHPMT,UHPR.K,0,0.05,0.01)
    }

    // Eq (12)
    // Underemployed housing program rate
    float UHPR()
    {
        // UHPR.K = LCHP.JK / U.K
    }

    // Eq (13)
    // Underemployed depatures
    float UD()
    {
        // UD.KL = (UDN)(U.K)(UDM.K)
    }

    // Eq (14)
    // Underemployed departure multiplier
    float UDM()
    {
        // UDM.K = TABHL(UDMT,1.44*LOGN(AMM.K),-3,3,1)
    }

    // Eq (15)
    float UB()
    {
        // UB.KL = (U.K)(UBR)
    }

    // Eq (16)
    // Level equation for accumulating flow into and out of the
    // underemployed pool
    float U()
    {
        // U.K = U.J + (DT)(UA.JK + UB.JK + LTU.JK - UD.JK - UTL.JK)
    }
#endregion

#region Labor Sector

    // The labor pool is influenced by 6 flow rates
    // 1) Upward mobility from underemployed
    // 2) Downward mobility from labor to unemployed
    // 3) Labor arrivals from outside the city
    // 4) Labor departures
    // 5) Upward mobility from labor to managerial-professional group
    // 6) Labor birth rate

    // Eq (17)
    // Computes the flow from the underemployed to the labor group
    float UTL()
    {
        // UTL.KL = (UMN)(UMNP.K) + UTP.K
    }

    // Eq (18)
    // Computes the number of unemployed working
    float UW()
    {
        // UW.K = (U.K)(UFW.K)
    }

    // Eq (19)
    // Fraction of underemployed working
    float UFW()
    {
        // UFW.K = TABHL(UFWT,UR.K,0,4,1)
    }

    // Eq (20)
    // Perceived migration of underemployed to labor. First-order exponential delay
    float UTLP()
    {
        // UTLP.K = UTLP.J + (DT/UTLPT)(UTL.JK - UTLP.J)
    }

    // Eq (21)
    // Underemployed mobility. This gives the fraction of underemployed observed
    // as making the upward transition to the labor class each year.
    float UM()
    {
        // UM.K = UTLP.K / U.K
    }

    // Eq (22)
    // Underemployed mobility multiplier perceived. The perception delay represents
    // training time and time necessary for social influences to become effective
    float UMMP()
    {
        // UMMP.K = UMMP.J + (DT/UMMPT)(UMM.J - UMMP.J)
    }

    // Eq (23)
    // This equation calculates the unemployed mobility multiplier. It combines
    // three system conditions that influence upward mobility.
    float UMM()
    {
        // Note: UMF is not a real world factor but a technical parameter
        // permitting experimentation with the effect of this equation
        // UMM.K = (LSM.K)(LUM.K)(UEM.K)(UMF)
    }

    // Eq (24)
    // The labor-supply multiplier describes the relationship between the labor/job
    // ratio and upward mobility from underemployed to labor. Upward mobility is
    // increased when there is a shortage of labor and an excess of labor jobs.
    // Mobility is decreased when there is an excess of labor and a shortage of
    // more skilled positions.
    float LSM()
    {
        // LSM.K = TABHL(LSMT,LR.K,0,2,.5)
    }

    // Eq (25)
    // This equation describes the unfluence of the ratio of labor to underemployed.
    // The assumption is that as the labor group decreases relative to the
    // underemployed, there is less skilled labor in evidence and fewer jobs to
    // serve as examples for the underemployed.
    float LUM()
    {
        // LUM.K = TABHL(LUMT,LUR.K,0,5,1)
    }

    // Eq (26)
    // Labor / underemployed ratio
    float LUR()
    {
        // LUR.K = L.K / U.K
    }

    // Eq (27)
    // This equation models the impact of tax expenditures on education for upward
    // economic mobility of the underemployed. Decreasing tax expenditures have a
    // negative impact on economic mobility
    float UEM()
    {
        // UEM.K = TABHL(UEMT,TPCR.K,0,3,.5)
    }

    // Eq (28)
    // Labor birth-rate
    float LB()
    {
        // LB.KL = (L.K)(LBR)
    }

    // Eq (29)
    // Level equation accumulating the flow rates into and out of the labor pool
    float L()
    {
        // L.K = L.J + (DT)(UTL.JK + LB.JK - LTM.JK + LA.JK - LD.JK - LTU.JK)
    }

    // Eq (30)
    // Dropout rate from labor to underemployed contingent on labor / job ratio
    float LTU()
    {
        // LTU.KL = (L.K)(LLF.K)
    }

    // Eq (31)
    // Labor layoff fraction
    float LLF()
    {
        // LLF.K = TABLE(LLFT,LR.K,0,2,0.5)
    }

    // Eq (32)
    // This equation describes the upward mobility from labor to the managerial-professional group
    float LTM()
    {
        // LTM.KL = (LMN)(L.K)(LMMP.K) + LTPG.K
    }

    // Eq 33
    float LMMP()
    {
        // LMMP.K = LMMP.J + (DT/LMMPT)(LMM.J - LMMP.J)
    }

    // Eq 34
    float LMM()
    {
        // LMM.K = (MSM.K)(MLM.K)(LEM.K)(LMF)
    }

    // Eq 35
    float MSM()
    {
        // MSM.K = TABHL(MSMT.MR.K,0,2,.25)
    }

    // Eq 36
    float MR()
    {
        // MR.K = MP.K / MJ.K
    }

    // Eq 37
    float MJ()
    {
        // MJ.K = (NE.K)(NEM) + (MB.K)(MBM) + (DI.K)(DIM)
    }

    // Eq 38
    float MLM()
    {
        // MLM.K = TABHL(MLMT,MLR.K,0,.2,.05)
    }

    // Eq 39
    float MLR()
    {
        // MLR.K = MP.K / L.K
    }

    // Eq 40
    float LEM()
    {
        // LEM.K = TABHL(LEMT,TPCR.K,0,3,.5)
    }

    // Eq 41
    float LA()
    {
        // LA.KL = (LAN)(L.K)(LAMP.K)
    }

    // Eq 42
    float LAMP()
    {
        // LAMP.K = LAMP.J + (DT/LAMPT)(LAM.J-LAMP.J)
    }

    // Eq 43
    float LAM()
    {
        // LAM.K = (LAJM.K)(LAUM.K)(LATM.K)(LAHM.K)(LAF)
    }

    // Eq 44
    float LAJM()
    {
        // LAJM.K = TABLE(LAJMT,LRK.K,0,2,.25)
    }

    // Eq 45
    float LAUM()
    {
        // LAUM.K = TABHL(LAUMT,LUR.K,0,5,1)
    }

    // Eq 46
    float LATM()
    {
        // LATM.K = TABLE(LATMT,1.44^LOGN(TR.K),-2,4,2)
    }

    // Eq 47
    float LAHM()
    {
        // LAHM.K = TABLE(LAHMT,LHR.K,0,3,0.5)
    }

    // Eq 48
    float LHR()
    {
        // LHR.K = (L.K*LFS)/(WH.K*WHPD)
    }

    // Eq 49
    float LD()
    {
        // LD.KL = (LDN)(L.K)(LDM.K)
    }

    // Eq 50
    float LDM()
    {
        // LDM.K = TABHL(LDMT,1.44*LOGN(LAM.K),-3,3,1)
    }
#endregion

#region Managerial-Professional Sector
#endregion


#region Table Lookup Functions
    /// <summary>
    /// Table lookup function with extrapolation
    /// </summary>
    /// <param name="x">X values in monotonically increasing order</param>
    /// <param name="y">Y values for the given x values</param>
    /// <param name="q">The x value to query at</param>
    /// <returns></returns>
    float TABLE(float[] x, float[] y, float q)
    {
        // X and Y value arrays must be of equal length
        if (x.Length != y.Length())
        {
            return 0;
        }
        // Need at least two values in the lookup table
        if (x.Length < 1 || y.Length < 1)
        {
            return 0;
        }

        float n = x.Length - 1;
        
        // Verify values in x are monotonically increasing
        for(int i = 1; i <= n; i++)
        {
            // If a value is less than the previous value, fail early
            if (x[i] < x[i-1])
            {
                return 0;
            }
        }

        // Y value at query point q
        float yq = 0;

        if (q < x[0])
        {
            // Get slope between x[0] and x[1] and extrapolate
            float m = (y[1] - y[0]) / (x[1] - x[0]);
            yq = y[0] + m*(q - x[0]);
        }
        else if (q > x[n])
        {
            // Get slope between x[n-1] and x[n] and extrapolate
            float m = (y[n] - y[n-1]) / (x[n] - x[n-1]);
            yq = y[n] + m*(q - x[n]);
        }
        else
        {
            // Find the two x values that q lies between and interpolate
            for(int i = 0; i < n; i++)
            {
                if (q >= x[i])
                {
                    // Get slope between x[i] and x[i+1]
                    float m = (y[i+1] - y[i]) / (x[i+1] - x[i]);
                    // Interpolate at q
                    yq = y[i] + m*(q - x[i]);
                    break;
                }
            }
        }

        return yq;
    }

    /// <summary>
    /// Table lookup function with clamping. If q lies outside of x[0] and x[n],
    /// yq is clamped to y[0] and y[n], respectively.
    /// </summary>
    /// <param name="x">X values in monotonically increasing order</param>
    /// <param name="y">Y values for the given x values</param>
    /// <param name="q">The x value to query at</param>
    /// <returns></returns>
    float TABHL(float[] x, float[] y, float q)
    {
        // X and Y value arrays must be of equal length
        if (x.Length != y.Length())
        {
            return 0;
        }
        // Need at least two values in the lookup table
        if (x.Length < 1 || y.Length < 1)
        {
            return 0;
        }

        float n = x.Length - 1;
        
        // Verify values in x are monotonically increasing
        for(int i = 1; i <= n; i++)
        {
            // If a value is less than the previous value, fail early
            if (x[i] < x[i-1])
            {
                return 0;
            }
        }

        // Y value at query point q
        float yq = 0;

        if (q < x[0])
        {
            yq = y[0];
        }
        else if (q > x[n])
        {
            yq = y[n];
        }
        else
        {
            // Find the two x values that q lies between and interpolate
            for(int i = 0; i < n; i++)
            {
                if (q >= x[i])
                {
                    // Get slope between x[i] and x[i+1]
                    float m = (y[i+1] - y[i]) / (x[i+1] - x[i]);
                    // Interpolate at q
                    yq = y[i] + m*(q - x[i]);
                    break;
                }
            }
        }

        return yq;
    }
#endregion

#region Managerial-Professional Sector

    // Eq 51
    // Managerial-professional birth rate (births minus deaths)
    float MPB()
    {
        // MPB.KL = (MP.K)(MPBR)
    }

    // Eq 52
    // Managerial-professional level equation
    float MP()
    {
        // MP.K = MP.J + (DT)(LTM.JK + MPB.JK + MA.JK - MD.JK)
    }

    // Eq 53
    // Managerial arrivals
    float MA()
    {
        // MA.KL = (MAN)(MP.K)(MAMP.K)
    }

    // Eq 54
    // Manager arrival multiplier perceived
    float MAMP()
    {
        // MAMP.K = MAMP.J + (DT/MAMPT)(MAM.J - MAMP.J)
    }

    // Eq 55
    // Manager arrival multiplier
    float MAM()
    {
        // MAM.K = (MAJM.K)(MAPM.K)(MATM.K)(MAHM.K)(MAF)
    }

    // Eq 56
    // Manager arrival job multiplier
    float MAJM()
    {
        // MAJM.K = TABLE(MAJMT,MR.K,0,2,.25)
    }

    // Eq 57
    // Manager arrival population multiplier
    float MAPM()
    {
        // MAPM.K = TABHL(MAPMT,MPR.K,0,.1,.02)
    }

    // Eq 58
    // Manager population ratio
    float MPR()
    {
        // MPR.K = MP.K/(L.K+U.K)
    }

    // Eq 59
    // Manager arrival tax multiplier
    float MATM()
    {
        // MATM.K = TABLE(MATMT,1.44*LOGN(TR.K),-2,4,2)
    }

    // Eq 60
    // Manager arrival housing multiplier
    float MAHM()
    {
        // MAHM.K = TABLE(MAHMT,MHR.K,0,3,.5)
    }

    // Eq 61
    // Manager housing ratio
    float MHR()
    {
        // MHR.K = (MP.K*MPFS)/(PH.K*PHPD)
    }

    // Eq 62
    // Manager departures
    float MD()
    {
        // MD.KL = (MDN)(MP.K)(MDM.K)
    }

    // Eq 63
    float MDM()
    {
        // MDM.K = TABHL(MDMT,1.44*LOGN(MAM.K),-3,3,1)
    }
#endregion

#region Premium-Housing Sector
    // Eq 64
    // Premium housing construction rate
    float PHC()
    {
        // PHC.KL = (PHCD.K)(LCR.K)
    }

    // Eq 65
    // Premium housing construction desired
    float PHCD()
    {
        // PHCD.K = (PHCN)(PH.K)(PHM.K) + PHCP.K
    }

    // Eq 66
    // Premium housing multiplier
    float PHM()
    {
        // PHM.K = (PHAM.K)(PHLM.K)(PHPM.K)(PHTM.K)(PHEM.K)(PHGM.K)(PHF)
    }

    // Eq 67
    // Premium housing adequacy multiplier
    float PHAM()
    {
        // PHAM.K = TABLE(PHAMT,MHR.K,0,2,.25)
    }

    // Eq 68
    // Premium housing land multiplier
    float PHLM()
    {
        // PHLM.K = TABHL(PHLMT,LFO,0,1,.1)
    }

    // Eq 69
    // Land fraction occupied
    float LFO()
    {
        // LFO.K = (HUT.K*LPH + PUT.K*LPP)/AREA
    }

    // Eq 70
    // Housing units total
    float HUT()
    {
        // HUT.K = PH.K + WH.K + UH.K
    }

    // Eq 71
    // Productive units total
    float PUT()
    {
        // PUT.K = NE.K + MB.K + DI.K
    }

    // Eq 72
    // Premium housing population multiplier
    float PHPM()
    {
        // PHPM.K = TABHL(PHPMT,MPR.K,0,.1,.02)
    }

    // Eq 73
    // Premium housing tax multiplier
    float PHTM()
    {
        // PHTM.K = TABHL(PHTMT,1.44*LOGN(TR.K),-2,4,2)
    }

    // Eq 74
    // Premium housing enterprise multiplier
    float PHEM()
    {
        // PHEM.K = TABHL(PHEMT,NEGR.K,-.1,.15,.05)
    }

    // Eq 75
    // Premium housing growth multiplier
    float PHGM()
    {
        // PHGM.K = TABHL(PHGMT,PHGR.K,-.1,.15,.05)
    }

    // Eq 76
    // Premium housing growth rate
    float PHGR()
    {
        // PHGR.K = (PH.K - PHA.K) / (PH.K*PHAT)
    }

    // Eq 77
    // Premium housing average
    float PHA()
    {
        // PHA.K = PHA.J + (DT/PHAT)(PH.J - PHA.J)
    }

    // Eq 78
    // Premium housing
    float PH()
    {
        // PH.K = PH.J + (DT)(PHC.JK - PHO.JK)
    }

    // Eq 79
    // Premium housing obsolescence
    float PHO()
    {
        // PHO.KL = (PHON)(PH.K)(PHOM.K)
    }

    // Eq 80
    // Premium housing obsolescence multiplier
    float PHOM()
    {
        // PHOM.K = TABHL(PHOMT,1.44*LOGN(PHM.K),-3,3,1)
    }
#endregion

#region Worker-Housing Sector
    // Eq 81
    // Worker housing
    float WH()
    {
        // WH.K = WH.J + (DT)(PHO.JK + WHC.JK - WHO.JK)
    }

    // Eq 82
    // Worker housing construction
    float WHC()
    {
        // WHC.KL = (WHCD.K)(LCR.K)
    }

    // Eq 83
    // Worker housing construction desired
    float WHCD()
    {
        // WHCD.K = (WHCN)(WH.K)(WHM.K) + WHCP.K
    }

    // Eq 84
    // Worker housing multiplier
    float WHM()
    {
        // WHF.K = (WHAM.K)(WHLM.K)(WHUM.K)(WHTM.K)(WHEM.K)(WHGM.K)(WHF)
    }

    // Eq 85
    // Worker housing adequacy multiplier
    float WHAM()
    {
        // WHAM.K = TABHL(WHAMT,LHR.K,0,2,.25)
    }

    // Eq 86
    // Worker housing land multiplier
    float WHLM()
    {
        // WHLM.K = TABHL(WHLMT,LFO.K,0,1,.1)
    }

    // Eq 87
    // Worker housing underemployed multiplier
    float WHUM()
    {
        // WHUM.K = TABHL(WHUMT,LUR.K,0,5,1)
    }

    // Eq 88
    // Worker housing tax multiplier
    float WHTM()
    {
        // WHTM.K = TABHL(WHTMT,1.44*LOGN(TR.K),-2,4,2)
    }

    // Eq 89
    // Worker housing enterprise multiplier
    float WHEM()
    {
        // WHEM.K = TABHL(WHEMT,NEGR.K,-.2,.3,.1)
    }

    // Eq 90
    // Worker housing growth multiplier
    float WHGM()
    {
        // WHGM.K = TABHL(WHGMT,WHGR.K,-.1,.15,.05)
    }

    // Eq 91
    // Worker housing growth rate
    float WHGR()
    {
        // WHGR.K = (WH.K-WHA.K) / (WH.K*WHAT)
    }

    // Eq 92
    // Worker housing obsolescence
    float WHO()
    {
        // WHO.KL = (WHON)(WH.K)(WHOM.K)
    }

    // Eq 93
    // Worker housing obsolescence multiplier
    float WHOM()
    {
        // WHOM.K = TABHL(WHOMT,1.44*LOGN(WHM.K),-3,3,1)
    }  
#endregion

#region Underemployed Housing Sector
    // Eq 95
    // Underemployed housing
    float UH()
    {
        // UH.K = UH.J + (DT)(WHO.JK - SHD.JK + LCHP.JK)
    }

    // Eq 96
    // Slum housing demolition rate
    float SHD()
    {
        // SHD.KL = (SHDN)(UH.K)(SHDM.K) + SHDP.K
    }

    // Eq 97
    // Slum housing demolition multiplier
    float SHDM()
    {
        // SHDM.K = (SHAM.K)(SHLM.K)(SHDF)
    }

    // Eq 98
    // Slum housing abandoned multiplier
    float SHAM()
    {
        // SHAM.K = TABLE(SHAMT,UHR.K,0,2,.5)
    }

    // Eq 99
    // Slum housing land multiplier
    float SHLM()
    {
        // SHLM.K = TABHL(SHLMT,LFO.K,.8,1,.05)
    }
#endregion

#region New-Enterprise Sector

    // Eq 100
    // New enterprise level equation
    float NE()
    {
        // NE.K = NE.J + (DT)(NEC.JK - NED.JK)
    }

    // Eq 101
    // New enterprise construction
    float NEC()
    {
        // NEC.KL = (NECD.K)(LCR.K)
    }

    // Eq 102
    // New enterprise construction desired
    float NECD()
    {
        // NECD.K = (NECN)(NECF*NE.K + MBCF*MB.K + DICF.DI.K)(EM.K) + NECP.K
    }

    // Eq 103
    // Enterprise multiplier
    float EM()
    {
        // EM.K = (EMM.K)(ELM.K)(ELJM.K)(ETM.K)(EGM.K)(EF)
    }

    // Eq 104
    // Enterprise manager / job multiplier
    float EMM()
    {
        // EMM.K = TABHL(EMMT,MR.K,0,2,.25)
    }

    // Eq 105
    // Enterprise land multiplier
    float ELM()
    {
        // ELM.K = TABHL(ELMT,LFO.K,0,1,.1)
    }

    // Eq 106
    // Enterprise labor / job multiplier
    float ELJM()
    {
        // ELJM.K = TABHL(ELJMT,LRP.K,0,2,.25)
    }

    // Eq 107
    // Enterprise tax multiplier
    float ETM()
    {
        // ETM.K = TABHL(ETMT,1.44*LOGN(TR.K),-2,4,1)
    } 

    // Eq 108
    // Enterprise growth multiplier
    float EGM()
    {
        // EGM.K = TABHL(EGMT,NEGR.K,-.1,.15,.05)
    }

    // Eq 109
    // New enterprise growth rate
    float NEGR()
    {
        // NEGR.K = (NE.K - NEA.K) / (NE.K*NEAT)
    }

    // Eq 110
    // New enterprise average
    float NEA()
    {
        // NEA.K = NEA.J + (DT/NEAT)(NE.J - NEA.J)
    }
#endregion

#region Mature Business Sector
    // Eq 111
    // New enterprise decline
    float NED()
    {
        // NED.KL = (NEDN)(NE.K)(EDM.K)
    }

    // Eq 112
    // Enterprise decline multiplier
    float EDM()
    {
        // EDM.K = TABHL(EDMT,1.44*LOGN(EM.K),-3,3,1)
    }

    // Eq 113
    // Mature business
    float MB()
    {
        // MB.K = MB.J + (DT)(NED.JK - MBD.JK)
    }

    // Eq 114
    // Mature business decline
    float MBD()
    {
        // MBD.KL = (MBDN)(MB.K)(BDM.K)
    }

    // Eq 115
    // Business decline multiplier
    float BDM()
    {
        // BDM.K = TABHL(BDMT,1.44*LOGN(EM.K),-3,3,1)
    }
#endregion

#region Declining Industry Sector

    // Eq 116
    // Declining industry
    float DI()
    {
        // DI.K = DI.J + (DT)(MBD.JK - DID.JK)
    }

    // Eq 117
    // Declining industry demolition
    float DID()
    {
        // DID.KL = (DIDN)(DI.K)(DIDM.K) + DIDP.K
    }

    // Eq 118
    // Declining industry demolition multiplier
    float DIDM()
    {
        // DIDM.K = (DIEM.K)(DILM.K)(DIDF)
    }

    // Eq 119
    // Declining industry enterprise multiplier
    float DIEM()
    {
        // DIEM.K = TABLE(DIEMT,1.44*LOGN(EM.K),-3,3,1)
    }

    // Eq 120
    // Declining industry land multiplier
    float DILM()
    {
        // DILM.K = TABHL(DILMT,LFO.K,.8,1,.05)
    }
#endregion

#region Tax Sector

    // Eq 121
    // Tax collections
    float TC()
    {
        // TC.K = (AV.K)(TAN)(TR.K)
    }

    // Eq 122
    // Tax ratio
    float TR()
    {
        // TR.K = TABHL(TRT,1.44*LOGN(TRNP.K),-2,4,1)
    }

    // Eq 123
    // Tax ratio needed perceived
    float TRNP()
    {
        // TRNP.K = TRNP.J + (DT/TRNPT)(TRN.J - TRNP.J)
    }

    // Eq 124
    // Tax ratio needed
    float TRN()
    {
        // TRN.K = TAI.K / TAN
    }

    // Eq 125
    // Tax assessment indicated
    float TAI()
    {
        // TAI.K = TN.K / AV.K
    }

    // Eq 126
    // Taxes needed
    float TN()
    {
        // TN.K = (TMP*MPFS*MP.K + TLP*LFS*L.K + TUP*UFS*U.K)(TCM.K)
    }

    // Eq 127
    // Tax collection multiplier
    float TCM()
    {
        // TCM.K = TABHL(TCMT,LUR.K,0,3,.5)
    }

    // Eq 128
    // Assessed value
    float AV()
    {
        // AV.K = (HAV.K + BAV.K)
    }

    // Eq 129
    // Housing assessed value
    float HAV()
    {
        // HAV.K = (PHAV*PH.K + WHAV*WH.K + UHAV*UH.K)
    }

    // Eq 130
    // Business assessed value
    float BAV()
    {
        // BAV.K = (NEAV*NE.K + MBAV*MB.K + DIAV*DI.K)
    }
#endregion

#region Job Sector
    // Eq 131
    // Labor desired for construction
    float LDC()
    {
        // LDC.K = PHCD.K*PHCL + WHCD.K*WHCL + NECD.K*NECL + LCHCD.K*LCHCL
    }

    // Eq 132
    // Labor desired for industry
    float LDI()
    {
        // LDI.K = NE.K*NEL + MB.K*MBL + DI.K*DIL
    }

    // Eq 133
    // Total available jobs
    float LJ()
    {
        // LJ.K = LDC.K + LDI.K
    }

    // Eq 134
    // Labor / job ratio
    float LR()
    {
        // LR.K = L.K / LJ.K
    }

    // Eq 135
    // Underemployed labor / job ratio
    float ULJR()
    {
        // ULJR.K = TABHL(ULJRT.LR.K,0,2,.5)
    }

    // Eq 136
    // Underemployed jobs
    float UJ()
    {
        // UJ.K = LJ.K*ULJR.K + UJP.K
    }

    // Eq 137
    // Underemployed job ratio
    float UR()
    {
        // UR.K = U.K / UJ.k
    }

    // Eq 138
    // Labor construction ratio
    float LCR()
    {
        // LCR.K = TABHL(LCRT,LR.K,0,2,.5)
    }

    // Eq 139
    // Labor / job ratio perceived
    float LRP()
    {
        // LRP.K = LRP.J + (DT/LRPT)(LR.J - LRP.J)
    }
#endregion

#region Urban Development Programs

    // Eq 140
    // Underemployment training program
    float UTP()
    {
        // UTP.K = UTR*U.K*CLIP(0,1,SWT1,TIME.K)
    }

    // Eq 141
    // Labor training program
    float LTPG()
    {
        // LTPG.K = LTR*L.K*CLIP(0,1,SWT2,TIME.K)
    }

    // Eq 142
    // Premium housing construction program
    float PHCP()
    {
        // PHCP.K = PHCR*PH.K*PHLM.K*CLIP(0,1,SWT3,TIME.K)
    }

    // Eq 143
    // Worker housing construction program
    float WHCP()
    {
        // WHCP.K = WHCR*HUT.K*WHLM.K*CLIP(0,1,SWT4,TIME.K)
    }

    // Eq 144
    // Slum housing demolition program
    float SHDP()
    {
        // SHDP.K = SHDR*UH.K*CLIP(0,1,SWT5,TIME.K)
    }

    // Eq 145
    // New-enterprise construction program
    float NECP()
    {
        // NECP.K = NECR*PUT.K*ELM.K*CLIP(0,1,SWT6,TIME.K)
    }

    // Eq 146
    // Declining industry demolition program
    float DIDP()
    {
        // DIDP.K = DIDR*DI.K*CLIP(0,1,SWT7,TIME.K)
    }
    
    // Eq 147
    // Tax per capita subsidy program
    float TPCSP()
    {
        // TPCSP.K = TPCS*CLIP(0,1,SWT8,TIME.K)
    }

    // Eq 148
    // Underemployed job program
    float UJP()
    {
        // UJP.K = UJPC*U.K*CLIP(0,1,SWT9,TIME.K)
    }

    // Eq 149
    // Low cost housing program
    float LCHP()
    {
        // LCHP.KL = (LCHCD.K)(LCR.K)
    }

    // Eq 150
    // Low cost housing construction desired
    float LCHCD()
    {
        // LCHCD.K = LCHPC*U.K*WHLM.K*CLIP(0,1,SWT10,TIME.K)
    }
#endregion
}