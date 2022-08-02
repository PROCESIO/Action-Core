using System;
using System.IO;

namespace Ringhel.Procesio.Action.Core.Models
{
    public class FileModel
    {
        public Stream File { get; set; }
        public string Name { get; set; }
        public string Hash { get; set; }
        public Guid? Id { get; set; }

        public FileModel() {}

        public FileModel(Stream file, string name, string hash = null, Guid? id = null)
        {
            var memoryStream = new MemoryStream();
            using (var responseStream = file)
            {
                responseStream.CopyTo(memoryStream);
                Console.WriteLine($"File stream has length of: {memoryStream.Length}");
            }

            File = memoryStream;
            Name = name;
            Hash = hash;
            Id = id;
        }

        public FileModel Clone()
        {
            File.Seek(0, SeekOrigin.Begin);
            return new FileModel(File, Name, Hash, Id);
        }
    }
}
