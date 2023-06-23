using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.DI
{
    public class PersonService : IPersonService
    {
        public string GetName(Person person)
        {
            return person.Name;
        }
    }
}
