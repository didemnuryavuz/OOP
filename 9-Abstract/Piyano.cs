namespace _9_Abstract
{
    public class Piyano : MuzikAleti
    {
        public override string Marka { get; set; }
        public override string Model { get ; set ; }

        public override string Cal()
        {
            return "Piyano Çal";
        }
    }
}
