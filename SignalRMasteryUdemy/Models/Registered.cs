// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System;
using System.Text.Json.Serialization;

public class Registered
{
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("age")]
    public int Age { get; set; }
}