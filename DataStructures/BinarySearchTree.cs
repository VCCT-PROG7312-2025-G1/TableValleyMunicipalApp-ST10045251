using System.Collections.Generic;
using TableValleyMunicipalApp.DataStructures;

namespace TableValleyMunicipalApp.Class
{
    public class TreeNode
    {
        public ServiceRequest Request;
        public TreeNode Left, Right;
        public TreeNode(ServiceRequest req) { Request = req; }
    }


        public class BinarySearchTree
        {
            private TreeNode root;
            public void Insert(ServiceRequest request)
            {
                root = InsertRec(root, request);
            }
            private TreeNode InsertRec(TreeNode node, ServiceRequest request)
            {
                if (node == null) return new TreeNode(request);
                if (request.requestID < node.Request.requestID)
                    node.Left = InsertRec(node.Left, request);
                else if (request.requestID > node.Request.requestID)
                    node.Right = InsertRec(node.Right, request);
                return node;
            }

            public ServiceRequest Search(int id)
            {
                var node = root;
                while (node != null)
                {
                    if (id == node.Request.requestID)
                    return node.Request;
                    node = id < node.Request.requestID ? node.Left : node.Right;
                }
                return null;
            }

            public List<ServiceRequest> InOrderTraversal()
            {
                var list = new List<ServiceRequest>();
                InOrderRec(root, list);
                return list;
            }

            private void InOrderRec(TreeNode node, List<ServiceRequest> list)
            {
                if (node == null) return;
                InOrderRec(node.Left, list);
                list.Add(node.Request);
                InOrderRec(node.Right, list);
            }
        }
    }


