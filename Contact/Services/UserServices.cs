using ContactAppRestApi2.Models;
using ContactAppRestApi2.Repository;

namespace ContactAppRestApi2.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository = new UserRepository();
        IUserRepository userRepository = new UserRepository();
        public void AddUserService(User user)
        {
            _userRepository.AddUser(user);
        }

        public List<User> GetUsersService()
        {
            return _userRepository.GetUsers();
        }
    }
}
