using System;

public class CS_Game
{
    public static void Main(string[] args)
    {
        CS_Game game = new CS_Game();
        game.showMenu();

        // Inicializando o jogo
        // Console.WriteLine("Bem vindo(a) ao CS Game!");
        // Console.WriteLine("############################");

        // Console.Write("Informe quantos times você quer criar -> ");
        // int number_of_teams = Int32.Parse(Console.ReadLine());

        // Team[] teams = new Team[number_of_teams];

        // for (int i = 0; i < number_of_teams; i++)
        // {
        //     teams[i] = new Team();
        //     Console.Write("Nome do time: ");
        //     teams[i].Name = Console.ReadLine();

        //     Console.Write("País do time: ");
        //     teams[i].Country = Console.ReadLine();
            
        //     Console.WriteLine("\nAgora vamos adicionar os 5 jogadores do time:");
            
        //     for (int j = 0; j < 5; j++)
        //     {
        //         Console.WriteLine($"\nJogador {j + 1}:");
        //         Console.Write("Nome do jogador: ");
        //         string playerName = Console.ReadLine();
                
        //         Console.Write("Idade do jogador: ");
        //         int playerAge = Int32.Parse(Console.ReadLine());
                
        //         Player player = new Player(playerName, playerAge);
        //         teams[i].AddPlayer(player);
        //     }
            
        //     Console.WriteLine();
        // }

        // // Exibindo informações dos times e jogadores
        // for (int i = 0; i < number_of_teams; i++)
        // {
        //     Console.WriteLine("-----------------------------");
        //     Console.WriteLine($"Time: {teams[i].Name}");
        //     Console.WriteLine($"País: {teams[i].Country}");
        //     Console.WriteLine("\nJogadores:");
            
        //     foreach (Player player in teams[i].GetPlayers())
        //     {
        //         Console.WriteLine($"- {player.Name}, {player.Age} anos");
        //     }
            
        //     Console.WriteLine("-----------------------------");
        //     Console.WriteLine();
        // }


    }

    public void showMenu() {
        int option = -1;
        while (option != 0) {
            // criando o menu
            Console.WriteLine("Bem vindo(a) ao CS Game!");
            Console.WriteLine("############################");
            Console.WriteLine("1 - Criar um time");
            Console.WriteLine("2 - Ver times");
            Console.WriteLine("3 - Adicionar jogador");
            Console.WriteLine("4 - Mostrar todos os times e jogadores");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            option = Int32.Parse(Console.ReadLine());
            verifyUserOption(option);
        }
    }

    public void verifyUserOption(int option) {
        switch (option) {
            case 1:
                createTeam();
                break;
            case 2:
                showTeams();
                break;
            case 3:
                addPlayer();
                break;
            case 4:
                showAllTeamsAndPlayers();
                break;
            case 0:
                Console.WriteLine("Saindo do jogo...");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }

    public void createTeam() {
        Console.WriteLine("############################");
        Console.WriteLine("Criando um time");
        Console.WriteLine("############################");
        string teamName = "";   
        while (teamName == "") {
            Console.Write("Informe o nome do time: ");
            teamName = Console.ReadLine();
        }

        string teamCountry = "";
        while (teamCountry == "") {
            Console.Write("Informe o país do time: ");
            teamCountry = Console.ReadLine();
        }

        Team team = new Team(teamName, teamCountry);
        Console.WriteLine("Time criado com sucesso!");
        Console.WriteLine();
        Console.WriteLine("############################");
        Console.WriteLine();
    }

    public void showTeams() {
        Console.WriteLine("############################");
        Console.WriteLine("Mostrando times");
        Console.WriteLine("############################");
        Team[] teams = new Team[0];
        foreach (Team team in teams) {
            Console.WriteLine($"Time: {team.Name}");
            Console.WriteLine($"País: {team.Country}");
            Console.WriteLine("Jogadores:");
            foreach (Player player in team.GetPlayers()) {
                Console.WriteLine($"- {player.Name}, {player.Age} anos");
            }
            Console.WriteLine();
            Console.WriteLine("############################");
            Console.WriteLine();
        }
    }

    public void addPlayer() {
        Console.WriteLine("Adicionando um jogador");
    }

    public void showAllTeamsAndPlayers() {
        Console.WriteLine("Mostrando todos os times e jogadores");
    }
}