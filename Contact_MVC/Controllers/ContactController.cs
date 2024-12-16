using Contact_MVC.Models;
using Contact_MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Contact_MVC.Controllers;

public class ContactController : Controller
{
    private ContactRepository _contactRepository;
    public ContactController()
    {
        this._contactRepository = new ContactRepository();
    }

    public IActionResult GetContact()
    {
        if (TempData["Contact"] is not null)
        {
            var contact = JsonConvert.DeserializeObject<Contact>(TempData["Contact"].ToString());
            _contactRepository.AddContact(contact);
        }
        return View("Index");
    }
    public IActionResult Index()
    {
        return View(this._contactRepository.GetContacts());
    }
    
}