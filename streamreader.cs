using System;
using System.IO;

namespace streamreader
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"E:\testfile.txt"; //location of the file to read

            using (StreamReader reader = File.OpenText(path))
            {
                String str = "";

                while ((str = reader.ReadLine()) != null)
                {
                    Console.WriteLine(str);//Read the contents of the file and prints in console
                }
            }
            Console.ReadLine();
        }
    }
    }
