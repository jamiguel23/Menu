namespace Menu.Models
{
    public class DishIngredient
    {
        public int IngredientId { get; set; }
        public Dish Dish {  get; set; }
        public int DishId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
