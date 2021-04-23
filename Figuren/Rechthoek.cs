using System;
using System.Collections.Generic;
using System.Text;

namespace Figuren
{
    class Rechthoek
    {
        private int lengte;
        private int breedte;

        public int Lengte
        {
            get
            {
                return lengte;
            }
            set
            {
                if (value >= 1)
                {
                    lengte = value;
                }
            }
        }

        public int Breedte
        {
            get
            {
                return breedte;
            }
            set
            {
                if (value >=1)
                {
                    breedte = value;
                }
            }
        }

        public int ToonOppervlakte()
        {
            return Breedte * Lengte;
        }
    }

    class Driehoek
    {
        private double basis;
        private double hoogte;

        public double Basis
        {
            get
            {
                return basis;
            }
            set
            {
                if (value >= 1)
                {
                    basis = value;
                }
            }
        }

        public double Hoogte
        {
            get
            {
                return hoogte;
            }
            set
            {
                if (value >= 1)
                {
                    hoogte = value;
                }
            }
        }
        public double ToonOppervlakte()
        {
            return (Basis * Hoogte) / 2;
        }
    }
}
