/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 14.11.2016
 * Time: 13:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CarsonDummy
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public class Settings
	{
		Gamemode CurrentGamemode = Gamemode.Normal;
		int TargetScore { get; set; }
		int[] CardPacks { get; set; }
		int Kicktimer { get; set; }
		
		public Settings()
		{
		
		}
	}
}
