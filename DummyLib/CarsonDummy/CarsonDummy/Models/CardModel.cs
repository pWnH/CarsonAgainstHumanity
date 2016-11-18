/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 14.11.2016
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Newtonsoft.Json;

namespace CarsonDummy
{
	/// <summary>
	/// Description of Card.
	/// </summary>
	public class CardModel
	{
		public int Id { get; private set; }
		public bool IsBlack { get; private set; }
		public string CardText { get; private set; }
		
		
		[JsonConstructor]
		public CardModel(int id, string cardText, bool isBlack)
		{
			Id = id;
			CardText = cardText;
			IsBlack = isBlack;
		}
	}
}
