using Entities;
using Repository;
using System.Text.Json;
namespace Services
{
    public class UserServices
    {
        UserRepository repository = new UserRepository();
        public IEnumerable<string> Get()
        {
            return repository.Get();
        }

        public User Get(int id)
        {
            return repository.Get(id);

        }

        public User Post(User user)
        {
            return repository.Post(user);
        }


        public User Login(LoginUser loginUser)
        {
            return repository.Login(loginUser);
        }

        public void Put(int id, User userPut)
        {
            repository.Put(id, userPut);
        }

    }
}
}
