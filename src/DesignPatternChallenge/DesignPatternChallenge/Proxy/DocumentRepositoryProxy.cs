using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;
using DesignPatternChallenge.RealSubject;

namespace DesignPatternChallenge.Proxy;

public class DocumentRepositoryProxy : IDocumentRepository
{
    private DocumentRepository _repository;
    private readonly Dictionary<string, ConfidentialDocument> _cache = new();
    private readonly List<string> _auditLog = new();

    private DocumentRepository GetRepository()
    {
        if (_repository == null)
        {
            Console.WriteLine("[Proxy] Criando instância real sob demanda (Lazy Loading)");
            _repository = new DocumentRepository();
        }
        return _repository;
    }

    public ConfidentialDocument GetDocument(string documentId)
    {
        throw new NotImplementedException("Use GetDocument(documentId, user)");
    }

    public ConfidentialDocument GetDocument(string documentId, User user)
    {
        Log($"{user.Username} tentando acessar {documentId}");

        if (_cache.ContainsKey(documentId))
        {
            Console.WriteLine("[Proxy] Retornando do cache");
            return Authorize(_cache[documentId], user);
        }

        var document = GetRepository().GetDocument(documentId);

        if (document != null)
            _cache[documentId] = document;

        return Authorize(document, user);
    }

    private ConfidentialDocument Authorize(ConfidentialDocument doc, User user)
    {
        if (doc == null)
            return null;

        if (user.ClearanceLevel < doc.SecurityLevel)
        {
            Log($"ACESSO NEGADO para {user.Username}");
            Console.WriteLine("❌ Acesso negado");
            return null;
        }

        Console.WriteLine("✅ Acesso permitido");
        return doc;
    }

    public void UpdateDocument(string documentId, string newContent)
    {
        GetRepository().UpdateDocument(documentId, newContent);

        if (_cache.ContainsKey(documentId))
            _cache.Remove(documentId);
    }

    private void Log(string message)
    {
        var entry = $"[{DateTime.Now:HH:mm:ss}] {message}";
        _auditLog.Add(entry);
        Console.WriteLine($"[Audit] {entry}");
    }

    public void ShowAuditLog()
    {
        Console.WriteLine("\n=== Auditoria ===");
        foreach (var log in _auditLog)
            Console.WriteLine(log);
    }
}