using System;
using System.Collections.Generic;
using System.Linq;

namespace Passenger.Core.Domain
{
    public class DailyRoute
    {
        private ISet<PassengerNode> _passengerNodes = new HashSet<PassengerNode>();
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; }
        public ISet<PassengerNode> PassengerNodes => _passengerNodes;

        protected DailyRoute()
        {
            Id = Guid.NewGuid();
        }

        public DailyRoute(Guid id, Route route)
        {
            SetId(id);
            SetRoute(route);
        }


        protected void SetId(Guid id)
        {
            Id = id;
        }

        protected void SetRoute(Route route)
        {
            Route = route ?? throw new Exception("Route can not be null.");
        }
        public void AddPassengerNode(Passenger passenger, Node node)
        {
            var passengerNode = GetPassengerNode(passenger);
            
            if(passengerNode != null)
                throw new InvalidOperationException($"Node already exist for passenger: '{passenger.UserId}'.");

            _passengerNodes.Add(PassengerNode.Create(passenger, node));
        }
        public void RemovePassengerNode(Passenger passenger)
        {
            var passengerNode = GetPassengerNode(passenger);
            
            if(passengerNode == null)
                return;

            _passengerNodes.Remove(passengerNode);
        }
        private PassengerNode GetPassengerNode(Passenger passenger) => _passengerNodes.SingleOrDefault(x => x.Passenger.UserId == passenger.UserId);
    }
}