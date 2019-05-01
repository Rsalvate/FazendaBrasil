using System;

namespace FazendaBrasil.Domain
{
    public class AnimalMedication
    {
        public int Id { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public int MedicationId { get; set; }
        public Medication Medication { get; set; }

        public DateTime UsageDate { get; set; }
    }
}
