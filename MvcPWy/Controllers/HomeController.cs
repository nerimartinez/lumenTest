using MvcPWy.Models;
using ServicesLayer.Services;
using ServicesImplementations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Text;
using MvcPWy.Helpers;

namespace MvcPWy.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [Authorize]
        public ActionResult Index()
        {
            ViewBag.user = User.Identity.Name;            
                        
            var t =new DeviceService().GetAll( User.Identity.Name);
            var ta = new LocationService().GetAll();

            return View();
        }

        [Authorize]        
        public async Task<ActionResult>  Done()
        {            
            var devices = new DeviceService().GetAll(User.Identity.Name);
            var subject = "Devices submitted";
            var fname = User.Identity.GetFirstName();
            var lname = User.Identity.GetLastName();
            var body = MailHelper.SetupMail(fname, lname, devices);

            await UserManager.SendEmailAsync(User.Identity.GetUserId(), subject, body.ToString());

            return View("Info");
        }

        [Authorize]
        public ActionResult InfoSubmission()
        {
            ViewBag.Title = "Thank you";
            ViewBag.Message = "The information is being received and an email will be sent to your email account with the added information for your records. ";                       

            return View("Info");
        }
    }
}