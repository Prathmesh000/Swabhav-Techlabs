using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Repository
{
    public interface IUserRepository
    {
        public void AddUser(User user);
        public List<User> GetUsers();
      
 
    }
}
