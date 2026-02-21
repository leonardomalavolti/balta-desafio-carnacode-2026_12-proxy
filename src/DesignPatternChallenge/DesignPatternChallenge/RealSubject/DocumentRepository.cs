using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.RealSubject;

public class DocumentRepository : IDocumentRepository
{
    private readonly Dictionary<string, ConfidentialDocument> _database;

    public DocumentRepository()
    {
        Console.WriteLine("[Repository] Conectando ao banco...");
        Thread.Sleep(1000);

        _database = new Dictionary<string, ConfidentialDocument>
        {
            ["DOC001"] = new("DOC001", "Relatório Financeiro", "Conteúdo...", 3),
            ["DOC002"] = new("DOC002", "Estratégia 2025", "Plano estratégico...", 5),
            ["DOC003"] = new("DOC003", "Manual Interno", "Políticas...", 1)
        };
    }

    public ConfidentialDocument GetDocument(string documentId)
    {
        Console.WriteLine($"[Repository] Buscando {documentId}");
        Thread.Sleep(500);

        return _database.ContainsKey(documentId)
            ? _database[documentId]
            : null;
    }

    public void UpdateDocument(string documentId, string newContent)
    {
        if (_database.ContainsKey(documentId))
            _database[documentId].Content = newContent;
    }
}
