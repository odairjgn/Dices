using System.IO;

namespace DicesCore.Extensoes
{
    public static class IOExtentions
    {
        public static string GarantirExistenciaPasta(this string folder)
        {
            return new DirectoryInfo(folder).GarantirExistenciaPasta().FullName;
        }

        public static DirectoryInfo GarantirExistenciaPasta(this DirectoryInfo folder)
        {
            if(!folder.Exists)
                folder.Create();

            return folder;
        }

    }
}
