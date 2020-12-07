using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository guns;
        private PlayerRepository players;
        private IMap map;

        public Controller()
        {
            guns = new GunRepository();
            players = new PlayerRepository();
            map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            IGun currGun = null;
            if (type == "Pistol")
            {
                currGun = new Pistol(name, bulletsCount);
            }
            else if (type == "Rifle")
            {
                currGun = new Rifle(name, bulletsCount);
            }
            else
            {
                //TODO: If wrong test, correct the exception message!
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }
            guns.Add(currGun);
            return String.Format(OutputMessages.SuccessfullyAddedGun, name);
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            if (guns.FindByName(gunName) == null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }

            IPlayer player = null;
            IGun currGun = guns.FindByName(gunName);
            if (type == "Terrorist")
            {
                player = new Terrorist(username,health,armor,currGun);
            }
            else if (type == "CounterTerrorist")
            {
                player = new CounterTerrorist(username, health, armor, currGun);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }
            players.Add(player);

            return String.Format(OutputMessages.SuccessfullyAddedPlayer, username);
        }

        public string StartGame()
        {
            //TODO: It is very possible this is WRONG !
            return map.Start(players.Models.ToList());
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var player in players.Models.OrderBy(x => x.GetType().Name).ThenByDescending(x=>x.Health).ThenBy(x=>x.Username))
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
