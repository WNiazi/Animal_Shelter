using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
// We'll use LINQ to grab values from our dataset and display them in our views

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;
    //sets value of new db value and it works due to dependecy injection

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.ToList();
      //LINQ translates the dataset into a list we can use in the view  (this is the ToList)
      return View(model);
      //this is instead of GetAll 
    }
    //GET Create -display form to user  (similar to NEW())
    public ActionResult Create()
    {
      return View();
    }
    //POST CREATE -manage form submission 
    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      //adds animal to list 
      _db.SaveChanges();
      //save changes 
      return RedirectToAction("Index");
      //puts it in index
    }

    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }

    public ActionResult Edit(int id)
    {
      var thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }

    // [HttpPost]
    // public ActionResult Edit(Item item)
    // {
    //   _db.Entry(item).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    //   return View(thisItem);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    //   _db.Items.Remove(thisItem);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}