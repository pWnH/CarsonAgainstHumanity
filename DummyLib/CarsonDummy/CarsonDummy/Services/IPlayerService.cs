﻿/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 15.11.2016
 * Time: 16:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CarsonDummy.Services
{
	/// <summary>
	/// Description of IPlayerService.
	/// </summary>
	public interface IPlayerService
	{
		PlayerModel CreatePlayer(string playerName);
		
		PlayerModel ReadPlayer(Guid playerId);
		PlayerModel ReadPlayer(string playerName);
		
		List<PlayerModel> GetPlayers(ICollection<Guid> playerIds);
		
		void UpdatePlayer(Guid playerId, string playerName, int score, bool hasPlayed);
		void ReadPlayerLobby(Guid playerId);
	}
}
