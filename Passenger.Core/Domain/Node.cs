using System;

namespace Passenger.Core.Domain
{
    public class Node
    {
        public string Addres { get; protected set; }
        public double Longitude { get; protected set; }
        public double Latitude { get; protected set; }

        protected Node()
        {
        }

        public Node(string addres, double longitude, double latitude)
        {
            SetAddres(addres);
            SetLongitude(longitude);
            SetLatitude(latitude);
        }


        protected void SetAddres(string addres)
        {
            Addres = addres;
        }

		protected void SetLongitude(double longitude)
		{
            if (longitude < 0)
                throw new Exception("Longitude can not be smaller than 0.");

            Longitude = longitude;
		}

		protected void SetLatitude(double latitude)
		{
            if (latitude < 0)
				throw new Exception("Latitude can not be smaller than 0.");

            Latitude = latitude;
		}
    }
}