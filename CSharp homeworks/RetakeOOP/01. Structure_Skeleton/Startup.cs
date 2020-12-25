using System;
using System.IO;
using WarCroft.Core;
using WarCroft.Core.IO;
using WarCroft.Core.IO.Contracts;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory.Models;
using WarCroft.Entities.Items;

namespace WarCroft
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Item item = new FirePotion();
            //Item item2 = new HealthPotion();
            //Character ch = new Character("Ivan",100,10,200,new Backpack());
            //ch.TakeDamage(50);
            //ch.UseItem(item2);
            //ch.UseItem(item);
            //ch.UseItem(item);
            //ch.UseItem(item);
            //ch.UseItem(item);
            //ch.UseItem(item);



            IReader reader = new ConsoleReader();
            //IWriter writer = new ConsoleWriter();

            string pathFile = Path.Combine("..", "..", "..", "output.txt");
            File.Create(pathFile).Close();
            IWriter writer = new FileWriter(pathFile);


            var engine = new Engine(reader, writer);
            engine.Run();

            /* Use the below configuration instead of the usual one if you wish to print all output messages together after the inputs for easier comparison with the example output. */





            //    IReader reader = new ConsoleReader();
            //    var sbWriter = new StringBuilderWriter();

            //    var engine = new Engine(reader, sbWriter);
            //    engine.Run();

            //    Console.WriteLine(sbWriter.sb.ToString().Trim());
            //}
        }
    }
}