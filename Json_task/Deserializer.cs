using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Json_task
{ 
    class Deserializer
    {
        public static List<Book>? DeserializeData(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream fstream = new FileStream(path, FileMode.Open))
                {
                    try
                    {
                        var books = JsonSerializer.Deserialize<List<Book>>(fstream);
                        return books;
                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine($"Помилка під час десереалізації JSON: {ex.Message}");
                        return null;
                    }
                }
            }
            else
            {
                Console.WriteLine("Файлу не існує.");
                return null;
            }
        }

        public static void ShowDeserializedData(List<Book> data)
        {
            foreach (var book in data)
            {
                Console.WriteLine(
                    $"PublishingHouseId: {book.PublishingHouseId}\n" +
                    $"Title: {book.Title}\n" +
                    $"PublishingHouse:\n" +
                    $"  Id: {book.PublishingHouse.Id}\n"+
                    $"  Name: {book.PublishingHouse.Name}\n"+
                    $"  Adress: {book.PublishingHouse.Adress}\n"
                    );
            }
        }
    }
}
