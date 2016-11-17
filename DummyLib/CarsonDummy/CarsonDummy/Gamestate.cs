/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 14.11.2016
 * Time: 13:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CarsonDummy
{
	/// <summary>
	/// Description of Gamestate.
	/// </summary>
	public class Gamestate
	{
		public State CurrentState;
		public Guid JudgeId;
		public List<PlayerModel> Players;
		public Guid HostId;
		public int CurrentTurn;
		
		public Gamestate()
		{
		}
	}
}
