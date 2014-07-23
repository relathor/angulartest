using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers.Api
{
    using System.Dynamic;

    public class TestController : ApiController
    {
        public class Person
        {
            public int id { get; set; }

            public string name { get; set; }

            public string age { get; set; }
        }

        private static readonly List<Person> persons = new List<Person>()
                                                           {
                                                               new Person()
                                                                   {
                                                                       id = 1,
                                                                       name = "meh",
                                                                       age = "21"
                                                                   },
                                                               new Person()
                                                                   {
                                                                       id = 2,
                                                                       name = "sam",
                                                                       age = "19"
                                                                   },
                                                               new Person()
                                                                   {
                                                                       id = 3,
                                                                       name = "ed",
                                                                       age = "27"
                                                                   },
                                                               new Person()
                                                                   {
                                                                       id = 4,
                                                                       name = "paul",
                                                                       age = "26"
                                                                   },
                                                               new Person()
                                                                   {
                                                                       id = 5,
                                                                       name = "sara",
                                                                       age = "20"
                                                                   },
                                                               new Person()
                                                                   {
                                                                       id = 6,
                                                                       name = "laura",
                                                                       age = "25"
                                                                   },
                                                               new Person()
                                                                   {
                                                                       id = 7,
                                                                       name = "fred",
                                                                       age = "23"
                                                                   },
                                                           };
        public IEnumerable<object> Get()
        {
            return persons;
        }

        public void Post(Person person)
        {
            person.id = persons.Max(p => p.id) + 1;
            persons.Add(person);
        }

        public void Delete(int id)
        {
            persons.Remove(persons.First(p => p.id == id));
        }

        public void Put(Person person)
        {
            persons.Remove(persons.First(p => p.id == person.id));
            persons.Add(person);
        }
    }
}
