namespace AdventDay1
{
    public class PartOneSolver
    {
        public static int SolvePartOne()
        {
            int? previousValue = null;
            int increasedReadings = 0;

            foreach(var value in SonarReadings.readings)
            {
                if (previousValue == null)
                {
                    previousValue = value;
                    continue;
                }

                if (value > previousValue) {
                    increasedReadings++;
                }
                previousValue = value;
            }
            return increasedReadings;
        }
    }
}