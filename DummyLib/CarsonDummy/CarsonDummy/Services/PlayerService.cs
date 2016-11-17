/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 15.11.2016
 * Time: 16:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CarsonDummy.Services
{
	/// <summary>
	/// Description of PlayerService
	/// </summary>
	public class PlayerService : IPlayerService
	{
		#region IPlayerService implementation
		
		public static List<PlayerModel> AllPlayers = new List<PlayerModel>();
		
		private static IPlayerService instance;
        public static IPlayerService Instance { get { return instance ?? (instance = new PlayerService()); } }

		public PlayerModel CreatePlayer(string playerName)
		{
			var n = new PlayerModel(playerName, Guid.NewGuid());
			AllPlayers.Add(n);
			return n;
		}
	
		public PlayerModel ReadPlayer(Guid playerId)
		{
			return AllPlayers.Find(x => x.PlayerId == playerId);
		}
	
		public PlayerModel ReadPlayer(string playerName)
		{
			return AllPlayers.Find(x => x.PlayerName == playerName);
		}
	
		public List<PlayerModel> GetPlayers(ICollection<Guid> playerIds)
		{
			var rList = new List<PlayerModel>();
			foreach(var id in playerIds){
				rList.Add(AllPlayers.Find(x=> x.PlayerId == id));
			}
			
			return rList;
		}
	
		public void UpdatePlayer(Guid playerId, string playerName, int score, bool hasPlayed)
		{
			var temp = AllPlayers.Find(x => x.PlayerId == playerId);
			if(playerName != string.Empty)
				temp.PlayerName = playerName;
			temp.Score = score;
			temp.HasPlayed = hasPlayed;
		}
	
		public void ReadPlayerLobby(Guid playerId)
		{
			throw new NotImplementedException();
		}
	
		#endregion


		
	}
}
