using System;
using System.IO;

namespace Enviroment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deel1
            //string pcName = Environment.MachineName;
            //bool is64Bit = Environment.Is64BitOperatingSystem;
            //int processorCount = Environment.ProcessorCount;
            //string userName = Environment.UserName;
            //Console.WriteLine($"The pc name is: {pcName}");
            //Console.WriteLine($"Is this opperating system 64bits: {is64Bit}");
            //Console.WriteLine($"The processor count is: {processorCount}");
            //Console.WriteLine($"The username of this pc is: {userName}");
            //Console.ReadLine();

            //Deel2
            Console.Write("Give a number for a drive between 1-3");
            int bytesInput = Convert.ToInt32(Console.ReadLine())-1;
            Console.Write("Give a number for size drive between1-3");
            int sizeInput = Convert.ToInt32(Console.ReadLine()) -1;

            long cDriveInBytes = DriveInfo.GetDrives()[bytesInput].AvailableFreeSpace;
            long totalSize = DriveInfo.GetDrives()[sizeInput].TotalSize;
            Console.WriteLine(totalSize);
            Console.WriteLine(cDriveInBytes);
        }
    }
}
