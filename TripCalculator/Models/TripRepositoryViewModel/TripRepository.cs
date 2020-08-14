using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TripCalculator.Models.TripRepositoryViewModel
{
	public class TripRepository : ITripRepository
	{		
		private List<TripTransaction> allTransactions;
		private string jsonFile = Path.Combine("GlobalVar.webroot", @"App_Data/TripTransactionsData.json");

		public TripRepository()//IHostingEnvironment env
		{
			try
			{
				//_env = env;
				allTransactions = new List<TripTransaction>();
				if (File.Exists(jsonFile))
				{
					var json = File.ReadAllText(jsonFile);
					allTransactions = JsonConvert.DeserializeObject<List<TripTransaction>>(json);
				}
				else
				{
					string json = JsonConvert.SerializeObject(allTransactions);
					File.WriteAllText(jsonFile, json);
				}
			}
			catch (Exception ex) { }
		}

		public IEnumerable<TripTransaction> GetAllTransactions()
		{
			return allTransactions;
		}

		public void AddTraveler(TripCalc traveler)
		{
			string path = Path.Combine("GlobalVar.webroot", @"App_Data/TripTransactionsData.json");
			//allTransactions.Add(traveler);
			string json = JsonConvert.SerializeObject(allTransactions);
			File.WriteAllText(path, json);
		}

		public void AddTransaction(TripTransaction transaction)
		{
			string path = Path.Combine("GlobalRC.webroot", @"App_Data/TripTransactionsData.json");
			allTransactions.Add(transaction);
			string json = JsonConvert.SerializeObject(allTransactions);
			File.WriteAllText(path, json);
		}

	}
}
