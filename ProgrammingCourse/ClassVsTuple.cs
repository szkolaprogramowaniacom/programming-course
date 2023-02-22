using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgrammingCourse
{
    //var tupleTester = new ClassVsTuple();
    //var personalInfo = tupleTester.GetPersonalInformation();
    //Console.WriteLine($"{personalInfo.Name} {personalInfo.Age}");

    //var(name, age) = tupleTester.GetPersonalInformationUsingTuple();
    //Console.WriteLine($"{name} {age}");

    public class PersonalInformation
    {
       public string Name { get; set; }
        public int Age { get; set; }
    }

    public class ClassVsTuple
    {
        public PersonalInformation GetPersonalInformation()
        {
            return new PersonalInformation
            {
                Name = "John Smith",
                Age = 22
            };
        }

        public (string, int) GetPersonalInformationUsingTuple()
        {
            return ("Ann Smith", 21);
        }
    }
}
