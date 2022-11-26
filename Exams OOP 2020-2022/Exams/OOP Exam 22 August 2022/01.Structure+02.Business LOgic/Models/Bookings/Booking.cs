using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Bookings
{
    public class Booking : IBooking
    {
        public Booking(IRoom room,int residenceDuration,int adultsCount,int childrenCount,int bookingNumber)
        {
                
        }
        public IRoom Room => throw new NotImplementedException();

        public int ResidenceDuration => throw new NotImplementedException();

        public int AdultsCount => throw new NotImplementedException();

        public int ChildrenCount => throw new NotImplementedException();

        public int BookingNumber => throw new NotImplementedException();

        public string BookingSummary()
        {
            throw new NotImplementedException();
        }
    }
}
