using Entities;

namespace Repository
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> Get();
        Task<User> GetById(int id);
        Task<User> Login(LoginUser loginUser);
        Task<User> Post(User user);
        Task<bool> IsEmailExist(string email);
        Task Put(int id, User userToUpdate);
    }
}