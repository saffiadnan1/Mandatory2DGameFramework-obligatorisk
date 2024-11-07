namespace Mandatory2DGameFramework.model.defence
{
    public interface IDefenceObject
    {
        int DefencePoint { get; }
        int Durability { get; }
        bool IsEquipped { get; }
        string Name { get; }
        int Weight { get; }
    }
}