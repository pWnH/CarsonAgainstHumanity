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
using System.Net;

namespace CarsonDummy.Services
{
	/// <summary>
	/// Description of PlayerService
	/// </summary>
	public class PlayerService : IPlayerService
	{
		
		const string url = "http://cah.heretics.de/game/";
		
		#region IPlayerService implementation
		
		public static List<PlayerModel> AllPlayers = new List<PlayerModel>();
		
		private static IPlayerService instance;
        public static IPlayerService Instance { get { return instance ?? (instance = new PlayerService()); } }

		public PlayerModel CreatePlayer(string playerName)
		{
			//Create WebRequest for API
			var req = WebRequest.Create(string.Format("{0}authenticate?name={1}",url,playerName));
			req.ContentType = "application/json; charset=utf-8";
			
			var nPlayer = (PlayerModel)ApiHelper.GetRequest<PlayerModel>(req);
			
			//Set the player name 
			nPlayer.PlayerName = playerName;
			
			//Add to player list of service
			AllPlayers.Add(nPlayer);
			
			return nPlayer;
		}
	
		public PlayerModel ReadPlayer(string clientToken)
		{
			return AllPlayers.Find(x => x.ClientToken == clientToken);
		}
		
		public List<PlayerModel> GetPlayers(ICollection<string> clientTokens)
		{
			var rList = new List<PlayerModel>();
			foreach(var id in clientTokens){
				rList.Add(AllPlayers.Find(x=> x.ClientToken == id));
			}
			
			return rList;
		}
	
		public void UpdatePlayer(string clientToken, string playerName, int score, bool hasPlayed)
		{
			var temp = AllPlayers.Find(x => x.ClientToken == clientToken);
			if(playerName != string.Empty)
				temp.PlayerName = playerName;
			temp.Score = score;
			temp.HasPlayed = hasPlayed;
		}
	
		public void ReadPlayerLobby(string clientToken)
		{
			throw new NotImplementedException();
		}
	
		#endregion


		
	}
}
