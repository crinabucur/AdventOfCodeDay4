internal class Program
{
    public static void Main()
    {
        var numberOfFullyContainedTeamAssignments = 0;
        var numberOfOverlapsInSameTeamAssignments = 0;
        
        foreach (var line in File.ReadLines(@"C:\Users\CrinaBucur\input.txt"))
        {
            var teamAssignments = line.Split(',');
            var firstElfRange = teamAssignments[0].Split('-').Select(int.Parse).ToList();
            var secondElfRange = teamAssignments[1].Split('-').Select(int.Parse).ToList();

            if ((firstElfRange[0] <= secondElfRange[0] && firstElfRange[1] >= secondElfRange[1]) ||
                (secondElfRange[0] <= firstElfRange[0] && secondElfRange[1] >= firstElfRange[1]))
            {
                numberOfFullyContainedTeamAssignments++;
                numberOfOverlapsInSameTeamAssignments++;
            }
            else if ((firstElfRange[0] <= secondElfRange[0] && firstElfRange[1] >= secondElfRange[0]) ||
                     (secondElfRange[0] <= firstElfRange[0] && secondElfRange[1] >= firstElfRange[0]))
            {
                numberOfOverlapsInSameTeamAssignments++;
            }
        }

        Console.WriteLine("Number of assignment pairs where one range fully contains the other: {0} ", numberOfFullyContainedTeamAssignments);
        Console.WriteLine("Number of overlaps in same team assignments: {0} ", numberOfOverlapsInSameTeamAssignments);
        Console.ReadLine();
    }
}