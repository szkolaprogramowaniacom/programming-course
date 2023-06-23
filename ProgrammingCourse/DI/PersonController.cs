using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.DI
{
    public class PersonController : IPersonController
    {
        IPersonService personService;

        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        public void Run()
        {
            var person = new Person { Id = 1, Name = "John Smith" };
            Console.WriteLine(personService.GetName(person));
        }
    }
}
