﻿using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IEncounterRepository : IRepository<Encounter>
    {
        ICollection<Encounter> GetEncounters(string userId);
        Encounter GetEncountersWithObservations(int encounterId);
    }
}
