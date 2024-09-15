using BlazorApp1.Components.Pages;

namespace BlazorApp1.Models
{
    public class Transport
    {
        public int transport_id { get; set; }
        public int status_id { get; set; }
        public Status? Statuses { get; set; }
        public int location_id { get; set; }
        public Location? Locations { get; set; }
        public int category_id { get; set; }
        public Category? Categories { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int rated_power { get; set; }
        public int max_speed { get; set; }
        public int distance { get; set; }
        public double price { get; set; }
    }
}
