namespace FazendaBrasil.Domain
{
    public class Frequency
    {
        public Frequency(string decription, string name, int rangeOfDays)
        {
            Description = decription;
            Name = name;
            RangeOfDays = rangeOfDays;
        }

        public Frequency()
        {

        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int RangeOfDays { get; set; }
    }
}
