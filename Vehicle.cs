using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass3
{
    class Vehicle
    {
        float registration_number;
        string color;

        Person owner;

        public Vehicle(float registration_number,string color,Person owner)
        {
            this.registration_number = registration_number;
            this.color = color;
            this.owner = owner;
        }

        public float get_registration_number()
        {
            return this.registration_number;
        }

        public string get_color()
        {
            return this.color;
        }

        public void set_registration_number(float registration_number)
        {
            this.registration_number=registration_number;
        }

        public void get_color(string color)
        {
             this.color=color;
        }

        public void Change_of_Owner(Person owner)
        {
            this.owner = owner;   
        }

        public Person get_owner()
        {
            return this.owner;
        }

    }
}
