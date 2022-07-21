using System.Linq;

var videoGames = new List<string>() {"Elden ring", "ESO", "Rage"};
videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));



