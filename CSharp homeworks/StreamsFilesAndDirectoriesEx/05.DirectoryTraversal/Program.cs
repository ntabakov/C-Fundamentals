﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo dirInfo = new DirectoryInfo("../../../");
            FileInfo[] files = dirInfo.GetFiles();

            foreach (var item in files)
            {
                if (!fileInfo.ContainsKey(item.Extension))
                {
                    fileInfo.Add(item.Extension, new Dictionary<string, double>());
                }
                fileInfo[item.Extension].Add(item.Name, item.Length / 1024.00);
            }

            using (StreamWriter writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/report.txt"))
            {
                foreach (var item in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(c => c.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var file in item.Value.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value:f3}kb");
                    }
                }
            }

            //foreach (var item in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(c => c.Key))
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var file in item.Value.OrderByDescending(x=>x.Value))
            //    {
            //        Console.WriteLine($"--{file.Key} - {file.Value:f3}kb");
            //    }
            //}
                
        }
    }
}
