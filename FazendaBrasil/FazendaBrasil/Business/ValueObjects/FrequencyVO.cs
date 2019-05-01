namespace FazendaBrasil.Business.ValueObjects
{
    public class FrequencyVO
    {
        public FrequencyVO(int id, string description, string name, int rangeOfDays)
        {
            Id = id;
            Description = description;
            Name = name;
            RangeOfDays = rangeOfDays;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int RangeOfDays { get; set; }
    }
}
