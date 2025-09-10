using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableValleyMunicipalApp.Models;

namespace TableValleyMunicipalApp.DataStructures
{
    public class IssueNode
    {
        public Issue Data { get; set; }
        public IssueNode Next { get; set; }

        public IssueNode(Issue issue)
        {
            Data = issue;
            Next = null;
        }
    }

    public class IssuesLinkedList
    {
        private IssueNode head;

        public void Add(Issue issue)
        {
            IssueNode newNode = new IssueNode(issue);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                IssueNode current = head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = newNode;
            }
        }

        public IEnumerable<Issue> GetAll()
        {
            IssueNode current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}