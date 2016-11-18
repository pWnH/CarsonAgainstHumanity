/*
 * Created by SharpDevelop.
 * User: L.Schnitzmeier
 * Date: 18.11.2016
 * Time: 14:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace CarsonDummy.Services
{
	/// <summary>
	/// Description of ApiService.
	/// </summary>
	public static class ApiHelper
	{
		#region IApiService implementation

		public static object GetRequest<T>(WebRequest request)
		{
			T obj;
			var responseStream = request.GetResponse().GetResponseStream();
			
			StreamReader objReader = new StreamReader(responseStream);
			string json = "";
			string sLine = "";
			int i = 0;

			while (sLine!=null)
			{
				i++;
				sLine = objReader.ReadLine();
				if (sLine!=null)
					json += sLine;
			}
			
			obj = JsonConvert.DeserializeObject<T>(json);
			
			return obj;
		}

		#endregion
	}
}
