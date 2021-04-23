using System;
using System.Collections.Generic;
using System.Text;

namespace Meetlat
{
    class Meetlat
    {
        
        public Meetlat()
        {
            lengteInMeter = 0;
        }
        private double lengteInMeter;
        private double lengte;
        public double Lengte
        {
            get
            {
                return lengte;
            }
            set
            {
                lengte = value;
            }
        }
        public double LengteInCm
        {
            get
            {
                return Lengte * 100;
            }
        }
        public double LengteInKm
        {
            get
            {
                return Lengte / 1000;
            }
        }
        public double LengteInVoet
        {
            get
            {
                return Lengte * 3.28;
            }

        }
        public double LengteInMeter
        {
            get
            {
                return Lengte;
            }
            set
            {
                lengteInMeter = value;
            }
        }
    }
}
