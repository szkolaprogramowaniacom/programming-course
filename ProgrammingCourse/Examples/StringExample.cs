﻿using System.Text;

namespace ProgrammingCourse.Examples
{
    internal class StringExample
    {
        public void Run()
        {
            Console.WriteLine("Start");
            //var longString = BuildLongString();
            var longString = BuildLongStringWithBuilder();
            Console.WriteLine(longString.Length);
        }

        public string BuildLongString()
        {
            var value = "";

            for (int i = 0; i < 100000; i++)
            {
                value = value + "a";
            }

            return value;
        }

        public string BuildLongStringWithBuilder()
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < 1000000; i++)
            {
                stringBuilder.Append("a");
            }
            return stringBuilder.ToString();
        }

    }
}