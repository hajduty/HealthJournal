namespace HealthJournal.Dto.Patient
{
    public class SearchResultDto
    {
        public ICollection<PatientSearchDto> Patients { get; set; }
        public int TotalCount { get; set; }
    }
}