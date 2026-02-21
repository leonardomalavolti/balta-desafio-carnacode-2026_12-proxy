using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Interfaces;

public interface IDocumentRepository
{
    ConfidentialDocument GetDocument(string documentId);
    void UpdateDocument(string documentId, string newContent);
}
