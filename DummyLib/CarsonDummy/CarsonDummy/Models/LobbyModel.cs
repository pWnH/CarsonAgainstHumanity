/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 14.11.2016
 * Time: 14:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CarsonDummy
{
	/// <summary>
	/// Simple Gamelobby.
	/// </summary>
	public class LobbyModel
	{
		public string LobbyId { get; private set; }
		public string HostId { get; set; }
		public List<PlayerModel> PlayersInLobby { get; private set;}
		
		public string GameName { get; private set; }
		public State CurrentState { get; private set; }
		public Guid JudgeId { get; private set; }
		public int CurrentTurn { get; private set; }
		
		[JsonConstructor]
		public LobbyModel(string hostId, string lobbyId)
		{
			LobbyId = lobbyId;
			HostId = hostId;
			PlayersInLobby = new List<PlayerModel>();
			CurrentState = State.InLobby;
		}	
	}
}
