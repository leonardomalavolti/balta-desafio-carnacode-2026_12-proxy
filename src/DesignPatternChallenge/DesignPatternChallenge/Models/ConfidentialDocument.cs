namespace DesignPatternChallenge.Models;

public class ConfidentialDocument
{
    public string Id { get; }
    public string Title { get; }
    public string Content { get; set; }
    public int SecurityLevel { get; }
    public long SizeInBytes { get; }

    public ConfidentialDocument(string id, string title, string content, int securityLevel)
    {
        Id = id;
        Title = title;
        Content = content;
        SecurityLevel = securityLevel;
        SizeInBytes = content.Length * 2;
    }
}
