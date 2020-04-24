using System;
using System.IO;

namespace Noha.Arkdays.CLITools
{
    public static class Utils
    {
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        public static void EnsureDirectory(string name)
        {
            var dir = Path.GetDirectoryName(name);
            if (!String.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
