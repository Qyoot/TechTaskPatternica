using System;
using System.Text.Json;

namespace TechTaskPatternica
{
    class Program
    {
        static void Main(string[] args)
        {
            Analytics analytics = new Analytics(Deserialize.GetCatalog().CD);
            Data data = analytics.GetData();

            string serialzie = JsonSerializer.Serialize(data);

            Console.WriteLine(serialzie);
            Console.ReadLine();
        }
    }
}
