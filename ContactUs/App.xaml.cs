using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ContactUs
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string db_name = "ContactUs.db";
        public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string db_path = System.IO.Path.Combine(folderPath, db_name);
    }
}
