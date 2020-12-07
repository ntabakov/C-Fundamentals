using System;
using System.Collections.Generic;
using System.Text;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;
        public Player(string username,int health,int armor,IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                //TODO: If wrong test, add IF for Null or empty!
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }

                this.username = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            } private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }

                this.health = value;
            }
        }

        public int Armor
        {
            get
            {
                return this.armor;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }

                this.armor = value;
            }
        }

        public IGun Gun
        {
            get
            {
                return this.gun;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunName);
                }

                this.gun = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return this.health > 0;
            }
           
        }
        public void TakeDamage(int points)
        {
            int damage = 0;
            if (this.Armor - points <= 0)
            {
                //TODO: If wrong test, set IsAlive to False!
                damage = points - this.Armor;
                this.Armor = 0;
                if (this.Health - damage <= 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.Health -= damage;
                }
            }
            else
            {
                this.Armor -= points;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}: {this.username}");
            sb.AppendLine($"--Health: {this.health}");
            sb.AppendLine($"--Armor: {this.armor}");
            sb.AppendLine($"--Gun: {gun.Name}");

            return sb.ToString().TrimEnd();
        }
    }
}
