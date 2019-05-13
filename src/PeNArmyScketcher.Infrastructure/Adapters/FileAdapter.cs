using System.IO;

namespace PeNArmyScketcher.Infrastructure.Adapters
{
    public class FileAdapter
    {
        public string GetData(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
