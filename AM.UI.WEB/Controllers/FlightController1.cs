using AM.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.UI.WEB.Controllers
{
    public class FlightController1 : Controller
    {



       readonly IFlightService fservice;
        public FlightController1(IFlightService fservice)
        {
            this.fservice = fservice;
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




        public ActionResult Index2(string filter)
        {

       

        
            {
                return View(fservice.SortFlights
                   

                    );
            }



        }


        // GET: FlightController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlightController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlightController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
