using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car = new Car();

            var r = car.doorsProp;
            car.doorsProp = 10;
            var _struct = new CarStruct();

            r = car.Getter();
            r = 10;
            car.Setter(r);

            car.Method1();

            Console.WriteLine(car.ConvertIntToString(car.GetNumberTen()));
        }
    }

    public class C
    {
        void Met()
        {
            var r = new Car();
        }
    }
}