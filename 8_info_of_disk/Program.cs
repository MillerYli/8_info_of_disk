using System;
using System.IO;

namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получим системные диски
             DriveInfo[] drives = DriveInfo.GetDrives();

            //Пройдемся по дискам и выведем их свойста
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if(drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }
        }
    }
}