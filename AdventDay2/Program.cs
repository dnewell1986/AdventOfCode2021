// See https://aka.ms/new-console-template for more information

using AdventDay2;

var xValue = 0;
var yValue = 0;

foreach(var command in SubmarineCommands.Commands)
{
    var commandTuple = ParseCommand(command);
    switch(commandTuple.Item1)
    {
        case "forward":
            xValue += commandTuple.Item2;
            break;
        case "down":
            yValue += commandTuple.Item2;
            break;
        case "up":
            yValue -= commandTuple.Item2;
            break;
        default:
            throw new NotImplementedException();
    }
}
Console.WriteLine($"xValue is: {xValue}");
Console.WriteLine($"yValue is: {yValue}");
Console.WriteLine($"Part One: Multiplied value is {xValue * yValue}");

Tuple<string, int> ParseCommand(string command)
{
    var values = command.Split(' ');
    return new Tuple<string, int>(values[0], int.Parse(values[1]));
}