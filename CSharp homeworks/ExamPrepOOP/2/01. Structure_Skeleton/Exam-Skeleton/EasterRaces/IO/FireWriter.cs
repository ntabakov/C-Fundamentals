using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EasterRaces.IO.Contracts;

namespace EasterRaces.IO
{
    public class FilerWriter : IWriter
    {
        private readonly string filePath;

        public FilerWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(this.filePath, text + Environment.NewLine);
        }

        public void Write(string text)
        {
            File.AppendAllText(this.filePath, text);
        }
    }
}
