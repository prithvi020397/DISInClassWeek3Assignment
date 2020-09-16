using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass3
{
    class Bike : Vehicle
    {
        string make, type;
        int Number_of_Gears;

        public Bike(float registration_number, string color, Person owner, string make, string type, int Number_of_Gears):base(registration_number, color, owner)
        {
            this.make = make;
            this.type = type;
            this.Number_of_Gears = Number_of_Gears;
        }

        public string get_make()
        {
            return this.make;
        }
        public string get_type()
        {
            return this.type;
        }
        public int get_Number_of_Gears()
        {
            return this.Number_of_Gears;
        }

        public void set_make(string make)
        {
            this.make = make;
        }
        public void set_type(string type)
        {
            this.type = type;
        }
        public void set_Number_of_Gears(int Number_of_Gears)
        {
            this.Number_of_Gears = Number_of_Gears;
        }
    }
}
