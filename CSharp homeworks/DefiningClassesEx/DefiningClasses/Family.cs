using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            listPeople = new List<Person>();
        }
        public List<Person> listPeople { get; set; }

        public void AddMember (Person person)
        {
            listPeople.Add(person);
        }

        public Person GetOldestMember()
        {
            var oldest = listPeople.Where(x=>x.Age > 30).OrderByDescending(x => x.Name).ToList();

            return oldest[0]; 
        }
        public List<Person> GetOlder(List<Person> listPeople)
        {
            var oder = listPeople.Where(x => x.Age > 30).ToList();
            return oder;
        }
    }
}
