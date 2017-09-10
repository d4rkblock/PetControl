namespace Minicurso.Infra
{
    public interface IFileUtility
    {
        string SaveFile(string fileName, byte[] fileStream);
        void DeleteDirectory();
    }
}