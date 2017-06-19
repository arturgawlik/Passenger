using System;

namespace Passenger.Core.Domain
{
    public class Vehicle //ValueObject -> Immutable(nie zmienialna)
    {
        public string Brand { get; protected set; }
        public string Name { get; protected set; }
        public int Seats { get; protected set; }

        protected Vehicle()
        {
        }
        protected Vehicle(string brand, string name, int seats)
        {
            SetBrand(brand);
            SetName(name);
            SetSeats(seats);
        }

        private void SetBrand(string brand)
        {
            if(string.IsNullOrWhiteSpace(brand))
                throw new Exception("Brand can not be empty.");

            Brand = brand;
        }
        private void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new Exception("Car name can not be empty.");
            
            Name = name;
        }
        private void SetSeats(int seats)
        {
            if(seats < 0 || seats > 99 )
                throw new Exception("There can not be less than 0 and more than 99 seats.");

            Seats = seats;
        }
        static public Vehicle Create(string brand, string name, int seats) => new Vehicle(brand, name, seats);
    }
}