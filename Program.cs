using System;
using Lab_3__Balmes_Gonda_Rivera_StaTeresa;

namespace Lab_3__Balmes_Gonda_Rivera_StaTeresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            int choice;

            do
            {
                Console.WriteLine("\n       ~~~~~ | MY DIARY | ~~~~~\n");
                Console.WriteLine("1. Write a New Entry");
                Console.WriteLine("2. View All Entries");
                Console.WriteLine("3. Search Entry by Date (YYYY-MM-DD)");
                Console.WriteLine("4. Exit\n");
                Console.Write("Choose an option: ");
                
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter your diary entry: ");
                            string text = Console.ReadLine();
                            diary.WriteEntry(text);
                            break;
                        case 2:
                            diary.ViewAllEntries();
                            break;
                        case 3:
                            Console.Write("Enter date to search (YYYY-MM-DD): ");
                            string date = Console.ReadLine();
                            diary.SearchByDate(date);
                            break;
                        case 4:
                            Console.WriteLine("Exiting diary. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                }
            } while (choice != 4);
        }
    }
}