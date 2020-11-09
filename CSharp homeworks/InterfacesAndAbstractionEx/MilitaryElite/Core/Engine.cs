using MilitaryElite.Contracts;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private List<ISoldier> army;

        public Engine()
        {
            army = new List<ISoldier>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();

                string type = commandArgs[0];
                string id = commandArgs[1];
                string firstName = commandArgs[2];
                string lastName = commandArgs[3];
                decimal salary = decimal.Parse(commandArgs[4]);

                if (type == "Private")
                {
                    Private privateToAdd = new Private(id, firstName, lastName, salary);

                    this.army.Add(privateToAdd);
                }
                else if (type == "LieutenantGeneral")
                {
                    LieutenantGeneral lieutenantGeneralToAdd = new LieutenantGeneral(id, firstName, lastName, salary);

                    string[] ids = commandArgs
                        .Skip(5)
                        .ToArray();

                    foreach (string privateId in ids)
                    {
                        ISoldier currentPrivate = this.army.First(p => p.Id == privateId);

                        lieutenantGeneralToAdd.AddPrivate(currentPrivate);
                    }

                    this.army.Add(lieutenantGeneralToAdd);
                }
                else if (type == "Engineer")
                {
                    string corps = commandArgs[5];
                    try
                    {
                        Engineer engineerToAdd = new Engineer(id, firstName, lastName, salary, corps);

                        string[] repairs = commandArgs
                            .Skip(6)
                            .ToArray();

                        for (int i = 0; i < repairs.Length; i += 2)
                        {
                            string repairPart = repairs[i];
                            int repairHours = int.Parse(repairs[i + 1]);

                            Repair repair = new Repair(repairPart, repairHours);
                            engineerToAdd.AddRepair(repair);
                        }

                        this.army.Add(engineerToAdd);
                    }
                    catch (ArgumentException ae)
                    {
                    }
                }
                else if (type == "Commando")
                {
                    string corps = commandArgs[5];

                    try
                    {
                        Commando commandoToAdd = new Commando(id, firstName, lastName, salary, corps);

                        string[] missions = commandArgs
                            .Skip(6)
                            .ToArray();

                        for (int i = 0; i < missions.Length; i += 2)
                        {
                            string missionCodeName = missions[i];
                            string missionState = missions[i + 1];

                            try
                            {
                                Mission mission = new Mission(missionCodeName, missionState);
                                commandoToAdd.AddMission(mission);
                            }
                            catch (ArgumentException ae)
                            {

                            }
                        }

                        this.army.Add(commandoToAdd);
                    }
                    catch (ArgumentException ae)
                    {
                    }
                }
                else if (type == "Spy")
                {
                    int codeNumber = (int)salary;

                    Spy spyToAdd = new Spy(id, firstName, lastName, codeNumber);

                    this.army.Add(spyToAdd);
                }

                command = Console.ReadLine();
            }

            foreach (var soldier in this.army)
            {
                //Type type = soldier.GetType();

                //Object obj = Convert.ChangeType(soldier, type);

                Console.WriteLine(soldier.ToString());
            }
        }
    }
}
