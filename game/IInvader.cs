namespace game
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        void Move();
    }
    interface IInvader : IMappable, IMovable
    {
        bool HasScored { get; }
        int Health { get; }
        bool IsActive { get; }
        bool IsNeutralized { get; }
        void DecreaseHealth(int factor);

    }
}