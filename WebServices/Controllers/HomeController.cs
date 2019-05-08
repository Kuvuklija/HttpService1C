using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebServices.Models;
using System.Linq;
using System.Collections.Generic;

namespace WebServices.Controllers{

    public class HomeController : Controller{

        //  ---MVC---
        //private ReservationRepository repo = ReservationRepository.Current;
    
        //public ActionResult Index(){
        //    return View(repo.GetAll());
        //}

        //public ActionResult Add(Reservation item) {
        //    if (ModelState.IsValid) {
        //        repo.Add(item);
        //        return RedirectToAction("Index");
        //    } else {
        //        return View("Index");
        //    }
        //}

        //public ActionResult Remove(int id) {
        //    repo.Remove(id);
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Update(Reservation item) {
        //    if(ModelState.IsValid && repo.Update(item)) {
        //        return RedirectToAction("Index");
        //    } else {
        //        return View("Index");
        //    }
        //}

        public ViewResult Index() {
            return View(); //only html-markup, model is used by API controller
        }

        private MarksReservationRepository repo = MarksReservationRepository.CurrentRepository;

        [HttpPost]
        public  JsonResult ReserveMarksRequest() {
            Stream req = Request.InputStream;
            req.Seek(0, SeekOrigin.Begin);
            string json = new StreamReader(req).ReadToEnd();

            ReserveMarksRequest input = null;
            try {
                input = JsonConvert.DeserializeObject<ReserveMarksRequest>(json);
                //JavaScriptSerializer ser = new JavaScriptSerializer();
                //input = ser.Deserialize<ReserveMarksRequest>(json);
                input.Status = "Reserved";

                //request to base
                string location = input.Location;
                string document = input.Document;
                IEnumerable<string> ListID = from material in input.Materials
                                                select material.Id;
                IEnumerable<string> ListBatch = from material in input.Materials
                                                select material.Batch;

                IEnumerable<ReserveMarksResponse> result= repo.Get(location, document, ListID, ListBatch);

            } catch{
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return Json(new { Status="BAD", Data="" }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { Status="SUCCES", Data=new[] {"Vadim","Anna"} }, JsonRequestBehavior.AllowGet);
        }
    }
}