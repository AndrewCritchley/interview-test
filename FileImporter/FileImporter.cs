using System;
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
}
