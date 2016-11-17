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
		Guid CreateNewLobby(Guid hostId, string name);
		bool DeleteLobby(Guid lobbyId);
		LobbyModel ReadLobby(Guid lobbyId);
		List<LobbyModel> ReadLobbys(List<Guid> lobbyIds);
		bool AddToLobby(Guid lobbyId, Guid playerId);
		
	}
}
