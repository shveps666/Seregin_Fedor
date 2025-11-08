using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5
{
    public class Settings
    {
        private static readonly string ConfigFilePath;
        static Settings()
        {
            ConfigFilePath = "C:\\Users\\AppData";
        }

        public static void ShowConfigPath()
        {
            Console.WriteLine($"Путь к файлу: {ConfigFilePath}");
        }
    }
    class Program
    {
        static void Main()
        {
            Settings.ShowConfigPath();
        }
    }
}
