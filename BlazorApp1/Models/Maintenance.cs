using BlazorApp1.Components.Pages;

namespace BlazorApp1.Models
{
    public class Maintenance
    {
        public int maintenance_id { get; set; }

        public int worker_id { get; set; }

        public Worker? Worker { get; set; }

        public int transport_id { get; set; }

        public Transport? Transport { get; set; }

        public int repair_id { get; set; }

        public Repair? Repair { get; set; }

        public double price { get; set; }

        public int mileage { get; set; }

        public string date { get; set; }

    }
}
