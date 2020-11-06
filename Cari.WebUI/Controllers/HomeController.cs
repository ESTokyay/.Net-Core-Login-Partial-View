using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cari.Business.Abstract;
using Cari.Entities.Concrete;
using Cari.WebUI.Library;
using Cari.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cari.WebUI.Controllers
{
    [TypeFilter(typeof(LoginFilter))]
    public class HomeController : Controller
    {
        public readonly IPersonService _personService;
        public readonly IAddressService _addressService;
        public readonly IPhoneService _phoneService;

        public HomeController(IPersonService personService, IAddressService addressService, IPhoneService phoneService)
        {
            _personService = personService;
            _addressService = addressService;
            _phoneService = phoneService;
        }
        public IActionResult Index()
        {
            var CariListe = _personService.GetList();
            Users user = HttpContext.Session.GetJson<Users>("user");
            TempData["UserName"] = user.Username;
            return View(CariListe);
        }

        public JsonResult GetPhones(int id)
        {
            var model = new GetUpdateModel();
            model.Unvan = _personService.Get(i=>i.PersonID==id).Title;
            model.Phones = _phoneService.GetList(i => i.PersonID == id).Select(i => i.Number).ToList();

            return Json(model);
        }

        public JsonResult GetAddress(int id)
        {
            var address = _addressService.GetList(i => i.PersonID == id).ToList();

            return Json(address);
        }

        public IActionResult Delete(int id)
        {
            Person person = _personService.Get(i=>i.PersonID==id);
            _personService.Delete(person);
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public IActionResult AddPhone(string unvan,List<double> phoneNumbers,List<string> address)
        {
            _personService.Add(new Person {Title=unvan});
            var person = _personService.Get(i=>i.Title==unvan);


            foreach (var item in phoneNumbers)
            {
                _phoneService.Add(new Phones { Number = item,PersonID=person.PersonID});
            }

            foreach (var item in address)
            {
                _addressService.Add(new Addresses { Address = item, PersonID = person.PersonID });
            }


            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int id, List<double> personNum, List<string> personAddress, string title)
        {

            var phone = _phoneService.GetList(i => i.PersonID == id).Select(i=>i.PhoneID).ToList();
            var address = _addressService.GetList(i => i.PersonID == id).Select(i=>i.AddressID).ToList();


            if (phone != null)
            {
                foreach(var item in phone)
                {
                    _phoneService.Delete(new Phones { PhoneID=item });
                }
                
            }

            if (address != null)
            {
                foreach (var item in address)
                {
                    _addressService.Delete(new Addresses { AddressID = item });
                }
                
            }


            var name = _personService.Get(i => i.PersonID == id);
            name.Title = title;
            _personService.Update(name);


            foreach (var item in personNum)
            {
                _phoneService.Add(new Phones { Number = item, PersonID = id });
            }

            foreach (var item in personAddress)
            {
                _addressService.Add(new Addresses { Address = item, PersonID = id });
            }




            return RedirectToAction("Index", "Home");
        }



    }
}