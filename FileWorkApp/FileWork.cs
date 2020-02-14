using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWorkApp
{
    
    public class FileWork
    {
        private static string dirPath = AppDomain.CurrentDomain.BaseDirectory + @"Temp";
        public static string Open()
        {
            OpenFileDialog openD = new OpenFileDialog
            {
                Title = "Выберите файл",
                Multiselect = false,
                InitialDirectory = dirPath,
                Filter = "Textfile (*.txt) |*.txt;"
            };

            openD.ShowDialog();

            return File.ReadAllText(openD.FileName);

        }
        public static void Save(string text)
        {
            SaveFileDialog saveD = new SaveFileDialog
            {
                Title = "Выберите папку для сохранения",
                DefaultExt = "txt",
                InitialDirectory = dirPath
            };

            saveD.ShowDialog();

            File.AppendAllText(saveD.FileName, text, Encoding.Default);
        }
    }
        
}
