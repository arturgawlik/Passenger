namespace Passenger.Core.Domain
{
    public class PassengerNode
    {
        public Node Node { get; protected set; }
        public Passenger Passenger { get; protected set; }

        protected PassengerNode()
        {
        }

        protected PassengerNode(Passenger passenger, Node node)
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
        public static PassengerNode Create(Passenger passenger, Node node) => new PassengerNode(passenger, node);
    }
}