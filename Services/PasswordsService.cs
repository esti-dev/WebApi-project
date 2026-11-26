using System;
using System.Collections.Generic;
using System.Text;
using Zxcvbn;

namespace Services
{
    public class PasswordsService : IPasswordsService
    {
        public int Post(string password)
        {
            return (Zxcvbn.Core.EvaluatePassword(password)).Score;
        }

        
    }
}
