using System.Text.Json.Serialization;
using Contact_MVC.Models;
using Contact_MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Contact_MVC.Controllers;

public class FormController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Submit(Contact contact)
    {
        if (ModelState.IsValid)
        {
            TempData["Contact"] = JsonConvert.SerializeObject(contact);
            return RedirectToAction("GetContact", "Contact");
        }
    
        return View(contact);
    }
}