using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableValleyMunicipalApp.DataStructures;

namespace TableValleyMunicipalApp.Class
{
    public class PriorityQueue<T>
    {
        private List<(T item, int Priority)> _queue = new List<(T, int)>();

        public void Enqueue(T item)
        {
            int priority = 1;
            if (item is ServiceRequest sr)
                priority = sr.Priority;

            _queue.Add((item, priority));
            _queue = _queue.OrderBy(x => x.Priority).ToList();
        }

       
        public List<T> ToList()
        {
            return _queue.Select(x => x.item).ToList();
        }
    }
}
