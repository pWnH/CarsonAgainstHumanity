using System;
using Newtonsoft.Json;

namespace CarsonDummy
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public class PlayerModel
	{
		public string ClientToken { get; private set; }
		public string PlayerName { get; set; }
		public int Score { get; set; }
		public bool HasPlayed { get; set; }
		
		public PlayerModel(string playerName, string clientToken)
		{
			PlayerName = playerName;
			ClientToken = clientToken;
			HasPlayed = false;
			Score = 0;
		}
		
		[JsonConstructor]
		public PlayerModel(string clientToken){
			ClientToken = clientToken;
		}
	}
}
