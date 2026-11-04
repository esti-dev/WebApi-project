using Entities;
using Repository;
using System.Text.Json;
namespace Services
{
    public class UserService : IUserService
    {
        IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<string> Get()
        {
            return userRepository.Get();
        }

        public User Get(int id)
        {
            return userRepository.Get(id);

        }

        public User Post(User user)
        {
            return userRepository.Post(user);
        }


        public User Login(LoginUser loginUser)
        {
            return userRepository.Login(loginUser);
        }

        public void Put(int id, User userPut)
        {
            userRepository.Put(id, userPut);
        }

    }
}
}
