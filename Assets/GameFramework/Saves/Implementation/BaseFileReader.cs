using PersonalProjects.GameFramework.Saves.Interfaces;
using System.IO;


namespace PersonalProjects.GameFramework.Saves
{
    public class BaseFileReader : IFileReader
    {
        public byte[] Read(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllBytes(path);
            }
            else
            {
                return null;
            }
        }
    }
}
