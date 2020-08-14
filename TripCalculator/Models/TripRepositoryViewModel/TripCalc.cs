using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripCalculator.Models.TripRepositoryViewModel
{
	public class TripCalc
	{
		public string PersonId { get; set; }
		public string FullName { get; set; }
		public double? Balance { get; set; }
		public DateTime? LastModified { get; set; } = DateTime.Now;
		public List<TripTransaction> TransactionList { get; set; }

		public TripCalc()
		{
			this.PersonId = null;
			this.FullName = null;
			this.Balance = null;
			this.LastModified = null;
			this.TransactionList = null;
		}

		public TripCalc(string personId, string fullName, double balance, DateTime lastModified, List<TripTransaction> transactionList)
		{
			this.PersonId = personId;
			this.FullName = fullName;
			this.Balance = balance;
			this.LastModified = lastModified;
			this.TransactionList = transactionList;
		}
	}
}
