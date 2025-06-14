using System;

public class CS_Game
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao CS Game!");
        Console.WriteLine("############################");

        Console.Write("Informe quantos times você quer criar -> ");
        int number_of_teams = Int32.Parse(Console.ReadLine());

        Team[] teams = new Team[number_of_teams];

        for (int i = 0; i < number_of_teams; i++)
        {
            teams[i] = new Team();
            Console.Write("Nome do time: ");
            teams[i].Name = Console.ReadLine();

            Console.Write("País do time: ");
            teams[i].Country = Console.ReadLine();
            
            Console.WriteLine("\nAgora vamos adicionar os 5 jogadores do time:");
            
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"\nJogador {j + 1}:");
                Console.Write("Nome do jogador: ");
                string playerName = Console.ReadLine();
                
                Console.Write("Idade do jogador: ");
                int playerAge = Int32.Parse(Console.ReadLine());
                
                Console.Write("Posição do jogador: ");
                string playerPosition = Console.ReadLine();
                
                Player player = new Player(playerName, playerAge, playerPosition);
                teams[i].AddPlayer(player);
            }
            
            Console.WriteLine();
        }

        // Exibindo informações dos times e jogadores
        for (int i = 0; i < number_of_teams; i++)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Time: {teams[i].Name}");
            Console.WriteLine($"País: {teams[i].Country}");
            Console.WriteLine("\nJogadores:");
            
            foreach (Player player in teams[i].GetPlayers())
            {
                Console.WriteLine($"- {player.Name} ({player.Position}), {player.Age} anos");
            }
            
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }
}