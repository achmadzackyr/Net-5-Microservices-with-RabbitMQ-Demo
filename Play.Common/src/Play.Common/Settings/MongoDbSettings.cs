namespace Play.Common.Settings
{
    public class MongoDbSettings
    {
        // init is to prevent from changing value after the app run
        public string Host { get; init; }
        public int Port { get; init; }
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}