namespace EaseeRisk.Model;

public interface IRiskLevel
{
    string Title { get; set; }

    string Color { get; set; }

    RiskLevelBoundary? Boundary { get; set; }
}