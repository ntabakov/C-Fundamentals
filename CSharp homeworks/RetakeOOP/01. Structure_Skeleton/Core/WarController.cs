using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
    {
        private List<Item> itemPool;
        private List<Character> characterParty;
		public WarController()
        {
            itemPool = new List<Item>();
			characterParty = new List<Character>();
        }

		public string JoinParty(string[] args)
        {
            string characterType = args[0];
            string name = args[1];
            Character character;

            switch (characterType)
            {
				case "Warrior":
					character = new Warrior(name);
                    break;
				case "Priest":
					character = new Priest(name);
                    break;
				default:
					throw new ArgumentException(String.Format(ExceptionMessages.InvalidCharacterType,characterType));

            }
			characterParty.Add(character);
            return $"{name} joined the party!";

        }

		public string AddItemToPool(string[] args)
        {
            string itemType = args[0];
            Item item;

            switch (itemType)
            {
				case "FirePotion":
					item = new FirePotion();
                    break;

				case "HealthPotion":
					item = new HealthPotion();
                    break;
				default:
					throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem,itemType));

			}
			itemPool.Add(item);
            return $"{itemType} added to pool.";

        }

		public string PickUpItem(string[] args)
        {
            string characterName = args[0];
            Character currCharacter = characterParty.FirstOrDefault(x => x.Name == characterName);
            if (currCharacter == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty,characterName));
            }

            if (itemPool.Count == 0)
            {
				throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }

            int index = itemPool.Count - 1;
            Item lastItem = itemPool[index];
			currCharacter.Bag.AddItem(lastItem);
			itemPool.RemoveAt(index);

            return $"{characterName} picked up {lastItem.GetType().Name}!";

        }

		public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemType = args[1];

            Character currCharacter = characterParty.FirstOrDefault(x => x.Name == characterName);
            if (currCharacter == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty,characterName));
            }

            Item wantedItem = currCharacter.Bag.GetItem(itemType);
            currCharacter.UseItem(wantedItem);

            return $"{characterName} used {itemType}.";
        }

		public string GetStats()
        {
            StringBuilder sb = new StringBuilder();

            var sortedCharacter = characterParty.OrderByDescending(x => x.IsAlive).ThenByDescending(x => x.Health);
            foreach (var character in sortedCharacter)
            {
                string status = "Alive";
                if (character.IsAlive == false)
                {
                    status = "Dead";
                }
                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {status}");
            }

            return sb.ToString().Trim();
        }

		public string Attack(string[] args)
        {
            string attackerName = args[0];
            string receiverName = args[1];

            Character attacker = characterParty.FirstOrDefault(x => x.Name == attackerName);
            Character receiver = characterParty.FirstOrDefault(x => x.Name == receiverName);

            if (attacker == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty,attackerName));
            }
            if (receiver == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, receiverName));
            }

            if (attacker.GetType().Name != "Warrior")
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AttackFail,attackerName));
            }
            ((Warrior)attacker).Attack(receiver);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (receiver.IsAlive == false)
            {
                sb.AppendLine($"{receiver.Name} is dead!");
            }

            return sb.ToString().Trim();

        }

		public string Heal(string[] args)
        {
            string healerName = args[0];
            string healerReceiverName = args[1];

            Character healer = characterParty.FirstOrDefault(x => x.Name == healerName);
            Character receiver = characterParty.FirstOrDefault(x => x.Name == healerReceiverName);

            if (healer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty,healerName));
            }

            if (receiver == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty,healerReceiverName));
            }

            if (healer.GetType().Name != "Priest")
            {
                throw new ArgumentException(String.Format(ExceptionMessages.HealerCannotHeal,healerName));
            }

            ((Priest)healer).Heal(receiver);

            return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";


        }
	}
}
