using System;
using System.IO;

namespace Lab_3__Balmes_Gonda_Rivera_StaTeresa
{
    public class Diary
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "diary.txt");

        public void WriteEntry(string text)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                string entry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {text}";
                sw.WriteLine(entry);
            }
        }

        public void ViewAllEntries()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No diary entries found.");
            }
        }

        public void SearchByDate(string date)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                bool found = false;
                foreach (var line in lines)
                {
                    if (line.StartsWith(date))
                    {
                        Console.WriteLine(line);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No entries found for that date.");
                }
            }
            else
            {
                Console.WriteLine("No diary entries found.");
            }
        }
    }
}