//fix: removed the stray usings, they are not used
using Zxcvbn;

namespace Services
{
    public class PasswordService : IPasswordService
    {
        public int Post(string password)
        {
            return Zxcvbn.Core.EvaluatePassword(password).Score;
        }
    }
}
