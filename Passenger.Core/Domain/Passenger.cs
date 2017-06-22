using System;

namespace Passenger.Core.Domain
{
    public class Passenger
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public Node Address { get; protected set; }

        protected Passenger()
        {
        }

        public Passenger(Guid id, Guid userId, Vehicle vehicle, Node addres)
        {
            SetId(id);
            SetUserId(userId);
            SetVehicle(vehicle);
            SetAddres(addres);
        }

        protected void SetId(Guid id)
        {
            Id = id;
        }

		protected void SetUserId(Guid userId)
		{
            UserId = userId;
		}

		protected void SetVehicle(Vehicle vehicle)
		{
            Vehicle = vehicle;
		}

		protected void SetAddres(Node addres)
		{
            Address = addres;
		}
    }
}