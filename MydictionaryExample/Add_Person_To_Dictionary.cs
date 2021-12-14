using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MydictionaryExample
{
    public class Add_Person_To_Dictionary
    {
        /*private readonly Person _GetPerson;
        private readonly Dictionary<int,Person> GetPersonCollection;
        public Add_Person_To_Dictionary(Person GetPerson)
        {
            _GetPerson = GetPerson;
        }*/
        public Dictionary<int, Person> AddPersonToDictionary(Person _ParamPerson, Dictionary<int, Person> _ParamGetPersonCollection)
        {
            try
            {
                _ParamGetPersonCollection.Add(_ParamPerson.id, _ParamPerson);

                return _ParamGetPersonCollection;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Dictionary<int, Person> AddBulkPersonToDictionary(List<Person> _ListParamPerson, Dictionary<int, Person> _ParamGetPersonCollection)
        {
            try
            {
                foreach (Person myperson in _ListParamPerson)
                {
                    _ParamGetPersonCollection.Add(myperson.id, myperson);
                }
                return _ParamGetPersonCollection;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Person GetPersonfromDictionaryById(Person _ParamPerson, Dictionary<int, Person> _ParamGetPersonCollection)
        {
            try
            {
                Person returnValue = new Person();
                if (_ParamGetPersonCollection.TryGetValue(_ParamPerson.id, out returnValue)==true)
                {
                    return returnValue;
                }
                returnValue = null;
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Dictionary<int, Person> GetPersonfromDictionaryById(List<int> idInt, Dictionary<int, Person> _ParamGetPersonCollection)
        {
            try
            {
                Dictionary<int, Person> returnValue = new Dictionary<int, Person>();
                foreach (int i in idInt) {
                    var tempResult = new Person();
                    if (_ParamGetPersonCollection.TryGetValue(i, out tempResult) == true)
                    {
                        returnValue.Add(tempResult.id, tempResult);
                    }
                }
                returnValue = null;
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool RemovePersonfromDictionaryById(Person _ParamPerson, Dictionary<int, Person> _ParamGetPersonCollection)
        {
            try
            {
                var temp = _ParamGetPersonCollection.ContainsKey(_ParamPerson.id);
                if (temp == true)
                {
                    _ParamGetPersonCollection.Remove(_ParamPerson.id);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int RemoveBulkPersonsfromDictionaryById(List<Person> _ParamPerson, Dictionary<int, Person> _ParamGetPersonCollection)
        {
            try
            {
                int totalPersonsRemoved = 0;
                foreach (Person _Person in _ParamPerson) { 
                    var temp = _ParamGetPersonCollection.ContainsKey(_Person.id);
                    if (temp == true)
                    {
                        _ParamGetPersonCollection.Remove(_Person.id);
                        totalPersonsRemoved++;
                    }
                }
                return totalPersonsRemoved;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public void ToString(Dictionary<int, Person> _ParamGetPersonCollection)
        {
            foreach (Person person in _ParamGetPersonCollection.Values)
            {
                Console.WriteLine("id :"+ person.id +" Name :"+person.Name+" Surname :"+person.Surname);
            }
        }
        public void ToString(Person person)
        {
           Console.WriteLine("id :" + person.id + " Name :" + person.Name + " Surname :" + person.Surname);
        }
    }
}