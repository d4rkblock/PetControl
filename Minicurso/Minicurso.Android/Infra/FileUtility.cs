using Minicurso.Infra;
using System;
using System.IO;

namespace Minicurso.Droid.Infra
{
    public class FileUtility : IFileUtility
    {
        public void DeleteDirectory()
        {
            string imageFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PetImages");
            if (Directory.Exists(imageFolderPath))
                Directory.Delete(imageFolderPath, true);
        }

        public string SaveFile(string fileName, byte[] fileStream)
        {
            string path = null;
            string imageFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PetImages");

            if (!Directory.Exists(imageFolderPath))
                Directory.CreateDirectory(imageFolderPath);

            string imagefilePath = Path.Combine(imageFolderPath, fileName);

            try
            {
                File.WriteAllBytes(imagefilePath, fileStream);
                path = imagefilePath;
            }
            catch (Exception e)
            {
                throw e;
            }

            return path;
        }
    }
}