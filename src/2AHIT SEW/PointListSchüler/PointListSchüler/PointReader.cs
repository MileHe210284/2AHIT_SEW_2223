using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PointCoords
{
    class PointRecorder
    {  
        public List<Point> PointList;

        //Konstruktor
        public PointRecorder()
        {
            PointList = new List<Point>();
        }
        
        //Methoden
        public void AddPoint(double x, double y)
        {
            Point p = new Point(x,y);
            PointList.Add(p);
         }
       
        public void WriteToFile(string path)
        {
          
            using (StreamWriter sw = new StreamWriter(path)) 
            {
              foreach(Point p in PointList)
                {
                    sw.WriteLine("{0};{1}", p.Xcoord, p.Ycoord);
                }
               
            }           
        }

        public List<Point> ReadFromFile(string path)
        {
            string zeile = " ";
            PointList.Clear();

            using (StreamReader sr = new StreamReader(path))
            {
                while((zeile=sr.ReadLine()) != null)
                {
                    string[] pointCoords = zeile.Split(new char[1] { ';' });
                    AddPoint(Double.Parse(pointCoords[0]), Double.Parse(pointCoords[1]));
                }
               
            }
            return PointList;
        }

        public void WriteToFileBin(string path)
        {  
            using (FileStream fileStr = new FileStream(path, FileMode.Create))
            {
                using (BinaryWriter binWriter = new BinaryWriter(fileStr))
                {
                    binWriter.Write(PointList.Count);
                    for(int i=0; i<PointList.Count; i++) 
                    {
                        binWriter.Write(PointList[i].Xcoord);
                        binWriter.Write(PointList[i].Ycoord);
                    }         
                }
            } 
        }

        public List<Point> ReadFromFileBin(string path)
        {
            
            PointList.Clear();

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                
                using (BinaryReader br = new BinaryReader(fs))
                {
                    int size = br.ReadInt32();
                    double x, y;
                    for (int i = 0; i < size; i++)
                    {
                        x = br.ReadDouble();
                        y = br.ReadDouble();
                        AddPoint(x, y);
                    }

                    
                }
            }
            return PointList;
        }

        public Point GetPoint(int pointNo)
        {
            // liest Point mit Index pointNo-1 aus der PointList
            if (pointNo <= PointList.Count && pointNo > 0)
            {
                return (Point)PointList[pointNo-1];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Illegal Pointnumber");
            }
        }
        public Point GetPointBin(string path, int pointNo)
        {   
            Point savedPoint;
            int pos;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    fs.Seek(0, SeekOrigin.Begin);
                 
                    if (pointNo > br.ReadInt32() || pointNo <= 0)
                    {
                        string message = "Unter der angegebenen Position ist";
                        message += " kein \nPoint-Objekt gespeichert.";
                        throw new ArgumentOutOfRangeException(message);
                    }
                    else
                    {
                        // Die Positionsnummer des ersten Bytes in der Datei ist 0,
                        // daher verweist der Zeiger mit der Übergabe der Zahl 4 auf das fünfte Byte.
                        // Position des Zeigers berechnen pos .........
                        //...............
                        // den Zeiger positionieren
                        pos= 4+((pointNo-1)*16)+1;
                        fs.Seek(pos, SeekOrigin.Begin);
                        // Daten des gewünschten Points einlesen
                        savedPoint = new Point();
                       // Koordinaten lesen und savedPoint zuweisen...........
                        return savedPoint;
                    }                    
                }
            }
        }
    }
}
