namespace AuthService.Database
{
    public interface IDatabaseSettings
    {
        string CollectionName {get; set;}
        string connectionString {get; set;}
        string DatabaseName {get; set;}
    }
}