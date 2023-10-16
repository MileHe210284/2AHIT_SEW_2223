using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230530_Übung_26b
{
    class PKWmitMotor : Fortbewegungsmittel
    {


        public PKWmitMotor() { }
        public PKWmitMotor(int numberOfDoors, string licencePlate, double tirePresure, int numberOfTires, double horsepower, double torque, string typeOfTires, string typeOfBrakes, string fuelType)
        {
            NumberOfDoors = numberOfDoors;
            LicencePlate = licencePlate;
            TirePresure = tirePresure;
            NumberOfTires = numberOfTires;
            Horsepower = horsepower;
            Torque = torque;
            TypeOfTires = typeOfTires;
            TypeOfBrakes = typeOfBrakes;
            FuelType = fuelType;
            HasEngine = true;

        }
        public int NumberOfDoors { get; set; }
        public string LicencePlate { get; set; }
        public double TirePresure { get; set; }
        public int NumberOfTires { get; set; }
        public double Horsepower { get; set; }
        public double Torque { get; set; }
        public string TypeOfTires { get; set; }
        public string TypeOfBrakes { get; set; }
        public string FuelType { get; set; }

        public void stopEngine()
        {
          
        }
        public void openDoor()
        {
          
        }
        public void closeDoor()
        {
         
        }
        public void powerUsage()
        {

        }
    }
}
