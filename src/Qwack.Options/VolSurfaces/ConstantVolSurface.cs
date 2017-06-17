﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qwack.Options.VolSurfaces
{
    /// <summary>
    /// A volatility which returns a single constant number for all strikes and expiries
    /// </summary>
    public class ConstantVolSurface : IVolSurface
    {
        public DateTime OriginDate { get; set; }
        public double Volatility { get; set; }

        public ConstantVolSurface()         {        }

        public ConstantVolSurface(DateTime originDate, double volatility)
        {
            Build(originDate, volatility);
        }

        public void Build(DateTime originDate, double volatility)
        {
            OriginDate = originDate;
            Volatility = volatility;
        }

        public double GetVolForAbsoluteStrike(double strike, double maturity, double forward)
        {
            return Volatility;
        }

        public double GetVolForAbsoluteStrike(double strike, DateTime expiry, double forward)
        {
            return Volatility;
        }

        public double GetVolForDeltaStrike(double deltaStrike, double maturity, double forward)
        {
            return Volatility;
        }

        public double GetVolForDeltaStrike(double strike, DateTime expiry, double forward)
        {
            return Volatility;
        }

        public double GetFwdATMVol(DateTime startDate, DateTime endDate)
        {
            return Volatility;
        }
    }
}
