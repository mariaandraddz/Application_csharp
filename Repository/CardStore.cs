using Application_csharp.Models;
using System.Collections.Concurrent;
namespace Application_csharp.Repository;

public class CardStore
{
    private readonly ConcurrentDictionary<string, VirtualCards> _cards = new()
    {
        ["card-001"] = new VirtualCards { Id = "card-001", CardholderName = "Maria Silva", Balance = 1500.00m, Active = true },
        ["card-002"] = new VirtualCards { Id = "card-002", CardholderName = "João Souza", Balance = 200.50m, Active = true },
        ["card-003"] = new VirtualCards { Id = "card-003", CardholderName = "Ana Costa", Balance = 0m, Active = false },
    };

    public bool TryGet(string id, out VirtualCards? card) => _cards.TryGetValue(id, out card);
}
