using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        public string Start(ICollection<IPlayer> players)
        {
            var terrorists = players.Where(x => x.GetType().Name == "Terrorist");
            var counterTerrorists = players.Where(x => x.GetType().Name == "CounterTerrorist");

            while (true)
            {
                foreach (var T in terrorists.Where(x => x.IsAlive == true))
                {
                    foreach (var CT in counterTerrorists.Where(x=>x.IsAlive==true))
                    {
                        CT.TakeDamage(T.Gun.Fire());
                    }
                }

                if (counterTerrorists.All(x => x.IsAlive == false))
                {
                    return "Terrorist wins!";
                }

                foreach (var CT in counterTerrorists.Where(x => x.IsAlive == true))
                {
                    foreach (var T in terrorists.Where(x => x.IsAlive == true))
                    {
                        T.TakeDamage(CT.Gun.Fire());

                    }
                }

                if (terrorists.All(x => x.IsAlive == false))
                {
                    return "Counter Terrorist wins!";
                }

                
            }
        }
    }
}
