using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")] 
    public ActionResult Welcome() { return View(); }
    [Route("/monkey/form")]
    public ActionResult MonkeyForm() { return View(); }
    [Route("/monkey")]
    public ActionResult Monkey(string kingName, string natureLocation, string adjective1, string adjective2, string weaponAdjective, string weapon, string animal, string animalHeroName, string heroWeapon) 
    { 
      Monkey monkey = new Monkey();
      monkey.KingName = kingName;
      monkey.NatureLocation = natureLocation;
      monkey.Adjective1 = adjective1;
      monkey.Adjective2 = adjective2;
      monkey.WeaponAdjective = weaponAdjective;
      monkey.Weapon = weapon;
      monkey.Animal = animal;
      monkey.AnimalHeroName = animalHeroName;
      monkey.HeroWeapon = heroWeapon;
      return View(monkey); 
    }
  }
}