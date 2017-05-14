using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4WormsWorldParty
{
    class WormsWorldParty
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dataNameTeamScore = new Dictionary<string, SortedDictionary<string, int>>();
            
            while (input != "quit")
            {
                var tokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var wormName = tokens[0];
                var teamName = tokens[1];
                var wormScore = int.Parse(tokens[2]);

                foreach (var uniqeName in dataNameTeamScore)
                {
                    if (uniqeName.Value.ContainsKey(wormName))
                    {
                        //input = Console.ReadLine();
                        continue;
                    }
                }

                if (!dataNameTeamScore.ContainsKey(teamName))
                {
                    dataNameTeamScore[teamName] = new SortedDictionary<string, int>();
                }
                if (!dataNameTeamScore[teamName].ContainsKey(wormName))
                {
                    dataNameTeamScore[teamName][wormName] = wormScore;
                }
                dataNameTeamScore[teamName][wormName] = wormScore;

                input = Console.ReadLine();
            }
            var ordered = dataNameTeamScore.OrderByDescending(key => key.Value.Values.Sum()).ThenByDescending(key => key.Value.Values.Sum() / key.Value.Values.Count).ToDictionary(x => x.Key, y => y.Value);
            int count = 1;
            foreach (var nameAndTeam in ordered)
            {

                var KVPteam = nameAndTeam.Key;
                var KVPname = nameAndTeam.Value;
                var sumScore = KVPname.Values.Sum();

                Console.WriteLine($"{count}. Team: {KVPteam} - {sumScore}");
                count++;
                foreach (var nameAndScore in KVPname.OrderByDescending(key => key.Value))
                {
                    var Name = nameAndScore.Key;
                    var Score = nameAndScore.Value;

                    Console.WriteLine("###{0} : {1}", Name, Score);
                }
            }
        }
    }
}

