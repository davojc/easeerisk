using SurrealDb.Net.Models;

namespace EaseeRisk.Store;

[Table("riskindicatorgroup")]
public class RiskIndicatorGroup : Record
{
    public required string Name { get; set; }
}