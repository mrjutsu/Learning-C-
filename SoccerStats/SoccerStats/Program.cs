using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

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

            fileName = Path.Combine(directory.FullName, "players.json");
            var players = DeserializePlayers(fileName);

            //foreach (var player in players)
            //{
            //    Console.WriteLine(player.FirstName);
            //}

            //var topTenPlayers = GetTopTenPlayers(players);
            //foreach (var player in topTenPlayers)
            //{
            //    Console.WriteLine("Name: " + player.FirstName + " PPG: " + player.PointsPerGame);
            //}

            //var topTenPlayers = GetTopTenPlayers(players);
            //foreach (var player in topTenPlayers)
            //{
            //    List<NewsResult> newsResults = GetNewsForPlayer(string.Format("{0} {1}", player.FirstName, player.SecondName));
            //    foreach (var result in newsResults)
            //    {
            //        Console.WriteLine(string.Format("Date: {0:f}, Headline: {1}, Summary: {2} \r\n", result.DatePublished, result.Headline, result.Summary));
            //        Console.ReadKey();
            //    }
            //}

            //fileName = Path.Combine(directory.FullName, "topten.json");
            //SerializePlayersToFile(topTenPlayers, fileName);

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

            //Console.WriteLine(GetGoogleHomePage());
            //Console.WriteLine(GetNewsForPlayer("Dieog Valeri"));
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<GameResult> ReadSoccerResults(string fileName)
        {
            var SoccerResults = new List<GameResult>();

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
                    gameResult.TeamName = values[1];
                    HomeOrAway homeOrAway;
                    if (Enum.TryParse(values[2], out homeOrAway))
                    {
                        gameResult.HomeOrAway = homeOrAway;
                    }
                    int parseInt;
                    if (int.TryParse(values[3], out parseInt))
                    {
                        gameResult.Goals = parseInt;
                    }
                    if (int.TryParse(values[4], out parseInt))
                    {
                        gameResult.GoalAttempts = parseInt;
                    }
                    if (int.TryParse(values[5], out parseInt))
                    {
                        gameResult.ShotsOnGoal = parseInt;
                    }
                    if (int.TryParse(values[6], out parseInt))
                    {
                        gameResult.ShotsOffGoal = parseInt;
                    }
                    double possessionPercent;
                    if (double.TryParse(values[7], out possessionPercent))
                    {
                        gameResult.PossessionPercent = possessionPercent;
                    }
                    SoccerResults.Add(gameResult);
                }
                //Peek returns the index of the next line, if -1 there's no more lines
                //while (reader.Peek() > -1){
                //    string[] line = reader.ReadLine().Split(',');
                //    SoccerResults.Add(line);
                //}
            }

            return SoccerResults;
        }

        public static List<Player> DeserializePlayers(string fileName)
        {
            var players = new List<Player>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileName))
            using (var jsonReader = new JsonTextReader(reader))
            {
                players = serializer.Deserialize<List<Player>>(jsonReader);
            }
            return players;
        }

        public static List<Player> GetTopTenPlayers(List<Player> players)
        {
            var topTenPlayers = new List<Player>();
            players.Sort(new PlayerComparer());
            int counter = 0;
            foreach (var player in players)
            {
                topTenPlayers.Add(player);
                counter++;
                if (counter == 10)
                {
                    break;
                }
            }
            return topTenPlayers;
        }

        public static void SerializePlayersToFile(List<Player> players, string fileName)
        {
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, players);
            }
        }

        public static string GetGoogleHomePage()
        {
            var webClient = new WebClient();
            byte[] googleHome = webClient.DownloadData("https://www.google.com");

            //Stream stream = new Stream();

            using (var stream = new MemoryStream(googleHome))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<NewsResult> GetNewsForPlayer(string playerName)
        {
            var results = new List<NewsResult>();

            var webClient = new WebClient();
            webClient.Headers.Add("Header-Name", "Header-Value");
            byte[] searchResults = webClient.DownloadData(string.Format("the/url/to/search?q={0}", playerName));
            //byte[] searchResults = webClient.DownloadData("the/search/url");

            //Stream stream = new Stream();

            var serializer = new JsonSerializer();

            using (var stream = new MemoryStream(searchResults))
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                results = serializer.Deserialize<NewsSearch>(jsonReader).NewsResult;
                //return reader.ReadToEnd();
            }
            return results;
        }
    }
}
