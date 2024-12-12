using AuthService.Models;
using MongoDB.Driver;

namespace AuthService.Services 
{
    public class UserService
    {
        private readonly IMongoCollection<User> users; 
        public UserService(IConfiguration configuration){
            var client = new MongoClient(configuration.GetConnectionString("HyphenDb")); 
            var database = client.GetDatabase("HyphenDb"); 
            users = database.GetCollection<User>("Users"); 
        }
        public List<User> GetUsers() => users.Find(user => true).ToList();
        public User GetUser(string id)
        {
            return users.Find<User>(user => user.Id == id).FirstOrDefault();
        }
        public User Create(User user)
        {
            users.InsertOne(user); 
            return user; 
        }
    }
}