namespace AdventDay3
{
    public static class Solver
    {
        public static int SolvePartTwo()
        {
            var decreasingList = Input.diagReport;
            var oxygenGeneratorRating = GetCommonValue(0, Input.diagReport, true);
            var cO2ScrubberRating = GetCommonValue(0, Input.diagReport);

            return Convert.ToInt32(string.Join("", oxygenGeneratorRating), 2) * Convert.ToInt32(string.Join("", cO2ScrubberRating), 2);
        }

        public static string GetCommonValue(int arrPos, List<string> diagReport, bool isMax = false)
        {
            if (diagReport.Count == 1) return diagReport.First();
            Dictionary<int, List<string>> retValue = new Dictionary<int, List<string>>
            {
                { 0, new List<string>() },
                { 1, new List<string>() }
            };
            for(var i = 0; i < diagReport.Count; i++)
            {
                if (diagReport[i].ToArray()[arrPos] == '1') 
                {
                    retValue[1].Add(diagReport[i]);
                }
                else
                {
                    retValue[0].Add(diagReport[i]);
                }
            }
            if (retValue[1].Count == retValue[0].Count)
            {
                return isMax ? GetCommonValue(arrPos + 1, retValue[1], isMax) : GetCommonValue(arrPos + 1, retValue[0], isMax);
            }
            else if (retValue[1].Count > retValue[0].Count)
            {
                return isMax ? GetCommonValue(arrPos + 1, retValue[1], isMax) : GetCommonValue(arrPos + 1, retValue[0], isMax);
            }

            return isMax ? GetCommonValue(arrPos + 1, retValue[0], isMax) : GetCommonValue(arrPos + 1, retValue[1], isMax);
        }
    }
}