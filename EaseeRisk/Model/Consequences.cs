namespace EaseeRisk.Model;

public enum Consequences : byte
{
    [Definition("No injury or minor first aid needed; no disruption to operations.")]
    Insignificant = 1,
    [Definition("Minor injury requiring first aid; minimal impact on operations.")]
    Minor = 2,
    [Definition("Significant injury requiring medical treatment; moderate operational impact.")]
    Moderate = 3,
    [Definition("Severe injury or illness; significant operational disruption or regulatory action.")]
    Major = 4,
    [Definition("Death or multiple severe injuries; major operational shutdown, legal repercussions.")]
    Catastrophic = 5
}