using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel>GetAllHotels();
        Hotel GetById(int id);
        Hotel GetByHotelName(string name);
        Hotel CreateHotel(Hotel hotel); 
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);   
    }
}
