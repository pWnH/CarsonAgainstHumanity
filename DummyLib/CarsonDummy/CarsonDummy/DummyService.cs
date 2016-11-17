using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CarsonDummy.Services;

namespace CarsonDummy
{
	/// <summary>
	/// Description of DummyService.
	/// </summary>
	public class DummyService
	{
		ILobbyService lobbyService = LobbyService.Instance;
		IPlayerService playerService = PlayerService.Instance;
		private const string lobbynames = "NewLobby_";
		private static int counter;
		
		
		public string CreatePlayer(string name){
			var playerModel = playerService.CreatePlayer(name);
			return JsonConvert.SerializeObject(playerModel);
		}
		
		public string CreateLobby(Guid clientToken){
			var tempLobby = lobbyService.CreateNewLobby(clientToken, lobbynames + counter);
			return JsonConvert.SerializeObject(tempLobby);
		}
		
		public string GetLobbyState(){
			return "";
		}
		
		public string JoinLobby(Guid lobbyId, Guid clientToken){
			var response = JsonConvert.SerializeObject(lobbyService.AddToLobby(lobbyId, clientToken));
			
			return response;
		}
		
	}
}
