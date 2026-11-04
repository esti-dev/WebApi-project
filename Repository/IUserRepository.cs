using Entities;

namespace Repository
{
    public interface IUserRepository
    {
        IEnumerable<string> Get();
        User Get(int id);
        User Login(LoginUser loginUser);
        User Post(User user);
        void Put(int id, User userPut);
    }
}