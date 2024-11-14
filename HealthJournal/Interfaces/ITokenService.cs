using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(User user);
    }
}
