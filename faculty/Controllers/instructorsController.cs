using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using faculty.Models;
using System.Net;

namespace faculty.Controllers
{
    
    public class instructorsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: instructors
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Course course = db.course.Find(id);
        //    if (course == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(course);
        //}
        public ActionResult edit(string id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                instructor instructor = db.instructor.Find(id);
                if(instructor==null)
                {
                    return HttpNotFound();
                }
                return View(instructor);

            }
        }

    }
}