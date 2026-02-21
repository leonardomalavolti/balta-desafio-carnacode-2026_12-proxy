namespace DesignPatternChallenge.Models;

public class User
{
    public string Username { get; }
    public int ClearanceLevel { get; }

    public User(string username, int clearanceLevel)
    {
        Username = username;
        ClearanceLevel = clearanceLevel;
    }
}