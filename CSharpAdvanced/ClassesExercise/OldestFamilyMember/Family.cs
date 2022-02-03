using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public IEnumerator<Person> GetEnumerator()
        {
            foreach (var person in people)
                yield return person;
        }

        public Family()
        {
            People = new List<Person>();
        }

        private List<Person> people;

        public List<Person> People
        {
            get
            {
                return people;
            }
            set
            {
                people = value;
            }
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            string oldestName = "";
            int oldestAge = int.MinValue;
            Person oldestPerson = null;

            foreach (var person in People)
            {
                Person currentPerson = person;

                if (currentPerson.Age > oldestAge)
                {
                    oldestAge = currentPerson.Age;
                    oldestName = currentPerson.Name;
                    oldestPerson = currentPerson;
                }
            }

            return oldestPerson;
        }

    }
}
