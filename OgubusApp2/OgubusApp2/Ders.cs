namespace OgubusApp2
{
    public class Ders
    {
        public string DersAdı { get; set; }
        public string DersKodu { get; set; }
        public int DersKredisi { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Ders otherDers)
            {
                return this.DersKodu == otherDers.DersKodu;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return DersKodu.GetHashCode();
        }
    }
}
