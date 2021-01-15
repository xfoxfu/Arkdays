namespace Noha.Arkdays.Services
{
    public interface IDatabase
    {
        public T Get<T>(string key);
        public void Set<T>(string key, T value);
    }
}
