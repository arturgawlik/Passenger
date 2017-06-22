namespace Passenger.Core.Domain
{
    public class PassengerNode
    {
        public Node Node { get; protected set; }
        public Passenger Passenger { get; protected set; }

        protected PassengerNode()
        {
        }

        public PassengerNode(Node node, Passenger passenger)
        {
            SetNode(node);
            SetPassenger(passenger);
        }


        protected void SetNode(Node node)
        {
            Node = node;
        }

        protected void SetPassenger(Passenger passenger)
        {
            Passenger = passenger;
        }
    }
}