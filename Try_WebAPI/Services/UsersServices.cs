using Try_WebAPI.Models;

namespace Try_WebAPI.Services
{
    public class UsersServices
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetUsersByProjectId(int projectId)
        {
            return _users.Where(u => u.ProjectId == projectId).ToList();
        }

        public void DeleteUsersByProjectId(int projectId)
        {
            _users.RemoveAll(u => u.ProjectId == projectId);
        }
    }
}
