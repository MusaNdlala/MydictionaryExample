using System;
using System.Collections.Generic;
using System.Text;

namespace MydictionaryExample
{
    public class Person
    {
        public int id;
        public string Name;
        public string Surname;
        public Person(int _id, string _Name, string _Surname)
        {
            id = _id;
            Name = _Name;
            Surname = _Surname;
        }
        public Person()
        {

        }
    }
}