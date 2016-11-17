/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 14.11.2016
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CarsonDummy
{
	/// <summary>
	/// Description of Card.
	/// </summary>
	public class Card
	{
		public int Id;
		public bool IsBlack;
		public string CardText;
		
		public Card(int id)
		{
			//hole daten aus datenbank?
			Id = id;
			CardText = "TEST_" + id;
			IsBlack = id % 2 == 0;
		}
	}
}
