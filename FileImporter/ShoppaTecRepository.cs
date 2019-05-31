using System.Collections.Generic;

namespace FileImporter
{
    public class ShoppaTecRepository
    {
        private List<User> _users;

        public void AddUser(User user)
        {

        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}