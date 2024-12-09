namespace EaseeRisk.Model;

public interface IRiskLevelSet : IRecord
{
    string Name { get; set; }

    IList<IRiskLevel> Levels { get; }
}