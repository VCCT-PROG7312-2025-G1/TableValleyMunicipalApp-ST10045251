using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableValleyMunicipalApp.Models;

namespace TableValleyMunicipalApp.Service
{
    internal class EventQueue
    {
        private EventsNode front;
        private EventsNode rear;

        public void Enqueue(Events e)
        {
            var node = new EventsNode(e);
            if (rear == null) { front = node; return; }
            rear.Next = node;
            rear = node;
        }

        public Events Dequeue()
        {
            if (front == null) return null;
            var e = front.Data;
            front = front.Next;
            if (front == null) rear = null;
            return e;
        }

        public IEnumerable<Events> GetAll()
        {
            var cur = front;
            while (cur != null)
            {
                yield return cur.Data; 
                cur = cur.Next;
            }
        }

        public class EventsNode
        {
            public Events Data;
            public EventsNode Next;
            public EventsNode(Events e)
            { Data = e;
                Next = null;
            }        
        }
    }
}
