namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Kia";
            myCar.Model = "Soul";
            myCar.Year = 2012;

            var dadsCar = new Car()
            {
                Make = "Subaaru",
                Model = "Outback",
                Year = 2020,
            };

            var dadsCar2 = new Car("Land Rover", "Range Rover", 2008);

            var dreamCar = new Car("Porche", "911 GT3 RS", 2023);
            var carList = new List<Car>() { myCar,dadsCar,dadsCar2,dreamCar};
           foreach(var car in carList)
            { Console.WriteLine($"{car.Make} {car.Model} {car.Year}"); }

           

        }
    }
}