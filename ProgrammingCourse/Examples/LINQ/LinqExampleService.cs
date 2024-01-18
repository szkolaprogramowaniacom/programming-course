using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.LINQ
{
    internal class LinqExampleService
    {
        public List<UserDto> ConvertUsers(List<User> users)
        {
            // without linq
            //List<UserDto> usersDto = new List<UserDto>();
            //foreach (var user in users)
            //{
            //    usersDto.Add(new UserDto { 
            //        Name = user.Name
            //    });
            //}
            //return usersDto;

            return users.Select(u => new UserDto { Name = u.Name }).ToList();
        }
    }
}
