using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetCarDetailsTest();

            //ColorTest();

            //BrandTest();

            //CarTest();

            //RentalTest();

            //CustomerTest();

            //UserTest();

            //GetCustomerDetailsTest();

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user = new User { Id = 9, FirstName = "Aysun", LastName = "Karaca", Email = "aysunk" };
            userManager.Add(user);
            Console.WriteLine(user.Email);

        }

        //private static void CustomerTest()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        //    Customer customer1 = new Customer { UserId = 7, CompanyName = "Hyundai", Id = new Guid("77777777-7777-7777-7777-777777777777") };
        //    customerManager.Add(customer1);
        //    Console.WriteLine(customer1);

        //}

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental { Id = 7, CarId = 8, CustomerId = 9, RentDate = new DateTime(2022, 12, 5), ReturnDate = new DateTime(2022, 12, 8) };
            rentalManager.Add(rental);
            Console.WriteLine(rental.RentDate);
            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car { BrandId = 2, ColorId = 6, Id = 8, DailyPrice = 36, Description = "Benzin", ModelYear = "2011" };
            carManager.Add(car1);

            var result = carManager.GetAll();

            if (result.Success == true) 
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetailsTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " " + car.ColorName + " " + car.BrandName + " " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
            
        }
        private static void GetCustomerDetailsTest()
        {

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetCustomerDetails();
            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.CompanyName + " ");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Color color1 = new Color { ColorId = 5, ColorName = "Purple" };

            var result = colorManager.GetAll();

            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName + " " + color.ColorId);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Brand brand1 = new Brand { BrandId = 13, BrandName = "BMW" };
            brandManager.Add(brand1);

            var result = brandManager.GetAll();

            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            
        }

    }

}
    

    

