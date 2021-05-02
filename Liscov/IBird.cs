namespace Liscov
{
    public interface IBird
    {
        public string Name { get; }
        void Eat();
    }

    public interface IFlyingBird : IBird
    {
        void Fly();
        void SetName(string Name);
    }

    public interface IWalkingBird : IBird
    {
        void Walk();
        void SetName(string Name);
    }
}
