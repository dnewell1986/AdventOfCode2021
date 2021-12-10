// See https://aka.ms/new-console-template for more information
using AdventDay1;

internal class PartTwoSolver
{

    public static int SolvePartTwo()
    {
        int? previousSum = null;
        int valueIncreased = 0;

        for(var i = 0; i < SonarReadings.readings.Count - 2; i++){
            if (previousSum == null){
                previousSum = SonarReadings.readings.Take(3).Sum();
                continue;
            }

            var sum = SonarReadings.readings.Skip(i).Take(3).Sum();

            if (sum > previousSum)
            {
                valueIncreased++;
            }
            previousSum = sum;
        }
        return valueIncreased;
    }
}