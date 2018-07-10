using System;
using System.Collections.Generic;
using System.IO;

namespace SoccerStats
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            //var files = directory.GetFiles("*.txt");
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file.Name);
            //}

            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            var fileContents = ReadSoccerResults(fileName);

            //var fileContents = ReadFile(fileName);
            //string[] fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var line in fileLines)
            //{
            //    Console.WriteLine(line);
            //}

            //Console.WriteLine(fileContents);
            //var file = new FileInfo(filename);
            //if (file.Exists)
            //{
            //    //File will be closed when this reaches the end
            //    using (var reader = new StreamReader(file.FullName))
            //    {
            //        Console.SetIn(reader);
            //        Console.WriteLine(Console.ReadLine());
            //    }
            //    Console.ReadLine();
            //}
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<string[]> ReadSoccerResults(string fileName)
        {
            var SoccerResults = new List<string[]>();

            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    var gameResult = new GameResult();
                    string[] values = line.Split(',');
                    //gameResult.GameDate = DateTime.Parse(values[0]);
                    DateTime gameDate;
                    if (DateTime.TryParse(values[0], out gameDate))
                    {
                        gameResult.GameDate = gameDate;
                    }
                    SoccerResults.Add(values);
                }
                //Peek returns the index of the next line, if -1 there's no more lines
                //while (reader.Peek() > -1){
                //    string[] line = reader.ReadLine().Split(',');
                //    SoccerResults.Add(line);
                //}
            }

            return SoccerResults;
        }
    }
}
