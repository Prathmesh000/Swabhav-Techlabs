using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Services
{
    public interface IUserServices
    {
        public void AddUserService(User user);

        public List<User> GetUsersService();
    }
}
