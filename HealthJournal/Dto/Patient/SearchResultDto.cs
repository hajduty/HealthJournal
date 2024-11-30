namespace HealthJournal.Dto.Patient
{
    public class SearchResultDto
    {
        public ICollection<PatientDto> Patients { get; set; }
        public int TotalCount { get; set; }
    }
}