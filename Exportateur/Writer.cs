using System;
using System.IO;
using System.Text;
namespace Exportateur
{
    public sealed class Writer
    {

        private static Writer instance = null;
        private static readonly object padlock = new object();

        Writer()
        {
        }

        public static Writer Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Writer();
                    }
                    return instance;
                }
            }
        }

        public void Write(string path, string content)
        {
            if (!File.Exists(path))
            { 
                File.Create(path).Close();
            }
            File.WriteAllText(path,content);
        }
    }
}