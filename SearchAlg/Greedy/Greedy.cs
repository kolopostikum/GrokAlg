using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SearchAlg.Greedy
{
    public class GreedyStation<State, Station>
    {
        private readonly HashSet<State> states; 
        private readonly Dictionary<Station, HashSet<State>> stationStatesPares;
        
        public GreedyStation(HashSet<State> states, Dictionary<Station, HashSet<State>> stationStatesPares)
        {
            this.states = states;
            this.stationStatesPares = stationStatesPares;
        }
        
        public HashSet<Station> GreedyStationsSearch()
        {
            var greedyStationsSet = new HashSet<Station>();
            while (states.Any())
            {
                Station bestStation;
                var isStation = TryGreedyStationSearch(out bestStation);
                if (!isStation)
                    break;
                greedyStationsSet.Add(bestStation);
                states.ExceptWith(stationStatesPares[bestStation]);
            }
            return greedyStationsSet;
        }

        private bool TryGreedyStationSearch( out Station result)
        {
            bool bestSearched = false;
            Station bestStation = default;
            HashSet<State> statesCovered= new HashSet<State>();
            foreach(var station in stationStatesPares)
            {
                var covered = station.Value.Intersect(states).ToHashSet();
                if (covered.Count > statesCovered.Count)
                {
                    bestStation = station.Key;
                    statesCovered = covered;
                    bestSearched = true;
                }
            }
            result = bestStation;
            return bestSearched;
        }
    }
}