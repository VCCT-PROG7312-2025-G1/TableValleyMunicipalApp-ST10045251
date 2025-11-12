using System.Collections.Generic;

namespace TableValleyMunicipalApp.Class
{
    public class Graph
    {
        private Dictionary<string, HashSet<string>> adjList = new Dictionary<string, HashSet<string>>();

        public void AddEdge(string from, string to)
        {
            if (!adjList.ContainsKey(from)) adjList[from] = new HashSet<string>();
            adjList[from].Add(to);
        }

        public string DisplayGraph()
        {
            string result = "Service Request → Department Links:\n";
            foreach (var kvp in adjList)
            {
                result += $"{kvp.Key} → {string.Join(", ", kvp.Value)}\n"; 
            }
            return result;
        }
    }
}

