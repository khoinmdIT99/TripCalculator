using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripCalculator.Models.TripRepositoryViewModel
{
	public interface ITripRepository
	{
		IEnumerable<TripTransaction> GetAllTransactions();
		void AddTransaction(TripTransaction transaction);
	}
}
