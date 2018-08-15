using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Tower
    {
        protected virtual int Range { get;  } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSucessfulShot()
        {
            return Random.NextDouble() < Accuracy;
        }
        public void FireOnInvaders(IInvader[] invaders)
        {
            //int index = 0; // declare index as an integer and initialize it to 0

            //while (index < FireOnInvaders.Length) //check to see if we’ve looped through all the indexes of the array.
            //{
            //    Invader invader = invaders[index]; //we do something with each of the array items
            //    // do stuff wth invader

            //    index ++; //increment index so that the next time through the loop we're getting the next item in the array.
            //}

            //for(int i = 0; i < invaders.Length; i++)
            //{
            //    Invader invader = invaders[i];
            //    // do stuff wth invader
            //}

            foreach(IInvader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf (invader.Location, Range))
                {
                    if(IsSucessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missedan invader!");
                    }

                    break;
                }
            }
        }
    }
}
