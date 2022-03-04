using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  //extension 
  {
    public DbSet<Animal> Animals { get; set; }
    //the blue is the table name
    //green is the class
    public AnimalShelterContext(DbContextOptions options) : base(options) { }
    //helps with constructor, constructor behavior for class
  }
}

//calling on Entity to do the work for us, calling on db database