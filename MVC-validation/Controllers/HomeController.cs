using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_validation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Company()
        {
            return View(new CompanyInput());
        }
        [HttpPost]
        public ActionResult Company(CompanyInput input)
        {

            if (!ModelState.IsValid)
            {
                return View("Company",input);
            }

            return View();

        }
    }

    public class CompanyInput
    {
        [Required ]
        [DisplayName("Название компании")]
        public string CompanyName { get; set; }
        [Required]
        [DisplayName("Электронный адрес компании")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(12,MinimumLength = 12,ErrorMessage = "Значение должно быть ровно 12")]
        public string Bin { get; set; }

    }
}