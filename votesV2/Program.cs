﻿using System;

namespace Votes
{
    class Program
    {
        static void Main(string[] args)
        {
            int votesResult = 0;
            int votesCount = 0;
            string vote = Console.ReadLine();

            while (vote != "stop")
            {
                votesCount++;

                if (vote == "up")
                {
                    votesResult++;
                }
                else
                {
                    votesResult--;               }

                
                vote = Console.ReadLine();
            }
            Console.WriteLine(votesResult + " " + votesCount);

            Console.ReadLine();
        }
    }
}

