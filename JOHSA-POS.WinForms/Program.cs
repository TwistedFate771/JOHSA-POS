
using System;
using System.IO;
using System.Windows.Forms;

namespace JOHSA_POS.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string dataFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "EnterprisePOS",
                "Data"
            );

            string sourceFolder = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Database"
            );

            Directory.CreateDirectory(dataFolder);

            string databaseFile = Path.Combine(dataFolder, "sacares_LocalDB.mdf");
            string logFile = Path.Combine(dataFolder, "sacares_LocalDB_log.ldf");

            if (!File.Exists(databaseFile))
            {
                File.Copy(
                    Path.Combine(sourceFolder, "sacares_LocalDB.mdf"),
                    databaseFile
                );
            }

            if (!File.Exists(logFile))
            {
                File.Copy(
                    Path.Combine(sourceFolder, "sacares_LocalDB_log.ldf"),
                    logFile
                );
            }

            AppDomain.CurrentDomain.SetData("DataDirectory", dataFolder);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
