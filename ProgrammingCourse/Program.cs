
using ProgrammingCourse;
using ProgrammingCourse.Examples;
using System.Text;

Console.WriteLine("""
╔═════════════════════════════════════╗
║ .-.     .-.                         ║   
║ |M|   .-|P|---.                     ║
║ |S|---| |Y|===|  LEARN HOW TO TALK  ║
║ |.|   |J|T| C |     TO MACHINES     ║
║ |N| C |A|H|===|                     ║
║ |E| + |V|O| # |  .NET Programming   ║
║ |T| + |A|N|===|                     ║
║ |_|___|_|_|___|                     ║
╠═════════════════════════════════════╣
║       szkolaprogramowania.com       ║
╚═════════════════════════════════════╝
""");

var text = "This is a example text. It can be longer";

var stringExample = new StringExample();
Console.WriteLine(stringExample.GetShortString(text));