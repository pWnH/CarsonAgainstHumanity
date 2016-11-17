using System;
using Newtonsoft.Json;

namespace CarsonDummy
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public class PlayerModel
	{
		public Guid PlayerId {get; private set;}
		public string PlayerName {get; set;}
		public int Score { get; set; }
		public bool HasPlayed { get; set; }
		
		public PlayerModel(string playername, Guid id)
		{
			PlayerName = playername;
			PlayerId = id;
			HasPlayed = false;
			Score = 0;
		}
		
		[JsonConstructor]
		public PlayerModel(Guid playerId){
			PlayerId = playerId;
		}
	}
}
