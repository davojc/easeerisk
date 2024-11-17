namespace EaseeRisk.Model;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
public class DefinitionAttribute(string definition) : Attribute
{
    public string Definition { get; } = definition;
}