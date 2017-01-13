using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    class GalacticGPS
    {
            struct Location
            {
                private double latitude;
                private double longitude;
                public Location(double latitude, double longitude, Planet planet)
                    : this()
                {
                    this.Latitude = latitude;
                    this.Longitude = longitude;
                    this.Planet = planet;
                }

                public double Latitude 
                {
                    get 
                    { 
                        return this.latitude; 
                    }
                    private set 
                    {
                        if (value < 0 || value > 90)
                        {
                            throw new ArgumentOutOfRangeException("Latiude must be between 0 and 90 degrees!");
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
                    private set
                    {
                        if (value < 0 || value > 180)
                        {
                            throw new ArgumentOutOfRangeException("Longitude must be between 0 and 180 degrees!");
                        }
                        this.longitude = value;
                    }
                }
                public Planet Planet { get; set; }
                            public override string ToString()
                            {
                                return this.Latitude + ", " + this.Longitude + " - " + this.Planet;
                            }
                            
            }
            enum Planet { Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune }
            static void Main()
            {
                Location home = new Location(18.037986, 28.870097, Planet.Earth);
                Console.WriteLine(home);

            }
    }
}
