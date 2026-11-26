using Zxcvbn;

namespace Services
{
    public interface IPasswordsService
    {
        int Post(string password);
    }
}