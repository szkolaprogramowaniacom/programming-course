
using ProgrammingCourse;
using ProgrammingCourse.OOP;

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

void ShowParams(params int[] values)
{
	foreach (var value in values)
	{
		Console.Write($"{value} ");		
	}
    Console.WriteLine();
}

ShowParams(new int[] { 1, 2, 3 });
ShowParams(1, 3, 2);
ShowParams(1, 3, 2, 5, 4, 3, 4);