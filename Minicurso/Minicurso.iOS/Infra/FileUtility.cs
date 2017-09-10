using System;
using Minicurso.Infra;

namespace Minicurso.iOS.Infra
{
    public class FileUtility : IFileUtility
    {
        public void DeleteDirectory()
        {
            string imageFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PetImages");
            if (System.IO.Directory.Exists(imageFolderPath))
            {
                System.IO.Directory.Delete(imageFolderPath, true);
            }
        }

        public string SaveFile(string fileName, byte[] fileStream)
        {
            string path = null;
            string imageFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PetImages");

            if (!System.IO.Directory.Exists(imageFolderPath))
                System.IO.Directory.CreateDirectory(imageFolderPath);
            string imagefilePath = System.IO.Path.Combine(imageFolderPath, fileName);

            try
            {
                System.IO.File.WriteAllBytes(imagefilePath, fileStream);
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