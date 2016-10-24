using AutoMapper;
using KariyerPortali.Model;
using KariyerPortali.Service;
using KariyerPortali.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KariyerPortali.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICvService cvService;

        public HomeController(ICvService cvService)
        {
            this.cvService = cvService;
        }

        public ActionResult Index()
        {
            IEnumerable<CvViewModel> viewModelCvs;
            IEnumerable<Cv> cvs;

            cvs = cvService.GetCvs().ToList();

            viewModelCvs = Mapper.Map<IEnumerable<Cv>, IEnumerable<CvViewModel>>(cvs);

            return View(viewModelCvs);
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
    }
}