using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripCalculator.Models.TripRepositoryViewModel
{
	public class TripTransaction
	{
		public string TransactionId { get; set; } = new Guid().ToString();
		public string PersonId { get; set; }
		public string TransDescription { get; set; }
		public double Amount { get; set; }
		public DateTime Created { get; set; } = DateTime.Now;
	}
}
