using System;
using System.IO;
using OnlineShop.Core;
using OnlineShop.IO;
using OnlineShop.Models;
using OnlineShop.Models.Products.Components.Models;

namespace OnlineShop
{
    public class StartUp
    {
        static void Main()
        {
            // Clears output.txt file
            string pathFile = Path.Combine("..", "..", "..", "output.txt");
            File.Create(pathFile).Close();

            IReader reader = new ConsoleReader();
            //IWriter writer = new ConsoleWriter();
            IWriter writer = new FileWriter(pathFile);

            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IController controller = new Controller();

            IEngine engine = new Engine(reader, writer, commandInterpreter, controller);
            engine.Run();
            //Product pr = new CentralProcessingUnit(12,"asd","asdd",123,50,30);
            //Console.WriteLine(pr);
        }
    }
}
