using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    abstract class Invader : IInvader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public abstract int Health { get; protected set;  }

        public bool HasScored {get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);



    public Invader(Path path) //constructor
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor) //virtual meants that sub classes can have a different implementation of this method
        {
        
                Health -= factor;
                Console.WriteLine("Shot at and hit an invader!");

        }



        //private MapLocation _location;

        //public MapLocation GetLocation()
        //{
        //    return _location;

        //}

        //public void SetLocation(MapLocation value)
        //{
        //    _location = value;
        //}

        //public MapLocation Location /*{ get; private set;}// shorter verstion for get set propperty*/
        //{
        //    get
        //    {
        //        return _path.GetLocationAt(_pathStep);

        //    }
        //} using sntatic method symplyfied to public MapLocation Location => _path.GetLocationAt(_pathStep); repeated code

        






        //public void move()
        //{
        //    _pathStep += 1;
        //} symplyfied to the line above

        //public MapLocation Location //property
        //{
        //    get
        //    {
        //        return _location;
        //    }
        //    set
        //    {
        //        _location = value;
        //    }
        //}
    }
}
