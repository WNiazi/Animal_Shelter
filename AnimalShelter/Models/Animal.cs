//using System.Collections.Generic;
namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    // We no longer need to add verbose database-backed methods like Find() and Save(). Entity will take care of this for us!
    public string Type { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string DateOfAdmit { get; set; }
    public string Breed { get; set; }
  }
}

// public Animal(string type, string name, int id, string gender, string dateOfAdmit, string breed)
// {
//   type = Type;
//   gender = Gender;
//   dateOfAdmit = DateOfAdmit;
//   breed = Breed;

// }
//you don't have to do the above anymore and it doesn't seem like we need a list at this time due to sql
