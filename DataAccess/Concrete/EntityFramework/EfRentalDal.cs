using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal: EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.CarId equals r.CarId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.Id equals u.Id
                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 CarName = b.BrandName,
                                 UserName = u.FirstName + " " + u.LastName,
                                 CustomerName = cu.CustomerName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
