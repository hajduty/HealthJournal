using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
