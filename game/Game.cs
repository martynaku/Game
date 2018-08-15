using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Game
    {
        public static void Main()
        {

            Map map = new Map(8, 5);

            try
            {

                Path path = new Path(
                    new[] {

                        new MapLocation(0,2, map),
                        new MapLocation(1,2, map),
                        new MapLocation(2,2, map),
                        new MapLocation(3,2, map),
                        new MapLocation(4,2, map),
                        new MapLocation(5,2, map),
                        new MapLocation(6,2, map),
                        new MapLocation(7,2, map),
                    }
               );

                IInvader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)
                };

                Tower[] tower =
                {
                    new Tower(new MapLocation(1,3,map)),
                    new Tower(new MapLocation(3,3,map)),
                    new Tower(new MapLocation(5,3,map))
                };
                Level level = new Level(invaders)
                {
                    Towers = tower
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));

                //level.Towers = towers; dont need it because we included it in a level constructor above

                //Invader invader = new Invader();
                //MapLocation location = new MapLocation(0, 0, map);


                //invader.Location = location; not needed the set field is set as private 

                //MapLocation location = path.GetLocationAt(0);

                //if (location != null)
                //{
                //    Console.WriteLine(location.X + "," + location.Y);
                //}
            }

            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exceptions)
            {
                Console.WriteLine("Unhandled Exception");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);

            }

            //MapLocation x = new MapLocation (4, 2);

            //Point p = x;

            //map.OnMap(new MapLocation(0, 0));

            //Console.WriteLine(x.DistanceTo(5, 5));

            //Console.WriteLine(x is MapLocation);
            //Console.WriteLine(x is Point);

            //Point point = new Point(0, 0);
            //Console.WriteLine(point is MapLocation);

            //bool isOnMap = map.OnMap(point);

            //Console.WriteLine(isOnMap);

            //point = new Point(8, 5);
            //isOnMap = map.OnMap(point);

            //Console.WriteLine(isOnMap);



        }
    }
}
