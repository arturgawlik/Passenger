using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class DailyRoute
    {
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; }
        public IEnumerable<PassengerNode> PassengerNodes { get; protected set; }

        protected DailyRoute()
        {
        }

        public DailyRoute(Guid id, Route route, IEnumerable<PassengerNode> passengerNodes)
        {
            SetId(id);
            SetRoute(route);
            SetPassengerNodes(passengerNodes);
        }


        protected void SetId(Guid id)
        {
            Id = id;
        }

        protected void SetRoute(Route route)
        {
            Route = route ?? throw new Exception("Route can not be null.");
        }

        protected void SetPassengerNodes(IEnumerable<PassengerNode> passengerNodes)
        {
            PassengerNodes = passengerNodes;
        }
    }
}