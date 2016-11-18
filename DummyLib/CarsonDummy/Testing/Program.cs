/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 11.11.2016
 * Time: 16:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using CarsonDummy;
using CarsonDummy.Services;

namespace Testing
{
	class Program
	{
		
		static IPlayerService playerService = PlayerService.Instance;
		static ILobbyService lobbyService = LobbyService.Instance;
		
		//Testing clientToken
		const string clientToken = "79f1913f3e1603b71bbbc6faaf4fadf9";
		
		public static void Main(string[] args)
		{
			var nPlayer = playerService.CreatePlayer("Player_01");
			var nLobby = lobbyService.CreateNewLobby(nPlayer.ClientToken, "");
			
			Console.WriteLine(string.Format("Playername: {0}\nToken: {1}",nPlayer.PlayerName,nPlayer.ClientToken));
			Console.WriteLine(string.Format("LobbyId: {0}\nHostId = {1}",nLobby.LobbyId, nLobby.HostId));
			Console.ReadLine();
		}
	}
}