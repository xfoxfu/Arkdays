using System;
using System.IO;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;

namespace Noha.Arkdays.Services
{
    public class TableHolder<T> : ITableHolder<T>
    {
        private readonly T _Value;

        public T Value => _Value;

        public TableHolder(string json)
        {
            _Value = JsonSerializer.Deserialize<T>(json);
        }

        public TableHolder(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                _Value = JsonSerializer.Deserialize<T>(reader.ReadToEnd());
            }
        }
    }

    public static class TableHolderExtension
    {
        public static void AddTableHolder<T>(this IServiceCollection services, string filename)
        {
            Console.WriteLine("current at {0}", Environment.CurrentDirectory);
            Console.WriteLine("opening {0}", filename);
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                services.AddSingleton<ITableHolder<T>>(new TableHolder<T>(stream));
            }
        }
    }
}