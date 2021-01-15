using Microsoft.Extensions.DependencyInjection;
using RocksDbSharp;
using System;
using System.Text.Json;

namespace Noha.Arkdays.Services
{
    public class RocksDatabase : IDatabase, IDisposable
    {
        private RocksDb _db { get; init; }

        public RocksDatabase(string path)
        {
            var options = new DbOptions()
                .SetCreateIfMissing(true);
            _db = RocksDb.Open(options, path);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public T Get<T>(string key)
        {
            var ret = JsonSerializer.Deserialize<T>(_db.Get(key));
            if (ret == null)
            {
                throw new Exception("invalid entry in database");
            }
            return ret;
        }

        public void Set<T>(string key, T value)
        {
            _db.Put(key, JsonSerializer.Serialize(value));
        }
    }

    public static class RocksDatabaseExtension
    {
        public static void AddRocksDatabase(this IServiceCollection services, string path)
        {
            services.AddSingleton<IDatabase>(new RocksDatabase(path));
        }
    }
}
