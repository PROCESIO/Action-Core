using System;
using System.IO;

namespace Ringhel.Procesio.Action.Core.Models
{
    public class FileModel
    {
        public Stream File { get; set; }
        public string Name { get; set; }

        public FileModel() {}

        public FileModel(Stream file, string name)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (Stream responseStream = file)
            {
                responseStream.CopyTo(memoryStream);
                Console.WriteLine($"File stream has length of: {memoryStream.Length}");
            }

            File = memoryStream;
            Name = name;
        }
    }
}
