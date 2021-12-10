namespace AdventDay2
{
    internal class Solver
    {
        public static int SolvePartOne()
        {
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

            return xValue * yValue;
        }

        public static int SolvePartTwo()
        {
            var xValue = 0;
            var yValue = 0;
            var aim = 0;

            foreach(var command in SubmarineCommands.Commands)
            {
                var commandTuple = ParseCommand(command);
                switch(commandTuple.Item1)
                {
                    case "forward":
                        xValue += commandTuple.Item2;
                        if (aim != 0)
                            yValue += commandTuple.Item2 * aim;
                        break;
                    case "down":
                        aim += commandTuple.Item2;
                        break;
                    case "up":
                        aim -= commandTuple.Item2;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return xValue * yValue;
        }

        private static Tuple<string, int> ParseCommand(string command)
        {
            var values = command.Split(' ');
            return new Tuple<string, int>(values[0], int.Parse(values[1]));
        }
    }
}