/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 15.11.2016
 * Time: 16:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;


namespace CarsonDummy.Services
{
	/// <summary>
	/// Description of ILobbyService.
	/// </summary>
	public interface ILobbyService
	{		
		LobbyModel CreateNewLobby(string hostId, string name);
		LobbyModel CreateNewLobby(string hostId);
		bool DeleteLobby(string lobbyId);
		LobbyModel ReadLobby(string lobbyId);
		List<LobbyModel> ReadLobbys(List<string> lobbyIds);
		bool AddToLobby(string lobbyId, string clientToken);
		
	}
}
