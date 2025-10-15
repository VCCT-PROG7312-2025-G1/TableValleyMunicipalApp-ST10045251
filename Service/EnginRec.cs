using System;
using System.Collections.Generic;
using System.Linq;
using TableValleyMunicipalApp.Models;
using TableValleyMunicipalApp.Service;
using System.Text;
using System.Threading.Tasks;

namespace TableValleyMunicipalApp.Service
{
    internal class EnginRec
    {
       private readonly Dictionary<string, int> _searchCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public void RecordSearch(string categoryorQuery)
        {
            if (string.IsNullOrWhiteSpace(categoryorQuery)) return;
            var key = categoryorQuery.Trim();
            if (_searchCount.ContainsKey(key) ) _searchCount[key]++;
            else _searchCount[key] = 1;
        }

        public IEnumerable<string> TopQueries(int top = 3)
        {
            return _searchCount.OrderByDescending(kv => kv.Value).Take(top).Select(kv => kv.Key);
        }

        public IEnumerable<Events> Suggest(Storing store, int max = 5)
        {
            var top = TopQueries(5).ToList();
            var suggested = new List<Events>();
            foreach (var q in top)
            {
                suggested.AddRange(store.Search(q).Take(max));
                if (suggested.Count >= max) break;
            }
            return suggested.Distinct().Take(max);
        }
    }
}
