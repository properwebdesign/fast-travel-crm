using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSer
{
    public class HotelRepository
    {
        private FastTravelEntities context;

        public HotelRepository()
        {
            context= new FastTravelEntities();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public List<Hotel> GetHotels()
        {
            return context.Hotels.OrderBy(h => h.Name).ToList();
            //return this.context.Hotels.OrderBy(h => h.Name).ToList();
        }

    }
}