namespace EaseeRisk.Model;

public interface IIndicator : IRecord
{
    string Text { get; set; }

    string Guidance { get; set; }
}