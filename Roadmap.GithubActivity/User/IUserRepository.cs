namespace Roadmap.GithubActivity.User
{
    public interface IUserRepository
    {
        string GetUserActivity(string username);
    }
}