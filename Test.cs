using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass3
{
    class Test
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Person1");
            float registration_number1 = 1234;
            string make1 = "Chevrolet";
            string type1 = "SEDAN";
            string color1 = "red";
            int Number_of_Doors = 5;
            Car car = new Car(registration_number1, color1, p1, make1, type1, Number_of_Doors);

            Person p2 = new Person("Person2");
            float registration_number2 = 5678;
            string make2 = "Kawasaki";
            string type2 = "SPORT";
            string color2 = "green";
            int Number_of_Gears = 6;
            Bike bike = new Bike(registration_number2, color2, p2, make2, type2, Number_of_Gears);

            Console.WriteLine("Car");
            Console.WriteLine("Registration Number : "+car.get_registration_number());
            Console.WriteLine("Color : " + car.get_color());
            Console.WriteLine("Owner : " + car.get_owner().get_name());
            Console.WriteLine("Make : " + car.get_make());
            Console.WriteLine("Type : " + car.get_type());
            Console.WriteLine("Number of Doors : " + car.get_Number_of_doors());

            Console.WriteLine("Bike");
            Console.WriteLine("Registration Number : " + bike.get_registration_number());
            Console.WriteLine("Color : " + bike.get_color());
            Console.WriteLine("Owner : " + bike.get_owner().get_name());
            Console.WriteLine("Make : " + bike.get_make());
            Console.WriteLine("Type : " + bike.get_type());
            Console.WriteLine("Number of Gears : " + bike.get_Number_of_Gears());

            Person p3 = new Person("Person3");
            Person p4 = new Person("Person4");
            car.Change_of_Owner(p3);
            bike.Change_of_Owner(p4);
            Console.WriteLine("Changed Owner of Car : " + car.get_owner().get_name());
            Console.WriteLine("Changed Owner of Bike : " + bike.get_owner().get_name());

        }
    }
}
