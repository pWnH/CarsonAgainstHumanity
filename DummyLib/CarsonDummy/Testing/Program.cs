/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 11.11.2016
 * Time: 16:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using CarsonDummy;
using CarsonDummy.Services;
using Newtonsoft.Json;

namespace Testing
{
	class Program
	{
		public static void Main(string[] args)
		{
			var dummy = new DummyService();
			
			var hansJson = dummy.CreatePlayer("Hans");
			var hans = JsonConvert.DeserializeObject<PlayerModel>(hansJson);
			
			Console.WriteLine(hansJson);
			Console.WriteLine("\n\n" + hans.PlayerId);
			Console.ReadKey();
		}
	}
}