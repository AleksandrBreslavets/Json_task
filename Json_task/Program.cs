using Json_task;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

static class Program
{
    static public void Main()
    {
        string path = @"C:\Users\Admin\OOP_tasks\Json_task\Json_task\data.json";

        var data = Deserializer.DeserializeData(path);

        if (data != null)
        {
            Deserializer.ShowDeserializedData(data);
        }
        
        /*PublishingHouse publHouse = new PublishingHouse(2, "ГІМНАЗІЯ", "Адреса 1");

        Book book1 = new Book(publHouse.Id, "Алгебра", publHouse);
        Book book2 = new Book(publHouse.Id, "Щоденник нейрохірурга", publHouse);

        List<Book> library= new List<Book>();
        library.Add(book1); 
        library.Add(book2);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };

        Serializer.SerializeData(path, library, options);*/
    }
}
