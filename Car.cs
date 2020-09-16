using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Inclass3
{
    class Car : Vehicle
    {
        string make, type;
        int Number_of_doors;

        public Car(float registration_number, string color, Person owner, string make,string type,int Number_of_doors): base(registration_number, color, owner)
        {
            this.make = make;
            this.type = type;
            this.Number_of_doors = Number_of_doors;
        }

        public string get_make()
        {
            return this.make;
        }
        public string get_type()
        {
            return this.type;
        }
        public int get_Number_of_doors()
        {
            return this.Number_of_doors;
        }

        public void set_make(string make)
        {
             this.make=make;
        }
        public void set_type(string type)
        {
             this.type=type;
        }
        public void set_Number_of_doors(int Number_of_doors)
        {
             this.Number_of_doors=Number_of_doors;
        }



    }

}
