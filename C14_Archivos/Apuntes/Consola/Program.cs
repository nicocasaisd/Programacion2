using System;
using System.IO;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, -26} | {4, -26} |",
            "Nombre", "Tipo", "Formato", "Tamaño", "Espacio libre");

            foreach (DriveInfo unidad in DriveInfo.GetDrives())
            {
                if (unidad.IsReady)
                {
                    Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, 20:N0} bytes | {4, 20:N0} bytes |",
                    unidad.Name, unidad.DriveType, unidad.DriveFormat, unidad.TotalSize,
                    unidad.AvailableFreeSpace);
                }
                else
                {
                    Console.WriteLine("{0, -10} | {1, -10}", unidad.Name, unidad.DriveType);
                }
            }
            */
            /*
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine($"Directorio actual clase env: {Environment.CurrentDirectory}");
            Console.WriteLine($"Directorio actual clase dir: {Directory.GetCurrentDirectory()}");
            */

            Console.WriteLine("Environment.SystemDirectory: {0}", Environment.SystemDirectory);
            Console.WriteLine("Path.GetTempPath: {0}", Path.GetTempPath());

            Console.WriteLine("Environment.GetFolderPath(Environment.SpecialFolder.System): {0}", Environment.GetFolderPath(Environment.SpecialFolder.System));
            Console.WriteLine("Environment.GetFolderPath(Environment.SpecialFolder.Desktop): {0}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            Console.WriteLine("Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles): {0}", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            Console.WriteLine("Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86): {0}", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            Console.WriteLine("Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments): {0}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine("Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData): {0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            Console.WriteLine("Environment.GetFolderPath(Environment.SpecialFolder.UserProfile): {0}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));


        }


    }
}
