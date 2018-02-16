using System;
using System.IO;

namespace NamesChangerProject
{
    internal class NameChangerCoordinator
    {
        internal void Coordinate(String folderPath, String fileName)
        {
            FileInfo[] fileList = new DirectoryInfo(folderPath).GetFiles(fileName, SearchOption.AllDirectories);

            foreach (FileInfo file in fileList)
            {
                String papaPath = file.Directory.FullName;
                String papaName = file.Directory.Name;
                System.IO.File.Move(file.FullName, papaPath+"\\"+papaName + file.Extension);
            }
        }
    }
}