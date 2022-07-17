using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetCarDetailsTest();

            //ColorTest();

            //BrandTest();

            //CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.DailyPrice + " " + car.ColorId + " " + car.BrandId);
            }
            foreach (var car in carManager.GetAllByColorId(1))
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(car.Id);
            }
        }

        private static void GetCarDetailsTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " " + car.ColorName + " " + car.BrandName + " " + car.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName + " " + color.ColorId);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

    }

}
    

    

