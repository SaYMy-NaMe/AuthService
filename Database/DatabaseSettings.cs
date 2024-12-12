namespace AuthService.Database
{
    public class DatabaseSettings: IDatabaseSettings
    {
        public string CollectionName {get; set;}
        public string connectionString {get; set;}
        public string DatabaseName {get; set;}
    }
}