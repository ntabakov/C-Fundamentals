using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_');

                string type = input[0];
                string name = input[1];

                Song tempSong = new Song();

                tempSong.TypeList = type;
                tempSong.Name = name;
                
                songs.Add(tempSong);
            }
            string command = Console.ReadLine();

            if (command == "all")
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine(songs[i].Name);
                }     
            }
            else
            {
                for (int i = 0; i < songs.Count; i++)
                {
                   if(command == songs[i].TypeList)
                    {
                        Console.WriteLine(songs[i].Name);
                    }
                }
            }
        }

        public class Song
        {
            public string TypeList;
            public string Name;
        }
    }
}
