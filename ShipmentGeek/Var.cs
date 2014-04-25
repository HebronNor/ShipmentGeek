﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ShipmentGeek
{
    class Var
    {
        public static string DateTimeStr = DateTime.Now.ToString("yy-MM-dd_HH-mm-ss");

        public class AssemblyInfo
        {
            public static string Name = Assembly.GetEntryAssembly().GetName().Name;
            public static Version Version = Assembly.GetEntryAssembly().GetName().Version;
            public static string VersionText = string.Format(@"{0}.{1}.{2} (r{3})", Version.Major, Version.Minor, Version.Build, Version.Revision);
        }

        public class FolderInfo
        {
            public static string Work = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            public static string Documents = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            public static string Backup = Work + "\\Backup";
        }

        public class FileInfo
        {
            public static string ShipmentFile = FolderInfo.Work + "\\" + AssemblyInfo.Name + ".xml";
        }
    }
}