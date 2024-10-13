namespace Roadmap.GithubActivity.User
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        public string GetUserActivity(string username)
        {
            var client = new HttpClient();
            return "hello";
        }
    }
}