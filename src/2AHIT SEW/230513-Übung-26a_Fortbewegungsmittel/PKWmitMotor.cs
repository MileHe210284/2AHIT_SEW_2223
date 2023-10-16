using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230513_Übung_26a_Fortbewegungsmittel
{
    class PKWmitMotor:Fortbewegungsmittel
    {
       

        public PKWmitMotor(){  }
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

        public void startEngine()
        {
            Console.WriteLine("starting Engine...");
        }
        public void stopEngine()
        {
            Console.WriteLine("stopping Engine...");
        }
        public void openDoor()
        {
            Console.WriteLine("opening door...");
        }
        public void closeDoor()
        {
            Console.WriteLine("closing door...");
        }
        public void powerUsage()
        {

        }
    }
}
