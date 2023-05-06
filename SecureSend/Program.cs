﻿using System;
using System.IO;
using System.Security.Cryptography;

namespace SecureTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("You must provide the name of a file to read and the name of a file to write.");
                return;
            }

            var sourceFilename = args[0];
            var destinationFilename = args[1];

            using (var sourceStream = File.OpenRead(sourceFilename))
            using (var destinationStream = File.Create(destinationFilename))
            {
                sourceStream.CopyTo(destinationStream);
            }
        }
    }
}