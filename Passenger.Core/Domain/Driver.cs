using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class Driver //Agregate root
    {   //VALUES OBJETS: 
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }
        
    }
}