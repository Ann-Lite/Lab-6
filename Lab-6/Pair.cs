using System;
using System.Collections.Generic;
using System.Text;

namespace PairNumber
{
    class Pair
    {
        public Pair(double initFirst, double initSecond)
        {
            _first = initFirst;
            _second = initSecond;
        }

        private double _first;
        private double _second;

        public double First
        {
            get
            {
                return _first;
            }
            set
            {
                _first = value;
            }
        }
        public double Second
        {
            get
            {
                return _second;
            }
            set
            {
                _second = value;
            }
        }
        public static bool operator >(Pair P1, Pair P2)
        {
            return P1.First > P2.First || P1.Second > P2.Second;
        }

        public static bool operator <(Pair P1, Pair P2)
        {
            return P1.First < P2.First || P1.Second < P2.Second;
        }

        public static bool operator >(Pair P1, int number)
        {
            return P1.First > number || P1.Second > number;
        }

        public static bool operator <(Pair P1, int number)
        {
            return P1.First < number || P1.Second < number; ;
        }

    }
}
