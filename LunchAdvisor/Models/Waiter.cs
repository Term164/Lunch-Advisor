namespace LunchAdvisor.Models
{
    public class Waiter
    {
        public int ID { get; set; }
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public virtual ICollection<WaiterRating>? WaiterRatings { get; set; }
    }
}
