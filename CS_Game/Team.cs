using System;
using System.Collections.Generic;
using System.Security.Principal;

public class Team
{
	public string Name { get; set; }
	public string Country { get; set; }
	private List<Player> players;

	public Team()
	{
		players = new List<Player>();
	}

	public void AddPlayer(Player player)
	{
		if (players.Count < 5)
		{
			player.Team = this;
			players.Add(player);
		}
		else
		{
			throw new Exception("O time já possui 5 jogadores!");
		}
	}

	public List<Player> GetPlayers()
	{
		return players;
	}

	public bool IsTeamComplete()
	{
		return players.Count == 5;
	}
}
