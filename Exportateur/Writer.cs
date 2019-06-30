using System;
using System.IO;
using System.Text;
namespace Exportateur
{
    public class Writer
    {
        public Writer()
        {
        }

        public void Write(string path, string content)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.OpenWrite(path).Write(Encoding.ASCII.GetBytes(content));
        }
    }
}
