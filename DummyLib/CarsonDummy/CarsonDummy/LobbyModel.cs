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

namespace CarsonDummy
{
	/// <summary>
	/// Simple Gamelobby.
	/// </summary>
	public class LobbyModel
	{
		public Guid LobbyId { get; private set; }
		public Guid HostId { get; private set; }
		public List<PlayerModel> PlayersInLobby { get; private set;}
		
		
		public LobbyModel(Guid hostId, Guid lobbyId)
		{
			LobbyId = lobbyId;
			HostId = hostId;
			PlayersInLobby = new List<PlayerModel>();
		}
		
	}
}
