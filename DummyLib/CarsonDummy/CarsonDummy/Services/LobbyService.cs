/*
 * Created by SharpDevelop.
 * User: Schaltzentrale
 * Date: 15.11.2016
 * Time: 18:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CarsonDummy.Services
{
	/// <summary>
	/// Description of LobbyService.
	/// </summary>
	public class LobbyService : ILobbyService
	{
		static List<LobbyModel> AllLobbyModels = new List<LobbyModel>();
		
		IPlayerService playerService = PlayerService.Instance;
		
		private static ILobbyService instance;
		public static ILobbyService Instance { get { return instance ?? (instance = new LobbyService()); } }

		#region ILobbyService implementation

		public Guid CreateNewLobby(Guid hostId, string name)
		{
			var temp = new LobbyModel(hostId, Guid.NewGuid());
			
			AllLobbyModels.Add(temp);
			
			return temp.LobbyId;
		}

		public List<LobbyModel> ReadLobbys(List<Guid> lobbyIds)
		{
			var rLobbys = new List<LobbyModel>();
			
			foreach(var id in lobbyIds){
				rLobbys.Add(AllLobbyModels.Find(x => x.LobbyId == id));
			}
			
			return rLobbys;
		}
		
		public bool DeleteLobby(Guid lobbyId)
		{
			var rLobby = AllLobbyModels.Find(x => x.LobbyId == lobbyId);
			
			if(rLobby == null) return false;
			
			return AllLobbyModels.Remove(rLobby);
		}
		
		public LobbyModel ReadLobby(Guid lobbyId){
			return AllLobbyModels.Find(x => x.LobbyId == lobbyId);
		}
		
		public bool AddToLobby(Guid lobbyId, Guid playerId){
			var lobby = ReadLobby(lobbyId);
			var player = playerService.ReadPlayer(playerId);
			
			lobby.PlayersInLobby.Add(player);
			return true;
		}
		#endregion
	}
}
