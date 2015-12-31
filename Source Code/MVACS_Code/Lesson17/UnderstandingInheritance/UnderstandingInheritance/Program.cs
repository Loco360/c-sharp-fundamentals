using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;
            //myCar.TowingCapacity = 1200;

            printVehicleDetails(myCar);


            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;
            printVehicleDetails(myTruck);

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the vehcile's details: {0}",
                vehicle.FormatMe());
        }

    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();
    }

    class Car : Vehicle 
    {
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        } 
    }

    sealed class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        } 

    }

    /*
    class Semi : Truck
    {

    }
    */

}
