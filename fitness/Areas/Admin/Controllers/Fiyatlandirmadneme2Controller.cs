﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fitness.Models;

namespace fitness.Areas.Admin.Controllers
{
    public class Fiyatlandirmadneme2Controller : Controller
    {
       
            private AcademyContext db = new AcademyContext();

            // GET: Admin/Reservs
            public ActionResult Index()
            {
                return View();
            }

        // GET: Admin/Reservs/Details/5
        public ActionResult Details(int id)
        {

            Users fiyat = db.Users.Find(id);
            if (fiyat == null)
            {
                return HttpNotFound();
            }
            return View(fiyat);
        }

        // GET: Admin/Reservs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Reservs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "baslangicfiyat, premiumfiyat, profosyonelfiyat, fiyat")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(users);
                db.SaveChanges();
                return View();
            }

            return View(users);
        }

        // GET: Admin/Reservs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // post: admin/reservs/edit/5
        // to protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?linkıd=317598.
        //[httppost]
        //[validateantiforgerytoken]
        //public actionresult edit([bind(ınclude = "baslangic, profosyonel,  premium, baslangicfiyat, profosyonelfiyat, premiumfiyat, fiyat")] users users)
        //{
        //    if (modelstate.ısvalid)
        //    {
        //        db.entry(users).state = entitystate.modified;
        //        db.savechanges();
        //        return redirecttoaction("ındex");
        //    }
        //    return view(users);
        //}

        // GET: Admin/Reservs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Admin/Reservs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Users users = db.Users.Find(id);
            db.Users.Remove(users);
            db.SaveChanges();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
