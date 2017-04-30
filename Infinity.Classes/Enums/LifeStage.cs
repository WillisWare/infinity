namespace Infinity.Classes.Enums
{
    /// <summary>
    /// Stage of life for classes implementing ILife. Values represent months.
    /// </summary>
    public enum LifeStage
    {
        Unknown = 0,
        Embryo = 2,
        Fetus = 6,
        Infant = 10,
        Toddler = 36,
        Adolescent = 144,
        Adult = 240,
        Elderly = 720,
        Ancient = 1200
    }
}
