using DesignPatternChallenge.Models;
using DesignPatternChallenge.Proxy;

Console.WriteLine("=== Sistema com Proxy ===\n");

var proxy = new DocumentRepositoryProxy();

var manager = new User("joao.silva", 5);
var employee = new User("maria.santos", 2);

proxy.GetDocument("DOC002", manager);
proxy.GetDocument("DOC002", employee);
proxy.GetDocument("DOC002", manager);

proxy.ShowAuditLog();

Console.WriteLine("\n=== BENEFÍCIOS DO PROXY ===");
Console.WriteLine("✔ Controle de acesso centralizado");
Console.WriteLine("✔ Cache transparente");
Console.WriteLine("✔ Auditoria desacoplada");
Console.WriteLine("✔ Lazy loading");
Console.WriteLine("✔ Código limpo e extensível");