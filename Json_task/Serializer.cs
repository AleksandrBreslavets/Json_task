using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Json_task
{
    class Serializer
    {
        public static void SerializeData(string path, List<Book> data, JsonSerializerOptions options)
        {
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize(fstream, data, options);
                Console.WriteLine(@"Записано у файл: ");
                Console.WriteLine(JsonSerializer.Serialize(data, options));
            }
        }
    }
}
