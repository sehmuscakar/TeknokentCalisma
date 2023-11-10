using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class TeknokentController : Controller
    {
        private readonly ITeknokentService _teknokentService;

        public TeknokentController(ITeknokentService teknokentService)
        {
            _teknokentService = teknokentService;
        }

        public ActionResult Index()//burda listeleme yapacaz
        {
            var listele = _teknokentService.TGetList();
            return View(listele);
        }

      
        public ActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teknokent teknokent)
        {
            try
            {
                _teknokentService.TInsert(teknokent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

     
        public ActionResult Edit(int id)
        {
            var datagetir = _teknokentService.TGetByID(id);
            return View(datagetir);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Teknokent teknokent)
        {
            try
            {
                _teknokentService.TUpdate(teknokent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

  
        public ActionResult Delete(int id)
        {
            var datagetir = _teknokentService.TGetByID(id);
            return View(datagetir);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Teknokent teknokent)
        {
            try
            {
                _teknokentService.TDelete(teknokent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
