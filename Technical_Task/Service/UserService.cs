using Technical_Task.Data;
using Technical_Task.IService;
using Technical_Task.Models;

namespace Technical_Task.Service
{
    public class UserService : IUserService
    {
       private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.users.ToList();
        }
        public User GetUserById(int id)
        {
            return _context.users.Find(id);
        }
        public void CreateUser(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            _context.users.Update(user);
            _context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            var user = _context.users.Find(id);
            if (user != null)
            {
                _context.users.Remove(user);
                _context.SaveChanges();
            }
        }
        public User ValidateUser(LoginViewModel loginViewModel)
        {
            return _context.users.FirstOrDefault(u => u.Username == loginViewModel.Username && u.Password == loginViewModel.Password);

        }
    }
}
