using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImporter
{
    public class FileImporter
    {
        private ShoppaTecRepository _shoppaTecRepository;

        public FileImporter(ShoppaTecRepository shoppaTecRepository)
        {
            _shoppaTecRepository = shoppaTecRepository;
        }

        public void Import(FileImportLine line)
        {
            throw new NotImplementedException();
        }
    }

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

    public class FileImportLine
    {
        public string EmailAddress { get; set; }
        public string Organisation { get; set; }
    }

    public class User
    {
        public string EmailAddress { get; set; }
    }
}
