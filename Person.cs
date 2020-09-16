using System;

namespace Inclass3
{
    class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }

        public string get_name()
        {
            return this.name;
        }

        public void set_name(string name)
        {
            this.name = name;
        }
    }
}
