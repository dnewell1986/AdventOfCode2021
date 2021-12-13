// See https://aka.ms/new-console-template for more information
using AdventDay3;

var powerConsumptionRate = SolvePartOne();
Console.WriteLine(powerConsumptionRate);

int SolvePartOne()
{
    var binStringLength = Input.diagReport.First().Length;
    var gammaRate = new string[binStringLength];
    var epsilonRate = new string[binStringLength];
    
    var currentStringPosition = 0;

    for(var x = 0; x < binStringLength; x++)
    {
        var oneCount = 0;
        var zeroCount = 0;
        for(var i = 0; i < Input.diagReport.Count; i++)
        {
            if (Input.diagReport[i].ToArray()[x] == '1') 
            {
                oneCount++;
            }
            else
            {
                zeroCount++;
            }
        }
        if (oneCount > zeroCount)
        {
            gammaRate[x] = "1";
            epsilonRate[x] = "0";
        }
        else 
        {
            gammaRate[x] = "0";
            epsilonRate[x] = "1";
        }
    }

    var gamma = Convert.ToInt32(string.Join("", gammaRate), 2);
    var epsilon = Convert.ToInt32(string.Join("", epsilonRate), 2);
    
    return gamma * epsilon;
}
