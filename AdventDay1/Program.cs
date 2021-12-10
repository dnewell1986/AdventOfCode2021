// See https://aka.ms/new-console-template for more information
using AdventDay1;


var partOneAnswer = PartOneSolver.SolvePartOne();

var partTwoAnswer = PartTwoSolver.SolvePartTwo();


Console.WriteLine($"Part One: The number of readings that increased over the previous value was {partOneAnswer}");
Console.WriteLine($"Part Two: The number of readings that increased over the previous value was {partTwoAnswer}");
Console.WriteLine("Press any key to exit...");
Console.ReadLine();
