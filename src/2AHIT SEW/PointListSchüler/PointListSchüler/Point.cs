namespace PointCoords
{
    public class Point
    {
        public Point() { }
        public double Xcoord { get; set; }
        public double Ycoord {get; set; }
        public Point(double x, double y)
        {
            this.Xcoord = x; this.Ycoord = y;
        }
    }
}//ns
