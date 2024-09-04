using ContactAppRestApi2.Data;
using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ContactDbContext _dbContext = new ContactDbContext();
        public void AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
      
    }
}
