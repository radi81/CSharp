using System;

namespace Homework6
{
    struct Location
    {
        private const double LatitudeMin = -90;
        private const double LatitudeMax = 90;
        private const double LongitudeMin = -180;
        private const double LongitudeMax = 180;

        private double latitude;
        private double longitude;
        private Planet planetId;

        public Location(double latitude, double longitude, Planet planetId)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.PlanetId = planetId;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < LatitudeMin || value > LatitudeMax)
                {
                    throw new ArgumentOutOfRangeException(
                        "Lalitude must be between -90 and 90.");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < LongitudeMin || value > LongitudeMax)
                {
                    throw new ArgumentOutOfRangeException(
                        "Longitude must be beween -180 and 180.");
                }
                this.longitude = value;
            }
        }

        public Planet PlanetId
        {
            get
            {
                return this.planetId;
            }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentNullException(
                        "Invalid planet name.");
                }
                
                if (!Planet.IsDefined(typeof(Planet), PlanetId))
                {
                    Validation.LocationException();
                }
                this.planetId = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",
                    this.Latitude, this.Longitude, this.PlanetId);
        }
    }
}
