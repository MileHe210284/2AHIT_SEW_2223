using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230530_Übung_26b
{
    class Fortbewegungsmittel
    {
        public Fortbewegungsmittel() { } // Standardkonstruktor  
        public Fortbewegungsmittel(bool tires, string typeOfPower, double weight, double height, double width, double length, double price, string brand, double velocity, bool hasEngine, long constructionYear, string serialNumber, string color, double speed)
        {
            Tires = tires;
            TypeOfPower = typeOfPower;
            Weight = weight;
            Height = height;
            Width = width;
            Length = length;
            Price = price;
            Brand = brand;
            Velocity = velocity;
            HasEngine = hasEngine;
            ConstructionYear = constructionYear;
            SerialNumber = serialNumber;
            Color = color;
            Speed = speed;
        }
        public bool Tires { get; set; }
        public string TypeOfPower { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public double Velocity { get; set; }
        public bool HasEngine { get; set; }
        public long ConstructionYear { get; set; }
        public string SerialNumber { get; set; }
        public string Color { get; set; }
        public string Info { get; set; }
        public double Speed { get; set; }

        public void steer()
        {

        }
        public void startEngine()
        {
        
        }     
     
    }
}
