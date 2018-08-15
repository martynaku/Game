using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class PowerfulTower :Tower
    {
        protected override int Power { get; } = 2;
        public PowerfulTower(MapLocation location) : base(location)
        { }
    }
}
