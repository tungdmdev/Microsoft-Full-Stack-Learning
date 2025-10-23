using System.Text.Json.Serialization;

public class WeatherData
{
    public required Location Location { get; set; }
    public required Current Current { get; set; }
}

public class Location
{
    public required string Name { get; set; }
    public required string Country { get; set; }
}

public class Current
{
    [JsonPropertyName("temp_c")]
    public required double Temp_C { get; set; }
    public required Condition Condition { get; set; }
}

public class Condition
{
    public required string Text { get; set; }
    [JsonPropertyName("icon")]
    public required string Icon { get; set; }
}