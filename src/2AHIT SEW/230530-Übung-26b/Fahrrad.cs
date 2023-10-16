using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230530_Übung_26b
{
    class Fahrrad:Landfahrzeug
    {
        public Fahrrad( string bikeType, double tirePresure, int numberOfTires, int numberOfLights)
        {
            BikeType = bikeType;
            TirePresure = tirePresure;
            NumberOfTires = numberOfTires;
            NumberOfLights = numberOfLights;
            HasEngine = false;
            Info = "Ein Fahrrad ist ein Fortbewegungsmittel ohne motor.";
        }
        public Fahrrad() { }

        public string BikeType { get; set; }
        public double TirePresure { get; set; }
        public int NumberOfTires { get; set; }
        public int NumberOfLights { get; set; }

       
    }
}
