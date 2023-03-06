using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        new HotelDbContext _context = new HotelDbContext();

        public Hotel CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
            return hotel;
        }

        public void DeleteHotel(int id)
        {
            var deleteHotel= _context.Hotels.Find(id);
            _context.Hotels.Remove(deleteHotel);
            _context.SaveChanges();
        }

        public List<Hotel> GetAllHotels()
        {
            return _context.Hotels.ToList();
        }

        public Hotel GetById(int id)
        {
            return _context.Hotels.Find(id);
        }

        public Hotel GetByHotelName(string name)
        {
            return _context.Hotels.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            _context.SaveChanges();
            return hotel;   
        }
    }
}
