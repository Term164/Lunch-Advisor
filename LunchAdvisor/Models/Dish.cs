namespace LunchAdvisor.Models
{
    public class Dish
    {
        public int ID { get; set; }
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string? ImageURL { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public virtual ICollection<DishRating>? DishRatings { get; set; }

    }
}
