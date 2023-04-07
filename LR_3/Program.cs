using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: Program.exe <file_name>");
            return;
        }

        string fileName = args[0];

        try
        {
            // Читання вмісту вхідного файлу
            string content = File.ReadAllText(fileName);

            // Виконання операцій з файлом (наприклад, операції з #include директивами)
            string result = PerformFileOperations(content);

            // Збереження результату у вихідний файл з розширенням ".tmp"
            string resultFileName = Path.ChangeExtension(fileName, ".tmp");
            File.WriteAllText(resultFileName, result);

            Console.WriteLine("File operations completed successfully.");
            Console.WriteLine("Result saved to: " + resultFileName);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: File not found - {ex.FileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static string PerformFileOperations(string content)
    {
        // Виконання операцій з файлом
        // Наприклад, опрацювання #include директив

        // Повернення результату операцій
        return content.ToUpper();
    }
}