using BookingApp.Models.Rooms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Rooms
{
    public abstract class Room : IRoom
    {
        public Room(int bedCapacity)
        {

        }
        public int BedCapacity => throw new NotImplementedException();

        public double PricePerNight => throw new NotImplementedException();

        public void SetPrice(double price)
        {
            throw new NotImplementedException();
        }
    }
}
