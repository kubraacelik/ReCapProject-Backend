using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.Id equals c.Id
                             join cu in context.Customers on r.CustomerId equals cu.Id
                             join u in context.Users on cu.Id equals u.Id
                             join b in context.Brands on c.BrandId equals b.BrandId

                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 DailyPrice = c.DailyPrice,
                                 ModelName = c.ModelName
                             };
                return result.ToList();
            }
        }
    }
}
