namespace FazendaBrasil.Domain
{
    public class CattleAnimal
    {
        public int CattleId { get; set; }
        public Cattle Cattle { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
