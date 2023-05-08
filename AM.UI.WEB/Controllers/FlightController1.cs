using AM.Core.Domain;
using AM.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.WEB.Controllers
{
    public class FlightController1 : Controller
    {



       readonly IFlightService fservice;
       readonly IPlaneService pService;

        public FlightController1(IFlightService fservice, IPlaneService pService)
        {
            this.fservice = fservice;
            this.pService = pService;
        }
        // GET: FlightController1

        public ActionResult Index(string filter)
        {

            DateTime date;

            if (string.IsNullOrEmpty(filter)
                || ! DateTime.TryParse(filter,out date))
            {
                return View(fservice.GetAll());
            }
            else
            {
                return View(fservice.GetAll().Where(
                    f=>f.FlightDate.CompareTo( DateTime.Parse( filter))==0
                    
                    )  );
            }


            
        }


        

        public ActionResult SortFlight()
        {
             return View("Index", fservice.SortFlights());
        }


        // GET: FlightController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlightController1/Create
        public ActionResult Create()
        {

            var planes = pService.GetAll();
            //viewBag : var partagée entre le contr et la vue 
            ViewBag.Planes = new SelectList(planes, "PlaneId", "PlaneId");
            return View();
           
        }

        // POST: FlightController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight flight)//(IFormCollection collection) 
        {
            try
            {
                fservice.Add(flight);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlightController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlightController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
