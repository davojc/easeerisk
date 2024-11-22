﻿using System.Text.Json.Serialization;
using SurrealDb.Net.Models;

namespace EaseeRisk.Model;

public class RiskIndicator : Record
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("guidance")]
    public required string Guidance { get; set; }
}

public class RiskMititgation : Record
{
    [JsonPropertyName("description")]
    public required string Description { get; set; }
}


