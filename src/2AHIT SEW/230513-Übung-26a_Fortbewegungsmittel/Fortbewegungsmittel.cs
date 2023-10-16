using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230513_Übung_26a_Fortbewegungsmittel
{
    class Fortbewegungsmittel
    {
        public Fortbewegungsmittel() { } // Standardkonstruktor  
        public Fortbewegungsmittel(bool tires, string typeOfPower, double weight, double height, double width, double length, double price,string brand,double velocity,bool hasEngine, long constructionYear, string serialNumber, string color) 
        {
            Tires = tires;
            TypeOfPower =typeOfPower;
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

            

        public void accelerate()
        {

        }
        public void steer()
        {

        }
    }
}
