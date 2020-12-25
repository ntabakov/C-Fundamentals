using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Inventory.Models;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		// TODO: Implement the rest of the class.
        private string name;
        //private double baseHealth;
        private double health;
        //private double baseArmor;
        //private double armor;

       
        protected Character(string name , double health,double armor, double abilityPoints,Bag bag)
            
        {
            this.BaseHealth = health;
            this.BaseArmor = armor;
            this.Name = name;
            //this.Health = health;
            //this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Health = BaseHealth;
            this.Armor = BaseArmor;
        }


        public string Name
        {
            get
            {
                return this.name;

            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }

                this.name = value;
            }
        }
        //TODO: If wrong tests, add IF < 0 
        public double BaseHealth { get; }
        //TODO: Might be wrong !
        public double Health
        {
            get
            {
                return this.health;
            }
            protected internal set
            {
                if (value> BaseHealth)
                {
                    this.health = BaseHealth;
                }
                else if (value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
                
            }
        }
        public double BaseArmor { get; }

        public double Armor { get; private set; }

        public double AbilityPoints { get; }
        public Bag Bag { get; }
		public bool IsAlive { get; set; } = true;

		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}

        public void TakeDamage(double hitPoints)
        {
            double currArmor = this.Armor;
            EnsureAlive();
            if (currArmor > 0)
            {
                currArmor -= hitPoints;
                this.Armor -= hitPoints;
                if (currArmor < 0)
                {
                    currArmor = Math.Abs(currArmor);
                    this.Health -= currArmor;
                    this.Armor = 0;
                }
            }
            else
            {
                this.Health -= hitPoints;
            }

            if (this.Health <= 0)
            {
                this.IsAlive = false;
                this.Health = 0;
            }
        }

        public void UseItem(Item item)
        {
            EnsureAlive();
            item.AffectCharacter(this);
        }

    }
}