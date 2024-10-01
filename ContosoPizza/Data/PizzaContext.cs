using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data;

public class PizzaContext : DbContext
{
    public PizzaContext (DBContextOptions<PizzaContext> options)
        : base(options)
}
{
    public DbSet<Pizza> Pizzas => Set<Pizza>();
    public DbSet<Toppings> Toppings => Set<Topping>()
    public DbSet<Sauce> Sauces => Set<Sauce>();
}