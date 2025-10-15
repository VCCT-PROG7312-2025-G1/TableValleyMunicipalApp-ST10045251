using System;
using System.Collections.Generic;
using System.Linq;
using TableValleyMunicipalApp.Models;

namespace TableValleyMunicipalApp.Service
{
    internal class Storing
    {
        private readonly SortedDictionary<DateTime, List<Events>> _byDate = new SortedDictionary<DateTime, List<Events>>();
        private readonly Dictionary<string, Events> _byId = new Dictionary<string, Events>();
        private readonly HashSet<string> _categories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private readonly EventQueue _submissionQueue = new EventQueue();
        public void Add(Events ev)
        {
            if (!_byDate.ContainsKey(ev.Date.Date))
                _byDate[ev.Date.Date] = new List<Events>();

            _byDate[ev.Date.Date].Add(ev);
            _categories.Add(ev.Category);
        }

        public IEnumerable<Events> GetAll()
        {
            foreach (var kv in _byDate)

                foreach (var ev in kv.Value)
                    yield return ev;
        }


        /*public IEnumerable<Events> GetByDate(DateTime date)
        {
            if (_byDate.TryGetValue(date, Date, out var list))
                foreach (var ev in list) yield return Events;
        }*/

        public IEnumerable<string> GetCategories() => _categories;

        public IEnumerable<Events> Search(string query, DateTime? date = null)
        {
            foreach (var ev in GetAll())
            {
                if (date.HasValue && ev.Date.Date != date.Value.Date)
                    continue;

                if (string.IsNullOrEmpty(query) ||
                    ev.EventName.ToLower().Contains(query.ToLower()) ||
                    ev.Category.ToLower().Contains(query.ToLower()))
                {
                    yield return ev;
                }
            }
        }

        public IEnumerable<Events> SortedBy(string sortBy)
        {
            var all = GetAll();

            switch (sortBy)
            {
                case "Date":
                    return all.OrderBy(e => e.Date);

                case "Name":
                    return all.OrderBy(e => e.EventName);

                case "Category":
                    return all.OrderBy(e => e.Category);

                default:
                    return all.OrderBy(e => e.Date);
            }
        }
        public void QueueSubmission(Events ev) => _submissionQueue.Enqueue(ev);
        public Events DequeueSubmission() => _submissionQueue.Dequeue();

        public Events GetById(string id) => _byId.TryGetValue(id, out var e) ? e : null;


    }
}
