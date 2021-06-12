using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanDynamics
{
    public static class Table
    {
        /// <summary>
        /// Table lookup function with extrapolation
        /// </summary>
        /// <param name="x">X values in monotonically increasing order</param>
        /// <param name="y">Y values for the given x values</param>
        /// <param name="q">The x value to query at</param>
        /// <returns></returns>
        public static double Lookup(double[] x, double[] y, double q)
        {
            // X and Y value arrays must be of equal length
            if (x.Length != y.Length)
            {
                return 0;
            }
            // Need at least two values in the lookup table
            if (x.Length < 1 || y.Length < 1)
            {
                return 0;
            }

            int n = x.Length - 1;

            // Verify values in x are monotonically increasing
            for (int i = 1; i <= n; i++)
            {
                // If a value is less than the previous value, fail early
                if (x[i] < x[i - 1])
                {
                    return 0;
                }
            }

            // Y value at query point q
            double yq = 0;

            if (q < x[0])
            {
                // Get slope between x[0] and x[1] and extrapolate
                double m = (y[1] - y[0]) / (x[1] - x[0]);
                yq = y[0] + m * (q - x[0]);
            }
            else if (q > x[n])
            {
                // Get slope between x[n-1] and x[n] and extrapolate
                double m = (y[n] - y[n - 1]) / (x[n] - x[n - 1]);
                yq = y[n] + m * (q - x[n]);
            }
            else
            {
                // Find the two x values that q lies between and interpolate
                for (int i = 1; i <= n; i++)
                {
                    if (q < x[i])
                    {
                        // Get slope between x[i] and x[i+1]
                        double m = (y[i] - y[i - 1]) / (x[i] - x[i - 1]);
                        // Interpolate at q
                        yq = y[i - 1] + m * (q - x[i - 1]);
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
        public static double LookupClamp(double[] x, double[] y, double q)
        {
            // X and Y value arrays must be of equal length
            if (x.Length != y.Length)
            {
                return 0;
            }
            // Need at least two values in the lookup table
            if (x.Length < 1 || y.Length < 1)
            {
                return 0;
            }

            int n = x.Length - 1;

            // Verify values in x are monotonically increasing
            for (int i = 1; i <= n; i++)
            {
                // If a value is less than the previous value, fail early
                if (x[i] < x[i - 1])
                {
                    return 0;
                }
            }

            // Y value at query point q
            double yq = 0;

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
                for (int i = 1; i <= n; i++)
                {
                    if (q < x[i])
                    {
                        // Get slope between x[i] and x[i+1]
                        double m = (y[i] - y[i - 1]) / (x[i] - x[i - 1]);
                        // Interpolate at q
                        yq = y[i - 1] + m * (q - x[i - 1]);
                        break;
                    }
                }
            }

            return yq;
        }
    }
}
