using BookingApp.Models.Hotels.Contacts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Repositories
{
    public class HotelRepository : IRepository<IHotel>
    {
        public HotelRepository()
        {

        }
        public void AddNew(IHotel model)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<IHotel> All()
        {
            throw new NotImplementedException();
        }

        public IHotel Select(string criteria)
        {
            throw new NotImplementedException();
        }
    }
}
