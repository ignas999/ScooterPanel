namespace BlazorApp1.Models
{
	public class Transaction
	{
		public int transaction_id { get; set; }

		public int user_id { get; set; }

		public double amount { get; set; }

		public int worker_id { get; set; }

		public string date { get; set; }
	}
}
