using Contact_MVC.Models;
using Contact_MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Contact_MVC.Controllers;

public class ContactController : Controller
{

    public IActionResult GetContact()
    {
        if (TempData["Contact"] is not null)
        { 
            var contact = JsonConvert.DeserializeObject<Contact>(TempData["Contact"].ToString());
            ContactRepository.AddContact(contact);
        }

        return RedirectToAction("Index");
    }
    public IActionResult Index()
    {
        return View(ContactRepository.GetContacts());
    }
    
}

// data annotation, tag helper, data bos gelende hansi input bosdursa ekranda gostersin, limit qoymaq saya, error message tag helperle