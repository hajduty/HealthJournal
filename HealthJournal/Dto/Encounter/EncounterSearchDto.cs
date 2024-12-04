namespace HealthJournal.Dto.Encounter
{
    public class EncounterSearchDto
    {
        public ICollection<EncounterDto> Encounters { get; set; }
        public int TotalCount { get; set; }
    }
}