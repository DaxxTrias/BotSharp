namespace BotSharp.Abstraction.Functions.Models;

public class FunctionDef
{
    public string Name { get; set; }
    public string Description { get; set; }

    [JsonPropertyName("visibility_expression")]
    public string? VisibilityExpression { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Impact { get; set; }

    public FunctionParametersDef Parameters { get; set; } = new FunctionParametersDef();

    public override string ToString()
    {
        return $"{Name}: {Description}";
    }
}
