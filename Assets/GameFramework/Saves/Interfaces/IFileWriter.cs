namespace PersonalProjects.GameFramework.Saves.Interfaces
{
    public interface IFileWriter
    {
        void Write( string path, byte[] data);
    }
}
