using ProgrammingCourse.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var classWithProperties = new ClassWithProperties("Smith");
//classWithProperties.FirstName = "John";
////classWithProperties.FirstName = "";
////classWithProperties.LastName = "";
////classWithProperties.Age = 12;
//Console.WriteLine(classWithProperties.Name);

namespace ProgrammingCourse.OOP
{
    internal class ClassWithProperties
    {
        public ClassWithProperties(string lastName)
        {
            this.lastName = lastName;
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { 
                if(value == "")
                {
                    throw new ArgumentException("Wrong value");
                }
                firstName = value; 
            }
        }
        
        private string lastName;
        public string LastName { 
            get 
            { 
                return lastName;
            }
        }

        public int Age { get; } = 12;

        public string Name
        {
            get => $"{firstName} {lastName}";
        }

        private int size;
        public int Size
        {
            get => CalculateSize();
            set => size = value;
        }

        private int CalculateSize()
        {
            return 232;
        }
    }
}
