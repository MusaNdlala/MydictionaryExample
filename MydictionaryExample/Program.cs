using System;

namespace MydictionaryExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Add_Person_To_Dictionary CrudPersonDictionary = new Add_Person_To_Dictionary();
            var PersonDictionary = new System.Collections.Generic.Dictionary<int, Person>();

            

            CrudPersonDictionary.AddPersonToDictionary(new Person(1, "Name1", "Surname1"), PersonDictionary);
            CrudPersonDictionary.AddPersonToDictionary(new Person(2, "Name2", "Surname2"), PersonDictionary);
            CrudPersonDictionary.AddPersonToDictionary(new Person(3, "Name3", "Surname3"), PersonDictionary);
            CrudPersonDictionary.AddPersonToDictionary(new Person(4, "Name4", "Surname4"), PersonDictionary);
            CrudPersonDictionary.AddPersonToDictionary(new Person(5, "Name5", "Surname5"), PersonDictionary);
            CrudPersonDictionary.AddPersonToDictionary(new Person(6, "Name6", "Surname6"), PersonDictionary);

            Console.WriteLine("Seeding dictionary with vaules");
            CrudPersonDictionary.ToString(PersonDictionary);

            Console.WriteLine("Find Person with id");
            var temp = CrudPersonDictionary.GetPersonfromDictionaryById(new Person(6, "Name6", "Surname6"), PersonDictionary);
            CrudPersonDictionary.ToString(temp);

            Console.WriteLine("Remove Person from Dictionary with id");
            var temp1 = CrudPersonDictionary.RemovePersonfromDictionaryById(new Person(7, "Name6", "Surname6"), PersonDictionary);
            Console.WriteLine(temp1);
            CrudPersonDictionary.ToString(PersonDictionary);


        }
    }
}
