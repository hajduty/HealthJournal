using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IEncounterRepository
    {
        Encounter GetEncounter(int id);
        Encounter CreateEncounter(Encounter encounter);
        Encounter UpdateEncounter(int id,  Encounter encounter);
        bool DeleteEncounter(int id);
    }
}
