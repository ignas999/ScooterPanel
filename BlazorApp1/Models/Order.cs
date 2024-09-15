namespace BlazorApp1.Models
{
	public class Order
	{
		public int order_id { get; set; }

		public int user_id { get; set; }
		public User? User { get; set; }
		public int transport_id { get; set; }
		public Transport? Transport { get; set; }
		public int status_id { get; set; }
		public Status? Status { get; set; }
		public double amount { get; set; }
		public DateTime start_date { get; set; }
		public DateTime end_date { get; set; }
	}
}
