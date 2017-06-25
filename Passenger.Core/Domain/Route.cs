using System;

namespace Passenger.Core.Domain
{
    public class Route
    {
        public Guid Id { get; protected set; }
        public Node StartNode { get; protected set; }
        public Node EndNode { get; protected set; }

        protected Route()
        {
        }

        public Route(Guid id, Node startNode, Node endNode)
        {
            SetId(id);
            SetStartNode(startNode);
            SetEndNode(endNode);
        }


        protected void SetId(Guid id)
        {
            Id = Id;
        }

        protected void SetStartNode(Node startNode)
        {
            StartNode = startNode;
        }

        protected void SetEndNode(Node endNode)
        {
            EndNode = endNode;
        }
    }
}