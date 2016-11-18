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
using System.Net;
using Newtonsoft.Json;

namespace CarsonDummy.Services
{
	/// <summary>
	/// Description of LobbyService.
	/// </summary>
	public class LobbyService : ILobbyService
	{
		//API url
		const string url = "http://cah.heretics.de/game/";
		
		static List<LobbyModel> AllLobbyModels = new List<LobbyModel>();
		
		IPlayerService playerService = PlayerService.Instance;
		
		private static ILobbyService instance;
		public static ILobbyService Instance { get { return instance ?? (instance = new LobbyService()); } }

		#region ILobbyService implementation

		public LobbyModel CreateNewLobby(string hostId)
		{
			var req = WebRequest.Create(string.Format("{0}create-lobby?clientToken={1}",url,hostId));
			req.ContentType = "application/json; charset=utf-8";
			
			var nLobby = (LobbyModel)ApiHelper.GetRequest<LobbyModel>(req);
			
			if(nLobby != null){
				var host = playerService.ReadPlayer(hostId);
				nLobby.PlayersInLobby.Add(host);
				nLobby.HostId = host.ClientToken;
				
				AllLobbyModels.Add(nLobby);
			}
			
			return nLobby;
		}
		
		public LobbyModel CreateNewLobby(string hostId, string name)
		{
			var req = WebRequest.Create(string.Format("{0}create-lobby?clientToken={1}&gameName={2}",url,hostId, name));
			req.ContentType = "application/json; charset=utf-8";
			
			var nLobby = (LobbyModel)ApiHelper.GetRequest<LobbyModel>(req);
			
			if(nLobby != null){
				var host = playerService.ReadPlayer(hostId);
				nLobby.PlayersInLobby.Add(host);
				nLobby.HostId = host.ClientToken;
				nLobby.GameName = name;
				
				AllLobbyModels.Add(nLobby);
			}
			
			return nLobby;
		}

		public List<LobbyModel> ReadLobbys(List<string> lobbyIds)
		{
			var rLobbys = new List<LobbyModel>();
			
			foreach(var id in lobbyIds){
				rLobbys.Add(AllLobbyModels.Find(x => x.LobbyId == id));
			}
			
			return rLobbys;
		}
		
		public bool DeleteLobby(string lobbyId)
		{
			var rLobby = AllLobbyModels.Find(x => x.LobbyId == lobbyId);
			
			if(rLobby == null) return false;
			
			return AllLobbyModels.Remove(rLobby);
		}
		
		public LobbyModel ReadLobby(string lobbyId){
			return AllLobbyModels.Find(x => x.LobbyId == lobbyId);
		}
		
		public bool AddToLobby(string lobbyId, string clientToken){
			var lobby = ReadLobby(lobbyId);
			var player = playerService.ReadPlayer(clientToken);
			
			lobby.PlayersInLobby.Add(player);
			return true;
		}
		#endregion
	}
}
