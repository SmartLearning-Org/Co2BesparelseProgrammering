
namespace Co2Besparelse
{
    internal class Koordinatset
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public override string ToString()
        {
            return $"({Longitude};{Latitude})";
        }
    }
}
