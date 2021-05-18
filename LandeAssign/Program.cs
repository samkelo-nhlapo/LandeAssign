using System;
using System.Collections.Generic;

namespace LandeAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int votesForCandidateA = 0;
            int votesForCandidateB = 0;
            int votesForCandidateC = 0;
            int spoiltVotes = 0;
            int votingStations = 4;
            int count = 1;

            //counting the number of voting stations
            for (var i = 1; i < votingStations + 1; i++)
            {
                Console.WriteLine("voting station "+ count++);                
                
                string promptingMessage = "press 'a' to vote for (A),press 'b' to vote for (B),press 'c' to vote for (C),press 'X' to Exit\n";
                
                //promting the user to vote for a candidate
                while (promptingMessage != "x".ToLower() && count <= votingStations + 1)
                {
                    Console.Write("press 'a' to vote for candidate (A),press 'b' to vote for candidate (B),press 'c' to vote for candidate (C),press 'X' to Exit\n");
                    promptingMessage = Console.ReadLine();

                    //incrementing the candidates votes when voted for 
                    if (promptingMessage == "a")
                    {
                        votesForCandidateA++;
                    }
                    else if (promptingMessage == "b")
                    {
                        votesForCandidateB++;
                    }
                    else if (promptingMessage == "c")
                    {
                        votesForCandidateC++;
                    }
                    else if (promptingMessage != "x")
                    {
                        spoiltVotes++;
                    }
                }
            }
            //printing out the total votes for all candidates
            Console.WriteLine("Total Votes:");
            Console.WriteLine($"total candidate A: {votesForCandidateA}\nTotal candidate B: {votesForCandidateB}\nTotal candidate C: {votesForCandidateC}\nTotal spoilt votes: {spoiltVotes}");
        }
    }
}
