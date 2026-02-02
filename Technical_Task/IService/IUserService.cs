using Technical_Task.Models;

namespace Technical_Task.IService
{
     public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        User ValidateUser(LoginViewModel loginViewModel);
    }
}
