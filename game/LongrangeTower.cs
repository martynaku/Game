using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class LongrangeTower : Tower
    {
        protected override int Range { get; } = 3;
        public LongrangeTower(MapLocation location) : base(location)
        { }
    }
}
