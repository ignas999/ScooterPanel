namespace BlazorApp1.Models
{
    public class Finances
    {
        public double amount;
        public string dateofaction;
        public string description;

        public Finances(double amount, string dateofaction, string description)
        {
            this.amount = amount;
            this.dateofaction = dateofaction;
            this.description = description;
        }
    }
}
