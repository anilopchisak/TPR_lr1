using System;
using System.Collections.Generic;
using System.Text;

namespace TPR_LR1
{
    public class Strategy
    {
        public double[,] R;
        public double[,] P;
        public int N;

        public Strategy(double[,] R, double[,] P, int N)
        {
            this.P = P;
            this.R = R;
            this.N = N;
        }
    }
}
