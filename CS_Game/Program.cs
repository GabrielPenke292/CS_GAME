using System;

public class CS_Game
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao CS Game!");
        Console.WriteLine("############################");

        Console.Write("Inform How many teams do you want to create -> ");
        int number_of_teams = Int32.Parse(Console.ReadLine());

        Team[] teams = new Team[number_of_teams];

        for (int i = 0; i < number_of_teams; i++)
        {
            teams[i] = new Team();
            Console.Write("What's the name of team: ");
            teams[i].name = Console.ReadLine();

            Console.Write("What's the country of team: ");
            teams[i].country = Console.ReadLine();
            
            Console.WriteLine();
        }

        for (int i = 0; i < number_of_teams; ++i)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Team's name: {teams[i].name}");
            Console.WriteLine($"Team's country: {teams[i].country}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }

    }
}