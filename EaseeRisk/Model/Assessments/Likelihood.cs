namespace EaseeRisk.Model.Assessments;

public enum Likelihood : byte
{
    [Definition("Very unlikely to happen (e.g. less than once every 10 years).")]
    Rare = 1,
    [Definition("Could happen, but not expected (e.g. once in 5-10 years).")]
    Unlikely = 2,
    [Definition("Might happen occasionally (e.g. once in 1-5 years).")]
    Possible = 3,
    [Definition("Expected to happen in most circumstances (e.g. once a year or more).")]
    Likely = 4,
    [Definition("Will occur frequently (e.g. multiple times a year).")]
    AlmostCertain = 5
}